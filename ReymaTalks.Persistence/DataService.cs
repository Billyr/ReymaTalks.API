using ReymaTalks.Domain;

namespace ReymaTalks.Persistence
{
    public static class DataService
    {
        private static List<Session> _sessions;
        public static IEnumerable<Session> Sessions
        {
            get
            {
                if (_sessions is null)
                {
                    _sessions = new List<Session>
                    {
                        new Session
                        {
                            Id = Guid.NewGuid(),
                            Code = "ASPNETCORE",
                            Title = "ASP.Net Core 7",
                            Description = "Only training",
                            Attendees = new List<Attendee>
                            {
                                new Attendee
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "Marimar",
                                    Years = 4
                                }
                            }
                        }
                        
                    };
                }
                return _sessions;
            }
        }
    }
}
