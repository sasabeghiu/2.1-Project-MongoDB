using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ArchiveDatabase
    {
        public static MongoClient client;
        public static IMongoDatabase database;
        public static IMongoCollection<Ticket> ticketCollection;

        static ArchiveDatabase()
        {
            client = new MongoClient("mongodb://Admin:Admin@cluster0-shard-00-00.ft0qc.mongodb.net:27017,cluster0-shard-00-01.ft0qc.mongodb.net:27017,cluster0-shard-00-02.ft0qc.mongodb.net:27017/myFirstDatabase?ssl=true&replicaSet=atlas-x2mmeh-shard-0&authSource=admin&retryWrites=true&w=majority");
            database = client.GetDatabase("Archive");
            ticketCollection = database.GetCollection<Ticket>("Tickets");
        }
    }
}
