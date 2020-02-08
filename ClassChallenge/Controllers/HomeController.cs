using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClassChallenge.Models;
using Microsoft.Extensions.Configuration;
using InputData;

namespace ClassChallenge.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        protected readonly IConfiguration configuration;
        public IData data;
        public HomeController(IConfiguration configuration, IData data) {
            this.configuration = configuration;
            this.data = data;
        }


        public IActionResult Index()
        {
            return View(new Output()
            {
                ListOfColleges = data.GetAllColleges(),
                ListOfDepartments = data.GetAllDepartments(),
                ListOfUnits = data.GetAllUnits(),
                OverallStats = new Models.Stats()
                {
                    Average = data.GetStatistics().Average,
                    Min = data.GetStatistics().Min,
                    Max = data.GetStatistics().Max,
                    Median = data.GetStatistics().Median
                },
                CollegesStats = new Models.Stats()
                {
                    Average = data.GetStatisticsByCollege("Admin / Support").Average,
                    Min = data.GetStatisticsByCollege("Admin / Support").Min,
                    Max = data.GetStatisticsByCollege("Admin / Support").Max,
                    Median = data.GetStatisticsByCollege("Admin / Support").Median
                },
                DepartmentsStats = new Models.Stats()
                {
                    Average = data.GetStatistics().Average,
                    Min = data.GetStatistics().Min,
                    Max = data.GetStatistics().Max,
                    Median = data.GetStatistics().Median
                },
                UnitsStats = new Models.Stats()
                {
                    Average = data.GetStatistics().Average,
                    Min = data.GetStatistics().Min,
                    Max = data.GetStatistics().Max,
                    Median = data.GetStatistics().Median
                }
            });
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
    }
}
