
namespace RaceDay.API.Models
{
    public class Entry
    {
        public int EntryID { get; set; }

        public int ParticipantID { get; set; }

        public int CategoryID { get; set; }

        public DateTime EntryDate { get; set; }

        public string Status { get; set; } = "Registered";
    }
}
