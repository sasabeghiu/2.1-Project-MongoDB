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
using Logic;
using MongoDB;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UI
{
    public partial class UpdateTicket : Form
    {
        ObjectId userID { get; set; }
        User User { get; set; }
        Ticket Ticket { get; set; }
        public UpdateTicket(Ticket ticket, User user)
        {
            InitializeComponent();
            Ticket = ticket;
            User = user;
            InitializeCombobox();
        }
        private void InitializeCombobox()
        { 
            if(User.Type != UserType.Admin && Ticket.Status == TicketStatus.Escalated)
            {
                lblText.Text = "You do not have permission to update the status of this ticket. \n Please contact your supervisor";
                comboBoxStatus.Enabled = false;
                btnUpdateTicket.Enabled = false;
            }
            else
            {
                lblText.Text = $"Update status for ticket '{Ticket.Subject}'";
                comboBoxStatus.Items.Add(TicketStatus.Escalated);
                comboBoxStatus.Items.Add(TicketStatus.Closed);
            }
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();
            ticketService.UpdateStatus(Ticket.id, (TicketStatus)comboBoxStatus.SelectedItem);
            this.Close();
        }
    }
}
