using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Restaurant.DBproj.Models.Workers;

namespace Restaurant.DBproj.Models
{
    public class Payment
    {
        [Key]
        public int PaymentNumber { get; set; }

        [Column(TypeName = "DECIMAL(10,2)")]
        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        [ForeignKey("Worker")]
        public int CashierId { get; set; }

        public Worker Cashier { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
