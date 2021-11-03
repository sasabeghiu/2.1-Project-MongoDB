using System;
using System.Collections.Generic;
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
            try
            {
                //geting info from UI to object
                User newUser = new User();
                newUser.First_name = textBoxfname.Text;
                newUser.Last_name = textBoxlname.Text;
                newUser.Type = (UserType)Enum.Parse(typeof(UserType), (string)comboBoxuser.SelectedItem);
                newUser.Email = textBoxemail.Text;
                newUser.Phone = textBoxphone.Text;
                newUser.Location = (UserLocation)Enum.Parse(typeof(UserLocation), (string)comboBoxlocation.SelectedItem);

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    userService.AddNewUser(newUser); //passing user to be added to database
                    MessageBox.Show($"User created successfully!");
                    btnCancel.PerformClick();
                }
                else
                {
                    MessageBox.Show("Please fill in all the details.");
                }
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("Error whille creating the user, please try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0, $"Exception: {ex}");
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

        private void textBoxfname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxfname.Text))
            {
                e.Cancel = true;
                textBoxfname.Focus();
                errorProviderText.SetError(textBoxfname, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderText.SetError(textBoxfname, "");
            }
        }

        private void textBoxlname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxlname.Text))
            {
                e.Cancel = true;
                textBoxlname.Focus();
                errorProviderText.SetError(textBoxlname, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderText.SetError(textBoxlname, "");
            }
        }

        private void textBoxemail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxemail.Text))
            {
                e.Cancel = true;
                textBoxemail.Focus();
                errorProviderText.SetError(textBoxemail, "Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderText.SetError(textBoxemail, "");
            }
        }

        private void textBoxphone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxphone.Text))
            {
                e.Cancel = true;
                textBoxphone.Focus();
                errorProviderText.SetError(textBoxphone, "Phone should not be left blank!");
            }
            else
            {
                try
                {
                    if (int.Parse(textBoxphone.Text) >= 0)
                    {
                        e.Cancel = false;
                        errorProviderText.SetError(textBoxphone, "");
                    }
                }
                catch (Exception ex)
                {
                    e.Cancel = true;
                    textBoxphone.Focus();
                    errorProviderText.SetError(textBoxphone, "Phone should only contain numbers!");
                    textBoxphone.Text = "";
                }
            }
        }

        private void comboBoxuser_Leave(object sender, EventArgs e)
        {
            if (!comboBoxuser.Items.Contains(comboBoxuser.Text))
            {
                MessageBox.Show("Please select a type of user");
                comboBoxuser.Select();
            }
        }

        private void comboBoxlocation_Leave(object sender, EventArgs e)
        {
            if (!comboBoxlocation.Items.Contains(comboBoxlocation.Text))
            {
                MessageBox.Show("Please select a location/branch");
                comboBoxlocation.Select();
            }
        }
    }
}
