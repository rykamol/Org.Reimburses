using Org.Reimburse.Core.Models;

namespace Org.Reimburse.Core.Business_Interfaces
{
    public interface IMonthlyPaidSalaryBusiness
    {
        void PaySalary(MonthlyPaidSalary entity);
    }
}
