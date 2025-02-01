using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.DBproj.Models
{
    public class DiningTable
    {
        [Key]
        public byte TableNumber { get; set; }
        public byte Capacity { get; set; }
        [ForeignKey("Restaurant")]
        [Column(TypeName = "VARCHAR(25)")]
        public string RName { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
