
namespace RaceDay.API.Models
{
    public class Event
    {
        public int EventID { get; set; }

        public int OrganizerID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string EventType { get; set; } = "Running";

        public DateTime EventDate { get; set; }

        public string Location { get; set; } = string.Empty;

        public string? RouteInformation { get; set; }

        public string Status { get; set; } = "Draft";

        public DateTime CreatedAt { get; set; }
    }
}
