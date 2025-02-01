using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.DBproj.Models.Workers
{
    public class Manager : Worker
    {
        [Column(TypeName = "DECIMAL(10,2)")]
        public decimal Salary { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string MType { get; set; }
    }
}
