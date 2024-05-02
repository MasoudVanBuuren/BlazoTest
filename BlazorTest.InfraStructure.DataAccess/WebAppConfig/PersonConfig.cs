using BlazorTest.Domain.Entities.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.InfraStructure.DataAccess.WebAppConfig
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(100);
            builder.Property(c=>c.Address).IsRequired().HasMaxLength(200);
            builder.Property(c=>c.Email).IsRequired().HasMaxLength(200);
            builder.Property(c=>c.PhoneNumber).IsRequired().HasMaxLength(20);
        }
    }
}
