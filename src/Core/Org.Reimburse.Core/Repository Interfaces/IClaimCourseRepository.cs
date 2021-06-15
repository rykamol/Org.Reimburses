using System.Collections.Generic;
using Org.Reimburse.Core.Models;

namespace Org.Reimburse.Core.Repository_Interfaces
{
    public interface IClaimCourseRepository
    {
        void ClaimCourse(ClaimCourse entity);
        ICollection<ClaimCourse> ClaimCourses();

        void ApproveClaimCourse(ClaimCourse entity);
    }
}
