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
    public partial class TransferTicket : Form
    {
        public TransferTicket(Ticket ticket)
        {
            InitializeComponent();
            transfterLbl.Text = $"Transfer from {ticket.User} to ";
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
