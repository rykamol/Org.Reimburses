using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Reimburse.Core.Models
{
    public class ClaimCourse
    {
        [Key]
        public Guid CourseClaimId { get; set; }

        public string CourseTitle { get; set; }

        public double Price { get; set; }


        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public string PurchaseFrom { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime ClaimDate { get; set; }

        public bool IsApproved { get; set; } = false;
    }
}
