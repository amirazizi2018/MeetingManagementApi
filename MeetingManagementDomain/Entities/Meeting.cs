namespace MeetingManagementDomain.Entities
{
    public class Meeting: BaseEntity
    {
        public required string Title { get; set; }
        
        public required string Description { get; set; }
        
        public DateTime MeetingDate { get; set; }

        public ICollection<Resolution> Resolutions { get; set; } = new List<Resolution>();

    }
}
