using BlazorTest.Domain.Entities.Location;
using BlazorTest.Domain.Entities.People;
using BlazorTest.InfraStructure.DataAccess.WebAppConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.InfraStructure.DataAccess.Common
{
    public class BlazorTestDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        public BlazorTestDbContext(DbContextOptions<BlazorTestDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new StateConfig());
            modelBuilder.ApplyConfiguration(new CityConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
