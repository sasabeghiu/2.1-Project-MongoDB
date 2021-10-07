using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DAL
{
    //THIS IS EVERYTHING FOR DAL LAYER, DON'T ADD ANY CLASSES OR CHANGES FOR NOW
    public static class MongoDatabase
    {
        public static MongoClient client;
        public static IMongoDatabase database;

        static MongoDatabase()
        {
            client = new MongoClient("mongodb+srv://PabloG:1234@firstproject.z3gmq.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            database = client.GetDatabase("NoDeskApplication");
        }
    }
}
