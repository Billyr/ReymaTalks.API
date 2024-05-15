namespace ReymaTalks.Domain
{
    public class Session
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Attendee> Attendees { get; set; }
    }
}
