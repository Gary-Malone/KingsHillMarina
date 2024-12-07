using System;
using System.Windows.Forms;

namespace KingsHillMarina
{
    public partial class ViewPierForm : Form
    {
        public ViewPierForm()
        {
            InitializeComponent();
            PierHelper pierHelper = new PierHelper();
            pierHelper.loadPiers(true);
            cmbPier.DataSource = pierHelper.getPiers();
            cmbPier.DisplayMember = "PierLabel";
            cmbPier.ValueMember = "BoatId";
        }

        private void btnLoadBoat_Click(object sender, EventArgs e)
        {
            Boat boat = new Boat();
            boat.loadBoatById(Int32.Parse(cmbPier.SelectedValue.ToString()));
            lblBoatName.Text = boat.BoatName;
            lblBoatMake.Text = boat.BoatMake;
            lblBoatType.Text = boat.BoatType;
            lblDockedAt.Text = boat.DockedAt.ToString();
            lblOwnerName.Text = boat.Owner.Name;
            lblOwnerEmail.Text = boat.Owner.Email;
            lblOwnerPhoneNumber.Text = boat.Owner.PhoneNumber;
            lblCost.Text = boat.calculateBerthCost().ToString("#.##");
        }

    }
}
