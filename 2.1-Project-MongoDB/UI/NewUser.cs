using System;
using System.ComponentModel;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    public partial class NewUser : Form
    {
        private readonly User currentUser;
        private readonly UserService userService= new UserService();

        public NewUser(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblLogin.Text = user.Last_name + ", " + user.First_name + " (" + user.Type + ")";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //geting info from UI to object
            User newUser = new User();
            newUser.First_name = textBoxfname.Text;
            newUser.Last_name = textBoxlname.Text;
            newUser.Type = (UserType)Enum.Parse(typeof(UserType), comboBoxuser.SelectedItem.ToString());
            newUser.Email = textBoxemail.Text;
            newUser.Phone = textBoxphone.Text;
            newUser.Location = (UserLocation)Enum.Parse(typeof(UserLocation), comboBoxlocation.SelectedItem.ToString());

            if (checkBoxpassword.Checked)
            {
                //
            }

            //passing user to be added to database
            try
            {
                userService.AddNewUser(newUser);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error while creating user: {ex}");
            }
            finally
            {
                MessageBox.Show($"User created successfully!");
                btnCancel.PerformClick();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            textBoxfname.Text = "";
            textBoxlname.Text = "";
            comboBoxuser.Text = "";
            textBoxemail.Text = "";
            textBoxphone.Text = "";
            comboBoxlocation.Text = "";
            checkBoxpassword.Checked = false;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(currentUser);
            dashboard.ShowDialog();
            this.Close();
        }

        private void BtnUM_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_overview userManagement = new User_overview(currentUser);
            userManagement.ShowDialog();
            this.Close();
        }

        private void BtnIM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_overview incidentManagement = new Ticket_overview(currentUser);
            incidentManagement.ShowDialog();
            this.Close();
        }
    }
}
