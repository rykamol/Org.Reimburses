using Org.Reimburse.Core.Models;
using Org.Reimburse.Core.Repository_Interfaces;
using Org.Reimburse.Data._Context;
using System;
using Org.Reimburse.Core.Business_Interfaces;

namespace Org.Reimburse.Data.Repository
{
    public class MonthlyPaidSalaryRepository : IMonthlyPaidSalaryRepository
    {
        private readonly OrgDbContext _context;

        public MonthlyPaidSalaryRepository(OrgDbContext context)
        {
            _context = context;
        }

        public void PaySalary(MonthlyPaidSalary entity)
        {
            try
            {
                _context.MonthlyPaidSalaries.Add(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
