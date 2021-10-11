using Logic;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class Login : Form
    {

        UserService userService = new UserService();


        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "") || (txtPassword.Text == ""))
            {
                MessageBox.Show("Please fill in both useranme and password", "Attention");
                return;
            }

            try
            {
                User user = userService.UserLogin(txtUsername.Text, txtPassword.Text);
                if (user == null)
                {
                    MessageBox.Show("Wrong username or password", "Login Failed");
                }
                else
                {
                    Dashboard dashboard = new Dashboard(user);
                    dashboard.Show();
                    this.Hide();
                    dashboard.Closed += (s, args) => this.Close();
                }

            }

            catch (Exception ex)
            {

            }




        }
    }
}
