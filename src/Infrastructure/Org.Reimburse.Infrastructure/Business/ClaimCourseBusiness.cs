using Org.Reimburse.Core.Business_Interfaces;
using Org.Reimburse.Core.Models;
using Org.Reimburse.Core.Repository_Interfaces;
using System;
using System.Collections.Generic;

namespace Org.Reimburse.Infrastructure.Business
{
    public class ClaimCourseBusiness : IClaimCourseBusiness
    {
        private readonly IClaimCourseRepository _claimCourseRepository;

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

        public ICollection<ClaimCourse> ClaimCourses()
        {
            try
            {
                return _claimCourseRepository.ClaimCourses();
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
                _claimCourseRepository.ApproveClaimCourse(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
