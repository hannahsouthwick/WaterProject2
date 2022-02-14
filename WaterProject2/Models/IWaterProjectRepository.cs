using System;
using System.Linq;

namespace WaterProject2.Models
{
    // template for a class
    public interface IWaterProjectRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
