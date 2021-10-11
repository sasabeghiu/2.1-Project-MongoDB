using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    public partial class User_overview : Form
    {
        private readonly User currentUser;
        private readonly UserService userService = new UserService();

        public User_overview(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblLogin.Text = user.Last_name + ", " + user.First_name;
        }

        private void User_overview_Load(object sender, EventArgs e)
        {
            Display_All();
        }

        private void Display_All()
        {
            List<User> users = userService.getAll();
            foreach (User user in users)
            {
                dataUser.Rows.Add(user.id, user.Email, user.First_name, user.Last_name);
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser addUser = new NewUser(currentUser);
            addUser.ShowDialog();
            this.Close();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(currentUser);
            dashboard.ShowDialog();
            this.Close();
        }

        private void BtnIM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_overview incidentManagement = new Ticket_overview(currentUser);
            incidentManagement.ShowDialog();
            this.Close();
        }

        private void btnUM_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_overview userManagement = new User_overview(currentUser);
            userManagement.ShowDialog();
            this.Close();
        }
    }
}
