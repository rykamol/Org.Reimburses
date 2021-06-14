using Org.Reimburse.Core.Business_Interfaces;
using Org.Reimburse.Core.Models;
using System;

namespace Org.Reimburse.Infrastructure.Business
{
    public class MonthlyPaidSalaryBusiness : IMonthlyPaidSalaryBusiness
    {
        private IMonthlyPaidSalaryBusiness _monthlyPaidSalary;

        public MonthlyPaidSalaryBusiness(IMonthlyPaidSalaryBusiness monthlyPaidSalary)
        {
            _monthlyPaidSalary = monthlyPaidSalary;
        }

        public void PaySalary(MonthlyPaidSalary entity)
        {
            try
            {
                _monthlyPaidSalary.PaySalary(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
