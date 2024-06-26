using MongoDB.Bson.Serialization.Attributes;

namespace TotalCoachCodingTestProject.Models
{
    public class Invitation
    {
        [BsonId]
        public string Id { get; set; }
        public string InvitationId { get; set; }
        public string OrganizationId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
    }
}