using Model;
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
    public partial class Dashboard : Form
    {
        private readonly User currentUser;
        public Dashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblLoggedIn.Text = user.Last_name + ", " + user.First_name + " (" + user.Type + ")";
        }

        private void BtnIM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_overview form = new Ticket_overview(currentUser);
            form.ShowDialog();
            this.Close();
        }

        private void BtnUM_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_overview form = new User_overview(currentUser);
            form.ShowDialog();
            this.Close();
        }
    }
}
