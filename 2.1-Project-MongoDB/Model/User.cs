using System;
using System.Linq;
using System.Web.Helpers;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Model
{
    //HERE WILL BE DEFINED ALL CTORS AND FIELDS (GETTERS AND SETTERS) NOT DONE YET
    [BsonIgnoreExtraElements]
    public class User
    {
        public User()
        {

        }

        public User(string firstName, string lastName, string email, string password, UserType userType, UserLocation location, string phone, int tickets)
        {
            this.First_name = firstName;
            this.Last_name = lastName;
            this.Email = email;
            this.Password = password;
            this.Type = userType;
            this.Location = location;
            this.Phone = phone;
            this.Tickets = tickets;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("first_name")]
        public string First_name { get; set; }

        [BsonElement("last_name")]
        public string Last_name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonElement("user_type")]
        public UserType Type { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("tickets")]
        public int Tickets { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonElement("location")]
        public UserLocation Location { get; set; }
    }
}
