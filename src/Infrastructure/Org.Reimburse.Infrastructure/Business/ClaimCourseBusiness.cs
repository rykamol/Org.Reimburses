using Org.Reimburse.Core.Business_Interfaces;
using Org.Reimburse.Core.Models;
using Org.Reimburse.Core.Repository_Interfaces;
using System;

namespace Org.Reimburse.Infrastructure.Business
{
    public class ClaimCourseBusiness : IClaimCourseBusiness
    {
        private IClaimCourseRepository _claimCourseRepository;

        public ClaimCourseBusiness(IClaimCourseRepository claimCourseRepository)
        {
            _claimCourseRepository = claimCourseRepository;
        }
        public void ClaimCourse(ClaimCourse entity)
        {
            try
            {
                _claimCourseRepository.ClaimCourse(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
