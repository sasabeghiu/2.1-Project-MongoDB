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
    public class UserService
    {
        private List<User> users;
        //get all results from database
        public List<User> getAll()
        {
            this.users = MongoDatabase.userCollection.Find(new BsonDocument()).ToList();
            return this.users;
        }
        //filter by email
        public List<User> FilterUsers(Expression<Func<User, bool>> filter)
        {
            List<User> users = MongoDatabase.userCollection.Find(filter).ToList();
            return users;
        }

        public User UserLogin(string email, string password)
        {
            User user = MongoDatabase.userCollection.Find(x => x.Email == email & x.Password == password).FirstOrDefault();
            return user;
        }
        //add new user
        public void AddNewUser(User user)
        {
            MongoDatabase.userCollection.InsertOne(user);
        }

        /*
        public void SendEmail(User user)
        {
            MailMessage message;
            SmtpClient smtp;

            message = new MailMessage();

            message.Subject = "Service Desk Password";

            message.From = new MailAddress(user.Email);

            message.Body = $"Dear {user.First_name} {user.Last_name}, " +
                $"Here is your password: {user.Password}";

            // set smtp details

            smtp = new SmtpClient("smtp.gmail.com");

            smtp.Port = 25;

            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("deepak.sharma009@gmail.com", "********");

            smtp.SendAsync(message, message.Subject);

            smtp.SendCompleted += new SendCompletedEventHandler(NewUser.smtp_SendCompleted);
        }
        */
    }
}
