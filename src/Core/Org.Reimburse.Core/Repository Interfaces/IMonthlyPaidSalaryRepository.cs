﻿using Org.Reimburse.Core.Models;

namespace Org.Reimburse.Core.Repository_Interfaces
{
    public interface IMonthlyPaidSalaryBusiness
    {
        void PaySalary(MonthlyPaidSalary entity);
    }
}
