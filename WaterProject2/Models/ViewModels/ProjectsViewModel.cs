using System;
using System.Linq;

namespace WaterProject2.Models.ViewModels
{
    public class ProjectsViewModel
    {
        public IQueryable<Project> Projects { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
