using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WaterProject2.Models;

//this is its own model pulling its own data
namespace WaterProject2.Components
{
    // load up the data set
    public class TypesViewComponent : ViewComponent
    {
        private IWaterProjectRepository repo { get; set; }

        public TypesViewComponent (IWaterProjectRepository temp)
        {
            repo = temp;
        }

        // pull out data of distinct
        public IViewComponentResult Invoke()
        {
            // based on a type of project
            var types = repo.Projects
                .Select(x => x.ProjectType)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }
    }
}
