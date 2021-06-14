using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Org.Reimburse.Core.Models
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }

        public string Name { get; set; }

        public string EmpCode { get; set; }

        public string Email { get; set; }

        public double Salary { get; set; }

        public IEnumerable<ClaimCourse> ClaimCourses { get; set; }

        public Employee()
        {
            ClaimCourses = new List<ClaimCourse>();
        }
    }
}
