using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.DBproj.Models
{
    public class Customer
    {
        [Key]
        public int MembershipId { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string FirstName { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string MiddleName { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string LastName { get; set; }
        [Column(TypeName = "VARCHAR(255)")]
        public string Address { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "VARCHAR(255)")]
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
    }
}
