using System.Collections.Generic;
using Org.Reimburse.Core.Models;

namespace Org.Reimburse.Core.Business_Interfaces
{
    public interface IClaimCourseBusiness
    {
        void ClaimCourse(ClaimCourse entity);
        ICollection<ClaimCourse> ClaimCourses();

        void ApproveClaimCourse(ClaimCourse entity);

    }
}
