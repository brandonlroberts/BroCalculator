using SQLite;

namespace BroCalculator.Models
{
    [Table("Foods")]
    public class Food : BaseEntity
    {
        [Unique]

        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Brand { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
        public double Measurement { get; set; }
        public double Quantity { get; set; }
        public int Calories { get; set; }
        public int Protein { get; set; }

        public int MeasurementId { get; set; }
    }
}
