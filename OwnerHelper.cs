using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsHillMarina
{
    internal class OwnerHelper
    {
        List<Owner> owners = new List<Owner>();

        public OwnerHelper() { }

        public List<Owner> getOwners() 
        {
            return owners; 
        }
        public void loadOwners()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Marina"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);
                    command.CommandText = "SELECT id, name, email, phoneNumber " +
                        "FROM tblOwner ";

                    command.Prepare();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Owner owner = new Owner(Int32.Parse(reader["id"].ToString()), reader["name"].ToString(), 
                                reader["email"].ToString(), reader["phoneNumber"].ToString());
                            this.owners.Add(owner);
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
