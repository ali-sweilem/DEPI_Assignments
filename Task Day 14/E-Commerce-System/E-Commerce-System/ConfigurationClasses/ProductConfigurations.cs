using E_Commerce_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.ConfigurationClasses
{
    internal class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //prop Id
            builder.HasKey(d => d.Id);
            builder.Property(D => D.Id)
                .UseIdentityColumn(1, 1);

            //prop Name
            builder.Property(D => D.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("Name");

            //prop Price
            builder.Property(D => D.Price)
                .IsRequired(true)
                .HasColumnType("decimal")
                .HasColumnName("Price");
                
        }
    }
}
