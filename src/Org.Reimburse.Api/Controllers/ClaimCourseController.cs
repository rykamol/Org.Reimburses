using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Org.Reimburse.Api.Dtos;
using Org.Reimburse.Core.Business_Interfaces;
using Org.Reimburse.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Org.Reimburse.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimCourseController : ControllerBase
    {
        private readonly IClaimCourseBusiness _claimCourseBusiness;
        private readonly IEmployeeBusiness _employeeBusiness;

        public ClaimCourseController(IClaimCourseBusiness claimCourseBusiness, 
                                     IEmployeeBusiness employeeBusiness)
        {
            _claimCourseBusiness = claimCourseBusiness;
            _employeeBusiness = employeeBusiness;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_claimCourseBusiness.ClaimCourses());
        }



        [HttpPost]
        public IActionResult Claim([FromBody] ClaimCourseDto model)
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

                var claimCourse = new ClaimCourse()
                {
                    CourseTitle = model.CourseTitle,
                    Price = model.Price,
                    EmployeeId = employee.EmployeeId,
                    PurchaseFrom= model.PurchaseFrom,
                    PurchaseDate = model.PurchaseDate,
                    ClaimDate = DateTime.Now
                };

                _claimCourseBusiness.ClaimCourse(claimCourse);

                return RedirectToAction("Get");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        
        
        [HttpPut]
        public IActionResult ApproveClaimCourse([FromBody] ClaimCourseDto model)
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

                var claimCourse = new ClaimCourse()
                {
                    CourseClaimId = model.CourseClaimId,
                    CourseTitle = model.CourseTitle,
                    Price = model.Price,
                    EmployeeId = employee.EmployeeId,
                    PurchaseFrom= model.PurchaseFrom,
                    PurchaseDate = model.PurchaseDate,
                    ClaimDate = DateTime.Now,
                    IsApproved = model.IsApproved
                };

                _claimCourseBusiness.ApproveClaimCourse(claimCourse);

                return RedirectToAction("Get");

            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
