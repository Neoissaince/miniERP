using System;
using System.ComponentModel.DataAnnotations;

namespace MiniERP.Models.HR
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? Email { get; set; }
        public string? FullName { get; set; }
        [Phone]
        public string? Phone { get; set; }
        public string? BankAccNumber { get; set; }
        [Required]
        public string? Position { get; set; }
        public string? Department { get; set; }
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; } = true;

        public required ICollection<Payroll> Payrolls { get; set; }
    }
}