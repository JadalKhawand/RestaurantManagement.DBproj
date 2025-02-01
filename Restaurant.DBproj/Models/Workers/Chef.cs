using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.DBproj.Models.Workers
{
    public class Chef : Worker
    {
        [Column(TypeName = "VARCHAR(100)")]
        public string CuisineSpecialization { get; set; }
    }
}
