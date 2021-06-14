using Org.Reimburse.Core.Models;

namespace Org.Reimburse.Core.Repository_Interfaces
{
    public interface IMonthlyPaidSalaryRepository
    {
        void PaySalary(MonthlyPaidSalary entity);
    }
}
