using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WaterProject2.Models
{
    public class WaterProjectContext : DbContext
    {
        public WaterProjectContext()
        {
        }

        public WaterProjectContext(DbContextOptions<WaterProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Project> Projects { get; set; }

        // because we added a new model, we need to tell the migrations that this needs to be added
        public DbSet<Donation> Donations { get; set; }

    }
}
