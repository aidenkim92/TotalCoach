using MongoDB.Bson.Serialization.Attributes;

namespace TotalCoachCodingTestProject.Models
{
    public class Organization
    {
        [BsonId]
        public string Id { get; set; }
        public string OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
    }
}