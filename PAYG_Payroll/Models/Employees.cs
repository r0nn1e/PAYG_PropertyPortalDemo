using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace PAYG_Payroll.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string KnownAs { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string HomeTel { get; set; }
        public string Mobile { get; set; }
        public string NiNo { get; set; }
        public int TaxCodeNumber { get; set; }
        public string TaxCodeLetter { get; set; }
        public bool TaxCodePrefix { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public double payRate { get; set; }
        public double HolidayRate { get; set; }
        public double MileRate { get; set; }
        public bool StaffActive { get; set; }
        public bool IncludeInPayroll { get; set; }
        public double GrossPayToDate { get; set; }
        public double TaxablePayToDate { get; set; }
        public double TaxPaidToDate { get; set; }
        public double NiPaidToDate { get; set; }
        public bool WeekOneMonthOne { get; set; }
        public double HolidayEntitlementCurrentYear { get; set; }
        public double HolidayTakenCurrentYear { get; set; }
    }
}


