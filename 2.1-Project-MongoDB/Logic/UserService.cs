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
    //HERE WILL BE ALL THE METHODS FOR GET, INSERT, UPDATE, DELETE FOR USER
    public class UserService
    {
        private List<User> users;

        public List<User> getAll()
        {
            this.users = MongoDatabase.userCollection.Find(new BsonDocument()).ToList();
            return this.users;
        }

        public User UserLogin(string email, string password)
        {
            User user = MongoDatabase.userCollection.Find(x => x.Email == email & x.Password == password).FirstOrDefault();
            return user;
        }

        public void NewUser(User user)
        {
            MongoDatabase.userCollection.InsertOne(user);
        }

        public List<User> FilterUsers(Expression<Func<User, bool>> filter)
        {
            List<User> users = MongoDatabase.userCollection.Find(filter).ToList();
            return users;
        }
    }
}
