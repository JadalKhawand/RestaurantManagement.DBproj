using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.DBproj.Models.Workers
{
    public class SalariedWorker : Worker
    {
        [Column(TypeName = "DECIMAL(10,2)")]
        public decimal Salary { get; set; }
    }
}
