using BroCalculator.Models;
using SQLite;

namespace BroCalculator.Services
{
    public class FoodService
    {
        string _dbPath;

        public string StatusMessage { get; set; }
        private SQLiteConnection conn;

        private void Init()
        {
            //if (conn != null)
            //    return;

            //conn = new SQLiteConnection(_dbPath);
            //conn.CreateTable<Food>();
            //conn.CreateTable<Measurement>();

            // ******* TEST DATA FOR BUILDING THE APP ******* //
            conn.Execute("DELETE FROM Food ? DELETE FROM Measurement");

            var foods = GetAllFoods();
            var measurements = GetAllMeasurements();

            conn.InsertAll(measurements);
        }

        public List<Food> GetAllFoods()
        {
            try
            {
                return new List<Food>
                {
                    new Food
                    {
                        Id = 1,
                        Brand = "Tyson",
                        Name = "Grilled Chicken Breast",
                        Calories = 200,
                        Description = "Plain grilled chicken breast.",
                        Measurement = 250,
                        MeasurementId = 2,
                        Protein = 50
                    },
                    new Food
                    {
                        Id = 2,
                        Brand= "Members Mark",
                        Name = "Greek Yogurt (Nonfat)",
                        Calories = 100,
                        Description = "Plain nonfat greek yogurt.",
                        Measurement = 1,
                        MeasurementId= 3,
                        Protein = 18
                    },
                    new Food
                    {
                        Id = 2,
                        Brand= "Jack Links",
                        Name = "Original Beef Jerky",
                        Calories = 100,
                        Description = "Single Packs.",
                        Measurement = 1,
                        MeasurementId= 1,
                        Protein = 10
                    }

                };
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Food>();
        }

        public List<Measurement> GetAllMeasurements()
        {
            try
            {
                return new List<Measurement>
                {
                    new Measurement
                    {
                        Id = 1,
                        Name = "item(s)"
                    },
                    new Measurement
                    {
                        Id = 2,
                        Name = "gram(s)"
                    },
                    new Measurement
                    {
                        Id = 3,
                        Name = "cup(s)"
                    }

                };
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Measurement>();
        }
    }
}
