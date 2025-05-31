using System;
using System.ComponentModel.DataAnnotations;

namespace MiniERP.Models.HR
{
    public class Payroll
    {
        [Key]
        public int PayrollId { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [DataType(DataType.Date)]
        public DateTime PayDayStart { get; set; }
        [DataType(DataType.Date)]
        public DateTime PayDayEnd { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public double GrossSalary { get; set; }
        [Range(0, double.MaxValue)]
        public double TaxDeductions { get; set; }
        [Range(0, double.MaxValue)]
        public double OtherDeductions { get; set; }
        [Range(0, double.MaxValue)]
        public double Bonuses { get; set; }
        public decimal NetSalary => (decimal)(GrossSalary - TaxDeductions - OtherDeductions + Bonuses);
        public DateTime PaymentDate { get; set; }
        public string? PaymentMethod { get; set; }
        public string? Notes { get; set; }
    }
}
