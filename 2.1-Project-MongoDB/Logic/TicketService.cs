using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using DAL;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq.Expressions;

namespace Logic
{
    public class TicketService
    {
        private List<Ticket> tickets;
        private UserService userService = new UserService();

        //get all results from database
        public List<Ticket> getAll()
        {
            this.tickets = MongoDatabase.ticketCollection.Find(new BsonDocument()).ToList();
            return this.tickets;
        }

        //filter by subject
        public List<Ticket> FilterTickets(Expression<Func<Ticket, bool>> filter)
        {
            List<Ticket> tickets = MongoDatabase.ticketCollection.Find(filter).ToList();
            return tickets;
        }

        //Adding ticket
        public void AddTicket(Ticket ticket)
        {
            MongoDatabase.ticketCollection.InsertOne(ticket);
        }

        public void RemoveTicket(Ticket ticket)
        {
            var filter = Builders<Ticket>.Filter.Eq("_id",ticket.id);
            var deleteResult = MongoDatabase.ticketCollection.DeleteOne(filter);


            //MongoDatabase.ticketCollection.DeleteOne(ticket);
        }
    }
}
