using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.DBproj.Models.Workers
{
    public class Bartender : Worker
    {
        [Column(TypeName = "VARCHAR(100)")]
        public string CocktailSpecialty { get; set; }
    }
}
