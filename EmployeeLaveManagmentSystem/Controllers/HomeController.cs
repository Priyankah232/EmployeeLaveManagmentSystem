using EmployeeLaveManagmentSystem.Models;
using EmployeeLaveManagmentSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace EmployeeLaveManagmentSystem.Controllers
{
    public class HomeController : Controller
    {
        public List<HourlyEmployee> hourlyEmployees = new List<HourlyEmployee>();
        public List<SalariedEmployee> salariedEmployees = new List<SalariedEmployee>();

        public List<ManagerEmployee> managerEmployees = new List<ManagerEmployee>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Managers()
        {
            managerEmployees = GetEmployees.GetmanagerEmployees();
            return View(managerEmployees);
        }

        public IActionResult HourlyEmployees()
        {
            hourlyEmployees = GetEmployees.GetHourlyEmployees();

            return View(hourlyEmployees);
        }
        public IActionResult SalariedEmployees()
        {
            salariedEmployees = GetEmployees.GetSalariedEmployees();
            return View(salariedEmployees);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult EditHours(int days)
        {

            return View(hourlyEmployees);
        }

    }
}
