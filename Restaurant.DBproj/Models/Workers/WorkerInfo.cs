using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.DBproj.Models.Workers
{
    public class WorkerInfo
    {
        [Key]
        public int WorkerInfoId { get; set; }  

        [Column(TypeName = "VARCHAR(25)")]
        public string FatherName { get; set; } 

        [Column(TypeName = "VARCHAR(25)")]
        public string MotherName { get; set; }  

        public int ChildrenNumber { get; set; }  

        public bool Spouse { get; set; }  
    }
}
