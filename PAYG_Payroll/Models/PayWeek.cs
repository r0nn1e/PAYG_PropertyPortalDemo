namespace PAYG_Payroll.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PayWeek
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
