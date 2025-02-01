using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.DBproj.Models.Workers
{
    public class Delivery : Worker
    {
        [Column(TypeName = "VARCHAR(50)")]
        public string VehicleType { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string VehicleLicensePlateNumber { get; set; }
    }
}
