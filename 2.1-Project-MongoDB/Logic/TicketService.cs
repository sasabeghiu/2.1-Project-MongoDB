using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Logic
{
    ////HERE WILL BE ALL THE METHODS FOR GET, INSERT, UPDATE, DELETE FOR TICKET
    public class TicketService
    {
        private List<Ticket> tickets;

        public List<Ticket> getAll()
        {
            this.tickets = MongoDatabase.ticketCollection.Find(new BsonDocument()).ToList();
            return this.tickets;
        }
    }
}
