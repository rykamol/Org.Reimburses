using Microsoft.EntityFrameworkCore;
using Org.Reimburse.Core.Models;

namespace Org.Reimburse.Data._Context
{
    public class OrgDbContext : DbContext
    {
        public OrgDbContext(DbContextOptions<OrgDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<ClaimCourse> ClaimCourses { get; set; }
        public DbSet<MonthlyPaidSalary> MonthlyPaidSalaries { get; set; }

    }
}
