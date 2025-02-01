using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.DBproj.Models
{
    public class Menu
    {
        [Key]
        [Column(TypeName = "VARCHAR(50)")]
        public string MName { get; set; }
        [Column(TypeName = "DECIMAL(10,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string Size { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Category { get; set; }
        [Column(TypeName = "VARCHAR(MAX)")]
        public string Ingredients { get; set; }
        [ForeignKey("Restaurant")]
        [Column(TypeName = "VARCHAR(25)")]
        public string RName { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
