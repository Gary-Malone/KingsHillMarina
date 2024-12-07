using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace KingsHillMarina
{
    internal class PierHelper
    {
        List<Pier> piers = new List<Pier>();

        public PierHelper() { }

        public List<Pier> getPiers() 
        {
            return piers; 
        }
        //Loads all piers
        //If withBoats = true, only piers with boats are loaded
        //Else only piers without boats are loaded
        public void loadPiers(bool withBoats)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Marina"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);
                    String sql = "SELECT tblPier.id, berthId, tblBoat.id AS boatId " +
                        "FROM tblPier " +
                        "LEFT OUTER JOIN tblBoat ON tblBoat.pierId = tblPier.id ";
                    if (withBoats)
                    {
                        sql += "WHERE tblBoat.id IS NOT NULL ";
                    }
                    else
                    {
                       sql += "WHERE tblBoat.id IS NULL ";
                    }
                    sql += "ORDER BY berthId, tblPier.id ";
                    command.CommandText = sql;

                    command.Prepare();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (withBoats)
                            {
                                Pier pier = new Pier(Int32.Parse(reader["id"].ToString()), reader["berthId"].ToString(), Int32.Parse(reader["boatId"].ToString()));
                                this.piers.Add(pier);
                            }
                            else
                            {
                                Pier pier = new Pier(Int32.Parse(reader["id"].ToString()), reader["berthId"].ToString());
                                this.piers.Add(pier);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception found: " + ex.Message);
            }
        }
    }
}
