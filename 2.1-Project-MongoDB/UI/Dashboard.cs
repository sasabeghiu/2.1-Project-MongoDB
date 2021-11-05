using Logic;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class Dashboard : Form
    {
        private User currentUser;
        private TicketService ticketService;
        private List<Ticket> tickets;

        public Dashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblLoggedIn.Text = user.Last_name + ", " + user.First_name + " (" + user.Type + ")";

            btnUM.Enabled = (user.Type == UserType.Admin);

            ticketService = new TicketService();
            tickets = ticketService.getAll();

            int openTickets = 0;
            int urgentTickets = 0;

            foreach (Ticket t in tickets)
            {
                if (t.Status == TicketStatus.Open)
                {
                    openTickets++;
                }
                if (t.Status == TicketStatus.Open & (t.DeadlineValue(t.Date, t.Deadline) < (DateTime.Today)))
                {
                    urgentTickets++;
                }
            }

            chartOpen.Series["Series1"].Points.AddXY(2,openTickets);
            chartOpen.Series["Series1"].Points.AddXY(2,tickets.Count - openTickets);
            chartOpen.Series[0].Points[0].Color = Color.Orange;
            chartOpen.Series[0].Points[1].Color = Color.LightGray;
            chartOpen.Series["Series1"].IsValueShownAsLabel = false;
            chartOpen.Titles.Add("\n\n\n\n\n\n\n\n\n" + openTickets +" / " + tickets.Count);

            chartOpen.ChartAreas[0].Position.X = 10;
            chartOpen.ChartAreas[0].Position.Y = 100;
            chartOpen.ChartAreas[0].Position.Width = 80;
            chartOpen.ChartAreas[0].Position.Height = 60;
            chartOpen.ChartAreas[0].BackColor = Color.Transparent;

            chartOpen.Series["Series1"]["PieStartAngle"] = "270";

            chartUrgent.Series["Series2"].Points.AddXY(2, urgentTickets);
            chartUrgent.Series["Series2"].Points.AddXY(2, tickets.Count - urgentTickets);
            chartUrgent.Series[0].Points[0].Color = Color.Red;
            chartUrgent.Series[0].Points[1].Color = Color.LightGray;
            chartUrgent.Series["Series2"].IsValueShownAsLabel = false;
            chartUrgent.Titles.Add("\n\n\n\n\n\n\n\n\n" + urgentTickets);

            chartUrgent.ChartAreas[0].Position.X = 10;
            chartUrgent.ChartAreas[0].Position.Y = 100;
            chartUrgent.ChartAreas[0].Position.Width = 80;
            chartUrgent.ChartAreas[0].Position.Height = 60;
            chartUrgent.ChartAreas[0].BackColor = Color.Transparent;

            chartUrgent.Series["Series2"]["PieStartAngle"] = "270";

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

        private void btnShowList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_overview form = new Ticket_overview(currentUser);
            form.ShowDialog();
            this.Close();
        }

        private void chartOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_overview form = new Ticket_overview(currentUser);
            form.ShowDialog();
            this.Close();
        }

        private void chartUrgent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket_overview form = new Ticket_overview(currentUser);
            form.ShowDialog();
            this.Close();
        }
    }
}
