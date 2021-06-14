using Org.Reimburse.Core.Models;
using Org.Reimburse.Core.Repository_Interfaces;
using Org.Reimburse.Data._Context;
using System;

namespace Org.Reimburse.Data.Repository
{
    public class MonthlyPaidSalaryBusiness : IMonthlyPaidSalaryRepository
    {
        private readonly OrgDbContext _context;

        public MonthlyPaidSalaryBusiness(OrgDbContext context)
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
