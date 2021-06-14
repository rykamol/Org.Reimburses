using Org.Reimburse.Core.Business_Interfaces;
using Org.Reimburse.Core.Models;
using Org.Reimburse.Core.Repository_Interfaces;
using System;

namespace Org.Reimburse.Infrastructure.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeBusiness(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public Employee GetEmployeeByCode(string empCode)
        {
            try
            {
                return _employeeRepository.GetEmployeeByCode(empCode);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}