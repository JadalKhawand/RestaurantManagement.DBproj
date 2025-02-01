using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.DBproj.Models.Workers
{
    public class Cashier : Worker
    {
        [Column(TypeName = "VARCHAR(50)")]
        public string PaymentHandlingMethods { get; set; }
    }
}
