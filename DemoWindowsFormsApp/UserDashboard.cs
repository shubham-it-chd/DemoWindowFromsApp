using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWindowsFormsApp
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            panel2.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure, You want to save the details?", "Dialog", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                lblFirstName.Text = txtFirstName.Text;
                lblLastName.Text = txtLastName.Text;
                lblDOB.Text = dtpDOB.Value.ToString("MM/dd/yyyy");
                lblMobile.Text = txtMobile.Text;
                panel1.Hide();
                panel2.Show();
            }
            //clear form
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobile.Text = "";
            dtpDOB.Value = DateTime.Now;
        }



        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
