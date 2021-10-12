using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    public partial class Ticket_overview : Form
    {
        //creating the objects we will need later on
        private readonly User currentUser;
        private readonly TicketService ticketService = new TicketService();
        //passing the current user to the form
        public Ticket_overview(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblLogin.Text = user.Last_name + ", " + user.First_name;
        }
        //form loading
        private void Ticket_overview_Load(object sender, EventArgs e)
        {
            Display_All();
        }
        //display all tickets from database
        private void Display_All()
        {
            List<Ticket> tickets = ticketService.getAll();
            foreach (Ticket ticket in tickets)
            {
                dataTicket.Rows.Add(ticket.id, ticket.Subject, ticket.User, ticket.Date, ticket.Priority, ticket.Deadline.ToString("dd/mm/yyyy"));
            }
        }
        //create new ticket
        private void BtnCreateTicket_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            CreateTicket createTicket = new CreateTicket(currentUser);
            createTicket.ShowDialog();
            this.Close();
            */
        }
        //go to dashboard
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(currentUser);
            dashboard.ShowDialog();
            this.Close();
        }
        //go to user view
        private void BtnUM_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_overview userManagement = new User_overview(currentUser);
            userManagement.ShowDialog();
            this.Close();
        }
        //refresh
        private void BtnIM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_overview incidentManagement = new Ticket_overview(currentUser);
            incidentManagement.ShowDialog();
            this.Close();
        }
    }
}
