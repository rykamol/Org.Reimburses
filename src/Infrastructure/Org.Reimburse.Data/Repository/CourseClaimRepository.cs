using Org.Reimburse.Core.Business_Interfaces;
using Org.Reimburse.Core.Models;
using Org.Reimburse.Data._Context;
using System;

namespace Org.Reimburse.Data.Repository
{
    public class ClaimCourseBusiness : IClaimCourseBusiness
    {
        private readonly OrgDbContext _context;

        public ClaimCourseBusiness(OrgDbContext context)
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


    }
}
