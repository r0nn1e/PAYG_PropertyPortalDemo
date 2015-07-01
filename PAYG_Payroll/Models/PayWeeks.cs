using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PAYG_Payroll.Models
{
    public class PayWeeks
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime PayDate { get; set; }
        public string Year { get; set; }
        public int WeekNumber { get; set; }
        public int RotaWeek { get; set; }
        public int IsProcessed { get; set; }
        public int Branch { get; set; }
    }

}