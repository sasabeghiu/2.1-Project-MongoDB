using Logic;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        readonly UserService userService = new UserService();

        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtUsername.Text == "") || (txtPassword.Text == ""))
                {
                    MessageBox.Show("Please fill in both useranme and password", "Attention");
                    return;
                }

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
                ErrorProcess(ex, "Something went wrong while loging in");
            }
        }
        private void ErrorProcess(Exception ex, string messege)
        {
            MessageBox.Show(messege, "Error occured");
            // write to error log file
            StreamWriter sw = File.AppendText("..\\..\\..\\Error Log.txt");
            sw.WriteLine(messege);
            Console.WriteLine(ex);
            Console.WriteLine();
            sw.Close();
        }
    }
}
