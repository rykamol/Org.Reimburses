using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Org.Reimburse.Api.Dtos;
using Org.Reimburse.Core.Business_Interfaces;
using Org.Reimburse.Core.Models;

namespace Org.Reimburse.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryPayController : ControllerBase
    {
        private IMonthlyPaidSalaryBusiness _monthlyPaidSalary;
        private IEmployeeBusiness _employeeBusiness;

        public SalaryPayController(IMonthlyPaidSalaryBusiness monthlyPaidSalary, 
                                    IEmployeeBusiness employeeBusiness)
        {
            _monthlyPaidSalary = monthlyPaidSalary;
            _employeeBusiness = employeeBusiness;
        }


        [HttpPost]
        public IActionResult PaySlary([FromBody] MonthlyPaidSalaryDto model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(model);
                }

                var employee = _employeeBusiness.GetEmployeeByCode(model.EmployeeCode);
                if (employee == null)
                {
                    return BadRequest("Invalid Employee");
                }

                var payee = new MonthlyPaidSalary()
                {
                    TotalPaidAmount = model.TotalPaidAmount,
                    EmployeeId = employee.EmployeeId,
                    Remark = model.Remark,
                    PaidDate = DateTime.Now
                };

                _monthlyPaidSalary.PaySalary(payee);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
