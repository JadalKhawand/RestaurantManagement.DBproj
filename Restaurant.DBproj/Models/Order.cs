using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RestaurantManagement.DBproj.Models.Workers;

namespace RestaurantManagement.DBproj.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("Worker")]
        public int SSN { get; set; }
        public Worker Worker { get; set; }
        [ForeignKey("DiningTable")]
        public byte TableNumber { get; set; }
        public DiningTable Table { get; set; }
        public DateTime OrderTime { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Column(TypeName = "VARCHAR(MAX)")]
        public string Comment { get; set; }
    }
}
