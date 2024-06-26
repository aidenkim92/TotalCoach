using MongoDB.Bson.Serialization.Attributes;

namespace TotalCoachCodingTestProject.Models
{
    public class User
    {
        [BsonId]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
    }
}