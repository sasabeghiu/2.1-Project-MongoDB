using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class NewTicket : Form
    {
        //creating the objects we will need later on
        private readonly User currentUser;
        public NewTicket(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblLogin.Text = user.Last_name + ", " + user.First_name + " (" + user.Type + ")";
        }
    }
}
