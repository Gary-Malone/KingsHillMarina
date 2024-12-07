using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsHillMarina
{
    public partial class NewBoatForm : Form
    {
        public NewBoatForm()
        {
            InitializeComponent();
            OwnerHelper ownerHelper = new OwnerHelper();
            ownerHelper.loadOwners();
            cmbOwner.DataSource = ownerHelper.getOwners();
            cmbOwner.DisplayMember = "name";
            cmbOwner.ValueMember = "id";

            PierHelper pierHelper = new PierHelper();
            pierHelper.loadPiers(false);
            cmbPier.DataSource = pierHelper.getPiers();
            cmbPier.DisplayMember = "PierLabel";
            cmbPier.ValueMember = "id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boat boat = new Boat(txtBoatName.Text, txtBoatMake.Text, txtBoatType.Text, Int32.Parse(cmbOwner.SelectedValue.ToString()), 
                DateTime.Parse(dtpDockedAt.Text), Int32.Parse(cmbPier.SelectedValue.ToString()));
            String errors = boat.validateBoatInsert();
            if (errors == null || errors.Length == 0) {
                boat.insertNewBoat();
                MessageBox.Show("Boat inserted!");
                this.Close();
            }
            else
            {
                MessageBox.Show(errors);
            }
            
        }
    }
}
