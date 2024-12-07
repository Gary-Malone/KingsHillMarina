using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace KingsHillMarina
{
    internal class Owner
    {

        private int id;
        private String name;
        private String email;
        private String phoneNumber;

        public Owner(String name, String email, String phoneNumber)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public Owner(int id, String name, String email, String phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public int Id { get { return this.id; } set { this.id = value; } }
        public String Name { get { return this.name; } set { this.name = value; } }
        public String Email { get { return this.email; } set { this.email = value; } }
        public String PhoneNumber { get { return this.phoneNumber; } set { this.phoneNumber = value; } }

        public void insertNewOwner()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Marina"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);
                    command.CommandText = "INSERT INTO tblOwner(name, email, phoneNumber)" +
                        "VALUES(@name, @email, @phoneNumber)";

                    SqlParameter nameParam = new SqlParameter("@name", SqlDbType.NVarChar, 255);
                    nameParam.Value = this.name;
                    SqlParameter emailParam = new SqlParameter("@email", SqlDbType.NVarChar, 255);
                    emailParam.Value = this.email;
                    SqlParameter phoneNumber = new SqlParameter("@phoneNumber", SqlDbType.NVarChar, 255);
                    phoneNumber.Value = this.phoneNumber;
                    command.Parameters.Add(nameParam);
                    command.Parameters.Add(emailParam);
                    command.Parameters.Add(phoneNumber);

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

        public String validateOwnerInsert()
        {
            String errorMessage = "";

            if (Name.Length == 0)
            {
                errorMessage += "Please input a name" + Environment.NewLine;
            }
            else if (Name.Length > 255)
            {
                errorMessage += "Name must be lower than 255 characters" + Environment.NewLine;
            }
           
            if (Email.Length == 0)
            {
                errorMessage += "Please input an email" + Environment.NewLine;
            }
            else if (Email.Length > 255)
            {
                errorMessage += "Email must be lower than 255 characters" + Environment.NewLine;
            }

            if (PhoneNumber.Length == 0)
            {
                errorMessage += "Please input a phone number" + Environment.NewLine;
            }
            else if (PhoneNumber.Length > 255)
            {
                errorMessage += "Phone number must be lower than 255 characters" + Environment.NewLine;
            }

            return errorMessage;
        }
    }
}
