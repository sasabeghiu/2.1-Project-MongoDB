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
    //HERE WILL BE ALL THE METHODS FOR GET, INSERT, UPDATE, DELETE FOR USER
    public class UserService
    {
        private List<User> users;

        public List<User> getAll()
        {
            this.users = MongoDatabase.userCollection.Find(new BsonDocument()).ToList();
            return this.users;
        }

<<<<<<< HEAD
        public User UserLogin(string email, string password)
        {
            User user = MongoDatabase.userCollection.Find(x => x.Email == email & x.Password == password).FirstOrDefault();
            return user;
=======
        public void NewUser (User user)
        {
            MongoDatabase.userCollection.InsertOne(user);
>>>>>>> 5e92e90de8a9506f0f4aec01c0433b58ef9bff4b
        }
    }

    
}
