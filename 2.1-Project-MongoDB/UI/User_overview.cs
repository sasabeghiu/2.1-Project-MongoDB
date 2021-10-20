using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    //left to do: display object id as integer id
    public partial class User_overview : Form
    {
        //creating the objects we will need later on
        private readonly User currentUser;
        private readonly UserService userService = new UserService();
        //passing the current user to the form
        public User_overview(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblLogin.Text = user.Last_name + ", " + user.First_name + " (" + user.Type + ")";
        }
        //form loading
        private void User_overview_Load(object sender, EventArgs e)
        {
            Display_All();
            if (currentUser.Type == UserType.Admin)
            {
                btnAddUser.Enabled = true;
            }
            else
            {
                btnAddUser.Enabled = false;
            }
        }
        //display all users from database
        private void Display_All()
        {
            List<User> users = userService.getAll();
            foreach (User user in users)
            {
                dataUser.Rows.Add(user.Id, user.Email, user.First_name, user.Last_name, user.Tickets);
            }
        }
        //filter by email (has to be the exact email otherwise it won't show)
        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            dataUser.Rows.Clear();
            string search = txtFilter.Text;
            List<User> users = userService.FilterUsers(x => x.Email == search);
            foreach (User user in users)
            {
                dataUser.Rows.Add(user.Id, user.Email, user.First_name, user.Last_name, user.Tickets);
            }

            if (txtFilter.Text == "")
            {
                Display_All();
            }
        }
        //add new user
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser addUser = new NewUser(currentUser);
            addUser.ShowDialog();
            this.Close();
        }
        //go to dashboard
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(currentUser);
            dashboard.ShowDialog();
            this.Close();
        }
        //go to ticket view
        private void BtnIM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_overview incidentManagement = new Ticket_overview(currentUser);
            incidentManagement.ShowDialog();
            this.Close();
        }
        //refresh
        private void BtnUM_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_overview userManagement = new User_overview(currentUser);
            userManagement.ShowDialog();
            this.Close();
        }
    }
}
