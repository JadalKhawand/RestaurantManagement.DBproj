using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.DBproj.Models
{
    public class Restaurant
    {
       
            [Key]
            [Column(TypeName = "VARCHAR(25)")]
            public string RName { get; set; }
            [Column(TypeName = "VARCHAR(255)")]
            public string Email { get; set; }
            [Column(TypeName = "VARCHAR(50)")]
            public string PhoneNumber { get; set; }
            [Column(TypeName = "VARCHAR(255)")]
            public string Address { get; set; }
            public int MichelinStar { get; set; }
            public TimeSpan OpeningHour { get; set; }
            public TimeSpan EndHour { get; set; }
            public List<Menu> Menus { get; set; }
            public List<DiningTable> Tables { get; set; }
        
    }
}
