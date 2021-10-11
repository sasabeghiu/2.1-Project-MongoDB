using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBoxfname.Text = "";
            textBoxlname.Text = "";
            comboBoxuser.Text = "";
            textBoxemail.Text = "";
            textBoxphone.Text = "";
            comboBoxlocation.Text = "";
            checkBoxpassword.Checked = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Close();
            */
        }
    }
}
