using MongoDB.Bson.Serialization.Attributes;
using System;

namespace HospitalManagementSystem.Forms
{
    [Serializable]
    public class User
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string userID { get; set; }
        [BsonElement("username"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Username { get; set; }
        [BsonElement("firstName"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string FirstName { get; set; }
        [BsonElement("lastName"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string LastName { get; set; }
        [BsonElement("email"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Email { get; set; }
        [BsonElement("password"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Password { get; set; }
        [BsonElement("role"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Role { get; set; }
    }
}