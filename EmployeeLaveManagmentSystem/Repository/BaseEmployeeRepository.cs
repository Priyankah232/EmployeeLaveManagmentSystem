using EmployeeLaveManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLaveManagmentSystem.Repository
{
    public abstract class BaseEmployeeRepository
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public float Noofvacations { get; set; }
        public float WorkingDays { get; set; }
        public abstract float Work(int noofWorkingDays);
        public abstract float TakeVacation(int noofVacations);

    }
}
