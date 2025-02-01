using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.DBproj.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [ForeignKey("DiningTable")]
        public byte TableNumber { get; set; }

        public DiningTable Table { get; set; }

        public DateTime ReservationTime { get; set; }

        [ForeignKey("Restaurant")]
        [Column(TypeName = "VARCHAR(25)")]
        public string RName { get; set; }

        public Restaurant Restaurant { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
