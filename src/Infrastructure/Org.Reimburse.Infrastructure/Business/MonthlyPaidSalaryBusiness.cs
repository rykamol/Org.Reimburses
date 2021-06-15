using Org.Reimburse.Core.Business_Interfaces;
using Org.Reimburse.Core.Models;
using System;
using Org.Reimburse.Core.Repository_Interfaces;

namespace Org.Reimburse.Infrastructure.Business
{
    public class MonthlyPaidSalaryBusiness : IMonthlyPaidSalaryBusiness
    {
        private IMonthlyPaidSalaryRepository _iMonthlyPaidSalaryRepository;

        public MonthlyPaidSalaryBusiness(IMonthlyPaidSalaryRepository iMonthlyPaidSalaryRepository)
        {
            _iMonthlyPaidSalaryRepository = iMonthlyPaidSalaryRepository;
        }

        public void PaySalary(MonthlyPaidSalary entity)
        {
            try
            {
                _iMonthlyPaidSalaryRepository.PaySalary(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
