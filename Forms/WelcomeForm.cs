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
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            NewOwnerForm newOwnerForm = new NewOwnerForm();
            newOwnerForm.ShowDialog();
        }

        private void btnAddBoat_Click(object sender, EventArgs e)
        {
            NewBoatForm newBoatForm = new NewBoatForm();
            newBoatForm.ShowDialog();
        }

        private void btnViewPiers_Click(object sender, EventArgs e)
        {
            ViewPierForm viewPierForm = new ViewPierForm();
            viewPierForm.ShowDialog();
        }
    }
}
