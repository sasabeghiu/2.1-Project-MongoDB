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
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.password = password;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId id { get; set; }

        [BsonElement("first_name")]
        public string first_name { get; set; }

        [BsonElement("last_name")]
        public string last_name { get; set; }

        [BsonElement("email")]
        public string email { get; set; }

        [BsonElement("password")]
        public string password { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public UserType type { get; set; }
    }
}
