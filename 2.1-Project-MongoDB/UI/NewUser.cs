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
        private User currentUser;
        public NewUser(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblLogin.Text = user.First_name + user.Last_name;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //geting info from ui to object
            User newUser = new User();
            newUser.First_name = textBoxfname.Text;
            newUser.Last_name = textBoxlname.Text;
            comboBoxuser.DataSource = Enum.GetValues(typeof(UserType));
            newUser.Type = (UserType)comboBoxuser.SelectedItem;
            newUser.Email = textBoxemail.Text;
            newUser.Phone = int.Parse(textBoxphone.Text);
            comboBoxlocation.DataSource = Enum.GetValues(typeof(UserLocation));
            newUser.Location = (UserLocation)comboBoxlocation.SelectedItem;


            if (checkBoxpassword.Checked)
            {
                //
            }

            //adding user to database
            userService.NewUser(newUser);
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
            this.Hide();
            Dashboard dashboard = new Dashboard(currentUser);
            dashboard.ShowDialog();
            this.Close();
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
