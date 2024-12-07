using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KingsHillMarina
{
    internal class Boat
    {

        public readonly decimal costPerMonth = 51.85m;
        public readonly decimal vat = 0.20m;
        public Boat() { }

        public Boat(string boatName, string boatMake, string boatType, int ownerId, DateTime dockedAt, int pierId)
        {
            BoatName = boatName;
            BoatMake = boatMake;
            BoatType = boatType;
            OwnerId = ownerId;
            DockedAt = dockedAt;
            PierId = pierId;
        }

        private int id;
        private String boatName;
        private String boatMake;
        private String boatType;
        private int ownerId;
        private DateTime dockedAt;
        private int pierId;
        private Owner owner;

        public int Id { get { return this.id; } set { this.id = value;} }
        public String BoatName { get { return this.boatName; } set { this.boatName = value; } }
        public String BoatMake { get { return this.boatMake; } set { this.boatMake = value; } }
        public String BoatType { get { return this.boatType; } set { this.boatType = value; } }
        public int OwnerId { get { return this.ownerId; } set { this.ownerId = value; } }
        public DateTime DockedAt { get { return this.dockedAt; } set { this.dockedAt = value; } }
        public int PierId { get { return this.pierId; } set { this.pierId = value; } }
        public Owner Owner { get { return this.owner; } set { this.owner = value; } }

        public void insertNewBoat()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Marina"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);
                    command.CommandText = "INSERT INTO tblBoat(boatName, boatMake, boatType, ownerId, dockedAt, pierId)" +
                        "VALUES(@boatName, @boatMake, @boatType, @ownerId, @dockedAt, @pierId)";

                    SqlParameter boatNameParam = new SqlParameter("@boatName", SqlDbType.NVarChar, 255);
                    boatNameParam.Value = this.boatName;
                    SqlParameter boatMakeParam = new SqlParameter("@boatMake", SqlDbType.NVarChar, 255);
                    boatMakeParam.Value = this.boatMake;
                    SqlParameter boatTypeParam = new SqlParameter("@boatType", SqlDbType.NVarChar, 255);
                    boatTypeParam.Value = this.boatType;
                    SqlParameter ownerIdParam = new SqlParameter("@ownerId", SqlDbType.Int, 255);
                    ownerIdParam.Value = this.ownerId;
                    SqlParameter dockedAtParam = new SqlParameter("@dockedAt", SqlDbType.Date, 255);
                    dockedAtParam.Value = this.dockedAt;
                    SqlParameter pierIdParam = new SqlParameter("@pierId", SqlDbType.NVarChar, 255);
                    pierIdParam.Value = this.pierId;
                    command.Parameters.Add(boatNameParam);
                    command.Parameters.Add(boatMakeParam);
                    command.Parameters.Add(boatTypeParam);
                    command.Parameters.Add(ownerIdParam);
                    command.Parameters.Add(dockedAtParam);
                    command.Parameters.Add(pierIdParam);

                    command.Prepare();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception found: " + ex.Message);
            }
        }

        public void loadBoatById(int boatId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Marina"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);
                    command.CommandText = "SELECT tblBoat.id, boatName, boatMake, boatType, ownerId, tblOwner.name, tblOwner.email," +
                        "tblOwner.phoneNumber, dockedat, pierId " +
                        "FROM tblBoat " +
                        "INNER JOIN tblOwner ON tblOwner.id = tblBoat.ownerId " +
                        "INNER JOIN tblPier ON tblPier.id = tblBoat.pierId " +
                        "WHERE tblBoat.id = @boatId ";

                    SqlParameter boatIdParam = new SqlParameter("@boatId", SqlDbType.Int);
                    boatIdParam.Value = boatId;
                    command.Parameters.Add(boatIdParam);
                    command.Prepare();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            this.id = Int32.Parse(reader["id"].ToString());
                            this.boatName = reader["boatName"].ToString();
                            this.boatMake = reader["boatMake"].ToString();
                            this.boatType = reader["boatType"].ToString();
                            this.owner = new Owner(reader["name"].ToString(), reader["email"].ToString(),
                                reader["phoneNumber"].ToString());
                            this.dockedAt = DateTime.Parse(reader["dockedat"].ToString());
                            this.id = Int32.Parse(reader["pierId"].ToString());
                        }
                    }
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception found: " + ex.Message);
            }
        }

        public decimal calculateBerthCost()
        {
            decimal berthCost = 0.00m;

            DateTime today = DateTime.Today;
            
            //get the difference in months of todays date and the docked date
            int months = (today.Year - DockedAt.Year) * 12 + today.Month - DockedAt.Month;

            //if todays dates day is greater than the docked date, we haven't lapsed a full month yet, so remove 1 month
            if(today.Day < dockedAt.Day - 1)
            {
                months--;
            }

            berthCost = this.costPerMonth * months;

            decimal vatValue = berthCost * this.vat;

            berthCost += vatValue;

            return berthCost;
        }

        public String validateBoatInsert()
        {
            String errorMessage = "";

            DateTime today = DateTime.Today;

            if(BoatName.Length == 0)
            {
                errorMessage += "Please input a boat name" + Environment.NewLine;
            }
            else if (BoatName.Length > 255)
            {
                errorMessage += "Boat name must be lower than 255 characters" + Environment.NewLine;
            }

            if (BoatMake.Length == 0)
            {
                errorMessage += "Please input a boat make" + Environment.NewLine;
            }
            else if (BoatMake.Length > 255)
            {
                errorMessage += "Boat length must be lower than 255 characters" + Environment.NewLine;
            }

            if (BoatType.Length == 0)
            {
                errorMessage += "Please input a boat type" + Environment.NewLine;
            }
            else if (BoatType.Length > 255)
            {
                errorMessage += "Boat type must be lower than 255 characters" + Environment.NewLine;
            }

            if (today.Date <= DockedAt.Date)
            {
                errorMessage += "Date must be before todays date" + Environment.NewLine;
            }

            return errorMessage;
        }

    }


}
