using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.DBproj.Models.Workers
{
    public class Chef : Worker
    {
        [Column(TypeName = "VARCHAR(100)")]
        public string CuisineSpecialization { get; set; }
    }
}
