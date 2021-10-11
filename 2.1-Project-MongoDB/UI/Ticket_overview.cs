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
    public partial class Ticket_overview : Form
    {
        TicketService ticketService = new TicketService();
        public Ticket_overview()
        {
            InitializeComponent();
        }

        private void Ticket_overview_Load(object sender, EventArgs e)
        {
            Display_All();
        }

        private void Display_All()
        {
            List<Ticket> tickets = ticketService.getAll();
            foreach (Ticket ticket in tickets)
            {
                dataTicket.Rows.Add(ticket.id, ticket.Subject, ticket.User, ticket.Date, ticket.Priority, ticket.Deadline);
            }
        }
    }
}
