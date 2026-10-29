
namespace RaceDay.API.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        public int EventID { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal DistanceKm { get; set; }

        public decimal EntryFee { get; set; }

        public int? Capacity { get; set; }
    }
}
