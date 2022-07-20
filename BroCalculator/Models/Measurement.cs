using SQLite;

namespace BroCalculator.Models
{
    [Table("Measurements")]
    public class Measurement : BaseEntity
    {
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
