using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLaveManagmentSystem.Repository
{
    public class GetEmployees
    {
        public static List<HourlyEmployee> GetHourlyEmployees()
        {
            List<HourlyEmployee> hourlyList = new List<HourlyEmployee>();
            for(int i=0;i<=10; i++)
            {
                hourlyList.Add(new HourlyEmployee { EmployeeID =i, EmployeeName = "Hourly_Employee"+i,Noofvacations=10,WorkingDays=260 });
            }
  
            return hourlyList;
        }

        public static List<SalariedEmployee> GetSalariedEmployees()
        {
            List<SalariedEmployee> salaryEmpList = new List<SalariedEmployee>();
            for (int i = 0; i <= 10; i++)
            {
                salaryEmpList.Add(new SalariedEmployee { EmployeeID = i, EmployeeName = "Salaried_Employee" + i, Noofvacations = 15, WorkingDays = 260 });
            }
            return salaryEmpList;
        }

        public static List<ManagerEmployee> GetmanagerEmployees()
        {
            List<ManagerEmployee> managerList = new List<ManagerEmployee>();
            for (int i = 0; i <= 10; i++)
            {
                managerList.Add(new ManagerEmployee { EmployeeID = i, EmployeeName = "Manager_Employee" + i, Noofvacations = 30, WorkingDays = 260 });
            }
            return managerList;
        }
    }
}
