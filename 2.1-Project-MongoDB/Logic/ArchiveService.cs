using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ArchiveService
    {
        
        private List<Ticket> tickets;

        public void AddTicket(Ticket ticket)
        {
            ArchiveDatabase.ticketCollection.InsertOne(ticket);
        }

    }
}
