using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    public partial class Ticket_overview : Form
    {
        private readonly User currentUser;
        private readonly TicketService ticketService = new TicketService();

        public Ticket_overview(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblLogin.Text = user.Last_name + ", " + user.First_name;
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

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            CreateTicket createTicket = new CreateTicket(currentUser);
            createTicket.ShowDialog();
            this.Close();
            */
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(currentUser);
            dashboard.ShowDialog();
            this.Close();
        }

        private void btnUM_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_overview userManagement = new User_overview(currentUser);
            userManagement.ShowDialog();
            this.Close();
        }

        private void btnIM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_overview incidentManagement = new Ticket_overview(currentUser);
            incidentManagement.ShowDialog();
            this.Close();
        }
    }
}
