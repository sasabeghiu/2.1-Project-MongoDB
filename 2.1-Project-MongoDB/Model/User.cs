using System;
using System.Web.Helpers;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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

        public User(string firstName, string lastName, string email, string password)
        {
            this.First_name = firstName;
            this.Last_name = lastName;
            this.Email = email;
            this.Password = password;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId id { get; set; }
        /*[BsonElement("id")]
        public int id { get; set; }*/

        [BsonElement("first_name")]
        public string First_name { get; set; }

        [BsonElement("last_name")]
        public string Last_name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public UserType Type { get; set; }
    }
}
