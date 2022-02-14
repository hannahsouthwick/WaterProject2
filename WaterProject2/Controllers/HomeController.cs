using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WaterProject2.Models;

namespace WaterProject2.Controllers
{
    public class HomeController : Controller
    {
        //private WaterProjectContext context { get; set; }

        //public HomeController (WaterProjectContext temp)
        //{
        //    context = temp;
        //}

        private IWaterProjectRepository repo;

        public HomeController (IWaterProjectRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            var blah = repo.Projects.ToList();
            return View(blah);
        }

        // public IActionResult Index() => View();
    }
}
