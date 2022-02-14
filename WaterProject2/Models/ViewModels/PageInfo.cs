using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WaterProject2.Models;

namespace WaterProject2.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumProjects { get; set; }
        public int ProjectsPerPage { get; set; }
        public int CurrentPage { get; set; }
        // Figures out how many pages we need
        public int TotalPages => (int) Math.Ceiling((double) TotalNumProjects / ProjectsPerPage);
    }
}