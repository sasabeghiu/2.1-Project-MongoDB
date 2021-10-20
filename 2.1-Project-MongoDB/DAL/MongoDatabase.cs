using MongoDB.Driver;
using Model;

namespace DAL
{
    public static class MongoDatabase
    {
        public static MongoClient client;
        public static IMongoDatabase database;
        public static IMongoCollection<User> userCollection;
        public static IMongoCollection<Ticket> ticketCollection;

        static MongoDatabase()
        {
            client = new MongoClient("mongodb://SasaB:1234@cluster0-shard-00-00.rexjc.mongodb.net:27017,cluster0-shard-00-01.rexjc.mongodb.net:27017,cluster0-shard-00-02.rexjc.mongodb.net:27017/myFirstDatabase?ssl=true&replicaSet=atlas-6j34y8-shard-0&authSource=admin&retryWrites=true&w=majority");
            database = client.GetDatabase("NoDesktopApplication");
            userCollection = database.GetCollection<User>("User");
            ticketCollection = database.GetCollection<Ticket>("Ticket");
        }
    }
}
