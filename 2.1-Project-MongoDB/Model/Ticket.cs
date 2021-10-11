using System;
using System.Web.Helpers;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Model
{
    //HERE WILL BE DEFINED ALL CTORS AND FIELDS (GETTERS AND SETTERS)
    [BsonIgnoreExtraElements]
    public class Ticket
    {
        public Ticket()
        {

        }

        public Ticket(string subject, string user, DateTime date, TicketPriority priority, DateTime deadline)
        {
            Subject = subject;
            User = user;
            Date = date;
            Priority = priority;
            Deadline = deadline;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId id { get; set; }

        [BsonElement("subject")]
        public string Subject { get; set; }

        [BsonElement("user")]
        public string User { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("date")]
        public DateTime Date { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public TicketPriority Priority { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("deadline")]
        public DateTime Deadline { get; set; }
    }
}
