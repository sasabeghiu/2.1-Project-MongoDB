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
    public partial class User_overview : Form
    {
        UserService userService = new UserService();
        public User_overview()
        {
            InitializeComponent();
        }

        private void User_overview_Load(object sender, EventArgs e)
        {
            Display_All();
        }

        private void Display_All()
        {
            List<User> users = userService.getAll();
            foreach(User user in users)
            {
                dataUser.Rows.Add(user.id, user.Email, user.First_name, user.Last_name);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser form = new NewUser();
            form.ShowDialog();
            this.Close();
            
        }
    }
}
