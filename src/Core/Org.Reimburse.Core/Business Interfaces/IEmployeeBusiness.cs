using Org.Reimburse.Core.Models;

namespace Org.Reimburse.Core.Business_Interfaces
{
    public interface IEmployeeBusiness
    {
        Employee GetEmployeeByCode(string empCode);
    }
}
