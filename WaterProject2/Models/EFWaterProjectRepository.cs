using System;
using System.Linq;

namespace WaterProject2.Models
{
    //implements and instance of IWaterProjectRepository

    public class EFWaterProjectRepository : IWaterProjectRepository
    {
        private WaterProjectContext context { get; set; }

        public EFWaterProjectRepository (WaterProjectContext temp)
        {
            context = temp;
        }

        public IQueryable<Project> Projects => context.Projects;
    }
}
