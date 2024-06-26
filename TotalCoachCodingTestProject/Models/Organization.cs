namespace TotalCoachCodingTestProject.Models
{
    public class Organization
    {
        public string OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; } = false;
    }
}