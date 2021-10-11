using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    public partial class NewUser : Form
    {
        private UserService userService;
        public NewUser()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //geting info from ui to object
            User user = new User();
            user.First_name = textBoxfname.Text;
            user.Last_name = textBoxlname.Text;
            comboBoxuser.DataSource = Enum.GetValues(typeof(UserType));
            user.Type = (UserType)comboBoxuser.SelectedItem;
            user.Email = textBoxemail.Text;
            user.Phone = int.Parse(textBoxphone.Text);
            comboBoxlocation.DataSource = Enum.GetValues(typeof(UserLocation));
            user.Location = (UserLocation)comboBoxlocation.SelectedItem;


            if (checkBoxpassword.Checked)
            {
                //
            }

            //adding user to database
            userService.NewUser(user);
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

        private void btnUM_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_overview form = new User_overview();
            form.ShowDialog();
            this.Close();
        }
    }
}
