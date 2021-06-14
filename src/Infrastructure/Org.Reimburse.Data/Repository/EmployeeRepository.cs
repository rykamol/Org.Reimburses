using System;
using System.Linq;
using Org.Reimburse.Core.Models;
using Org.Reimburse.Core.Repository_Interfaces;
using Org.Reimburse.Data._Context;

namespace Org.Reimburse.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private OrgDbContext _context;

        public EmployeeRepository(OrgDbContext context)
        {
            _context = context;
        }


        public Employee GetEmployeeByCode(string empCode)
        {
            try
            {
                return _context.Employees.FirstOrDefault(x => x.EmpCode == empCode);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
