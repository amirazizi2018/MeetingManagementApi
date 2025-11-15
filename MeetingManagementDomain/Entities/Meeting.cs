namespace MeetingManagementDomain.Entities
{
    public class Meeting
    {
        public Guid Id { get; set; }
        
        public required string Title { get; set; }
        
        public required string Description { get; set; }
        
        public DateTime CreatedAt { get; set; }

        public ICollection<Resolution> Resolutions { get; set; } = new List<Resolution>();


    }
}
