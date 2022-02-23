using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WaterProject2.Models;
using WaterProject2.Models.ViewModels;

namespace WaterProject2.Controllers
{
    public class HomeController : Controller
    {
        private IWaterProjectRepository repo;

        public HomeController (IWaterProjectRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(string projectType, int pageNum = 1)
        {
            int pageSize = 5;

            var x = new ProjectsViewModel
            {
                Projects = repo.Projects
                // searched with what ever link was passed in or if null
                .Where(p => p.ProjectType == projectType || projectType == null)
                .OrderBy(p => p.ProjectName)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    // making a decision for pagination
                    TotalNumProjects = (projectType == null
                        ? repo.Projects.Count()
                        : repo.Projects.Where(x => x.ProjectType == projectType).Count()),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }
    }
}
