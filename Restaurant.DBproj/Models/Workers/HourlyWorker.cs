﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.DBproj.Models.Workers
{
    public class HourlyWorker : Worker
    {
        public int NoOfHours { get; set; }

        [Column(TypeName = "DECIMAL(10,2)")]
        public decimal SalaryPerHour { get; set; }
    }
}
