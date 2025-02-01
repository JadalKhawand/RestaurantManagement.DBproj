using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.DBproj.Models.Workers
{
    public class Other
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string WType { get; set; }
    }
}
