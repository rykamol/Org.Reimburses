using System;

namespace Org.Reimburse.Api.Dtos
{
    public class MonthlyPaidSalaryDto
    {
        public double TotalPaidAmount { get; set; }

        public DateTime PaidDate { get; set; }

        public string EmployeeCode { get; set; }

        public string Remark { get; set; }
    }
}