using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq.Expressions;

namespace Logic
{
    ////HERE WILL BE ALL THE METHODS FOR GET, INSERT, UPDATE, DELETE FOR TICKET
    public class TicketService
    {
        private List<Ticket> tickets;
        //get all results from database
        public List<Ticket> getAll()
        {
            this.tickets = MongoDatabase.ticketCollection.Find(new BsonDocument()).ToList();
            return this.tickets;
        }
        //filter by email
        public List<Ticket> FilterTickets(Expression<Func<Ticket, bool>> filter)
        {
            List<Ticket> tickets = MongoDatabase.ticketCollection.Find(filter).ToList();
            return tickets;
        }
    }
}
