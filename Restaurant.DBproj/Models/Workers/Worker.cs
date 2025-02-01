using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.DBproj.Models.Workers
{
    public class Worker
    {
        [Key]
        public int SSN { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string Gender { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "VARCHAR(225)")]
        public string Email { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string FirstName { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string MiddleName { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string LastName { get; set; }
        [Column(TypeName = "VARCHAR(MAX)")]
        public string ShiftSchedule { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("WorkerInfo")]
        public int WorkerInfoId { get; set; }
        public WorkerInfo WorkerInfo
        {
            get; set;
        }
    }
}
