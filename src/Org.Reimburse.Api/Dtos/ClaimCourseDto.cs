using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Org.Reimburse.Core.Models;

namespace Org.Reimburse.Api.Dtos
{
    public class ClaimCourseDto
    {
        [Key]
        public Guid CourseClaimId { get; set; }

        public string CourseTitle { get; set; }

        public double Price { get; set; }

        public string EmployeeCode { get; set; }

        public string PurchaseFrom { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime ClaimDate { get; set; }

        public bool IsApproved { get; set; } = false;
    }
}
