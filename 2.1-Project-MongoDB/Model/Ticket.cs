using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Model
{
    [BsonIgnoreExtraElements]
    public class Ticket
    {
        public Ticket()
        {

        }

        public Ticket(string subject, string user, DateTime date, TicketPriority priority, TicketDeadline deadline, string desciption)
        {
            Subject = subject;
            User = user;
            Date = date;
            Priority = priority;
            Deadline = deadline;
            Description = desciption;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId id { get; set; }

        [BsonElement("subject")]
        public string Subject { get; set; }

        [BsonElement("userId")]
        public string User { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("date")]
        public DateTime Date { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonElement("priority")]
        public TicketPriority Priority { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonElement("deadline")]
        public TicketDeadline Deadline { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [BsonElement("status")]
        public TicketStatus Status { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        /*[JsonConverter(typeof(StringEnumConverter))]
        [BsonElement("type")]
        public TicketType Type { get; set; }*/
    }
}
