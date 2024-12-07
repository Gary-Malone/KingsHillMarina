using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsHillMarina
{
    public partial class NewOwnerForm : Form
    {
        public NewOwnerForm()
        {
            InitializeComponent();
        }

        private void btnSaveOwner_Click(object sender, EventArgs e)
        {

            Owner owner = new Owner(txtName.Text, txtEmail.Text, txtPhoneNumber.Text);
            String errors = owner.validateOwnerInsert();
            if (errors == null || errors.Length == 0)
            {
                owner.insertNewOwner();
                MessageBox.Show("Owner inserted!");
                this.Close();
            }
            else
            {
                MessageBox.Show(errors);
            }
        }
    }
}
