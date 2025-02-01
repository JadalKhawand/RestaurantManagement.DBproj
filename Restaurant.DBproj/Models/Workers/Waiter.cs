using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.DBproj.Models.Workers
{
    public class Waiter : Worker
    {
        [Column(TypeName = "VARCHAR(MAX)")]
        public string Specialization { get; set; }
    }
}
