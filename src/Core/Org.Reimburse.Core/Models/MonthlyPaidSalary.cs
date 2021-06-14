using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Reimburse.Core.Models
{
    public class MonthlyPaidSalary
    {
        public Guid MonthlyPaidSalaryId { get; set; }

        public double TotalPaidAmount { get; set; }

        public DateTime PaidDate { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public string Remark { get; set; }
    }
}
