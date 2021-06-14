using Org.Reimburse.Core.Models;

namespace Org.Reimburse.Core.Repository_Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeByCode(string empCode);
    }
}
