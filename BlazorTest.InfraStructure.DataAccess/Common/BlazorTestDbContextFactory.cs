using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.InfraStructure.DataAccess.Common
{
    public class BlazorTestDbContextFactory : IDesignTimeDbContextFactory<BlazorTestDbContext>
    {
        public BlazorTestDbContext CreateDbContext(string[] args)
        {
            //var builder = new DbContextOptionsBuilder<BlazorTestDbContext>();
            //builder.UseSqlServer("Data Source=.;Initial Catalog=BlazorTestDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //var result = new BlazorTestDbContext(builder.Options);
            //var pendingMigrations = result.Database.GetPendingMigrations();
            //if (pendingMigrations.Any())
            //    result.Database.Migrate();

            //return result;

            var builder = new DbContextOptionsBuilder<BlazorTestDbContext>();
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BlazorTestDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new BlazorTestDbContext(builder.Options);
        }
    }
}
