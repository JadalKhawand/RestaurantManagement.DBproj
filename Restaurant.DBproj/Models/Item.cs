using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.DBproj.Models
{
    
        public class Item
        {
            [Key]
            public int ItemId { get; set; }

            [ForeignKey("Order")]
            public int OrderId { get; set; }

            public Order Order { get; set; }

            [Column(TypeName = "VARCHAR(50)")]
            public string MenuItemName { get; set; }

            public int Quantity { get; set; }
        
    }
}
