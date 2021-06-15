using Org.Reimburse.Core.Business_Interfaces;
using Org.Reimburse.Core.Models;
using Org.Reimburse.Data._Context;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Org.Reimburse.Core.Repository_Interfaces;

namespace Org.Reimburse.Data.Repository
{
    public class ClaimCourseRepository : IClaimCourseRepository
    {
        private readonly OrgDbContext _context;

        public ClaimCourseRepository(OrgDbContext context)
        {
            _context = context;
        }

        public void ClaimCourse(ClaimCourse entity)
        {
            try
            {
                _context.ClaimCourses.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ICollection<ClaimCourse> ClaimCourses()
        {
            try
            {
                return _context.ClaimCourses.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ApproveClaimCourse(ClaimCourse entity)
        {
            try
            {
                var claim = _context.ClaimCourses.Find(entity.EmployeeId);
                if (claim == null)
                {
                    throw new Exception("Invaid Claim,Approve Failed !!");
                }

                _context.ClaimCourses.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
