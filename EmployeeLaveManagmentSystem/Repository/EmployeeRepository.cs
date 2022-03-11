using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLaveManagmentSystem.Repository
{
    public class HourlyEmployee : BaseEmployeeRepository
    {
        float NoofVacations = 10;
        float WorkDays = 10;
        public override float TakeVacation(int noofVacations)
        {
            this.NoofVacations = noofVacations - noofVacations;
            this.WorkDays = WorkDays - noofVacations;
            return this.NoofVacations;
        }

        public override float Work(int noofWorkingDays)
        {
            this.WorkDays = noofWorkingDays;
            return this.WorkDays;
        }

    }

    public class SalariedEmployee : BaseEmployeeRepository
    {
 
        float NoofVacations = 15;
        float WorkDays = 260;
        public override float TakeVacation(int noofVacations)
        {
            this.NoofVacations = noofVacations - noofVacations;
            this.WorkDays = WorkDays - noofVacations;
            return this.NoofVacations;
        }

        public override float Work(int noofWorkingDays)
        {
            this.WorkDays = noofWorkingDays;
            return this.WorkDays;
        }
    }

    public class ManagerEmployee : BaseEmployeeRepository
    {
     
        float NoofVacations = 30;
        float WorkDays = 260;
        public override float TakeVacation(int noofVacations)
        {
            this.NoofVacations = noofVacations - noofVacations;
            this.WorkDays = WorkDays - noofVacations;
            return this.NoofVacations;
        }

        public override float Work(int noofWorkingDays)
        {
            this.WorkDays = noofWorkingDays;
            return this.WorkDays;
        }
    }
}
