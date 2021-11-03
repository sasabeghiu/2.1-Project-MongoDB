using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    public partial class TransferTicket : Form
    {
        private readonly TicketService ticketService = new TicketService();
        private Ticket selectedTicket = new Ticket();

        public TransferTicket(string user)
        {
            InitializeComponent();
            LoadData(user);
        }

        private void LoadData(string user)
        {
            List<Ticket> tickets = ticketService.getAll();
            foreach (Ticket ticket in tickets)
            {
                comboBox1.Items.Add(ticket.User);
                if (ticket.User == user)
                {
                    selectedTicket = ticket; 
                    transferLbl.Text = $"Transfer from {ticket.User} to ";
                }
            }
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user to transfer the ticket to.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (comboBox1.SelectedItem.ToString() == selectedTicket.User)
            {
                MessageBox.Show("Cannot transfer ticket to the same person!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                ticketService.UpdateUsername(selectedTicket, comboBox1.SelectedItem.ToString());
                MessageBox.Show($"Ticket transferred successfully!");
                comboBox1.Items.Clear();
                this.Close();
            }

            
        }
    }
}
