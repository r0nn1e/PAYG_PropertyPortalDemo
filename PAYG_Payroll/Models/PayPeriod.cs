using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PAYG_Payroll.Models
{
    public class PayPeriod
    {
        [Key]
        public int pp_id { get; set; }
        public string pp_name { get; set; }
        public int pp_weeks { get; set; }
    }
}