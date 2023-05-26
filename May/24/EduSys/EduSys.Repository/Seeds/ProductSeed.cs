using EduSys.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Computer",
                    Price = 800,
                    Stock = 35,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Name = "T-Shirt",
                    Price = 50,
                    Stock = 400,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Name = "Cat food",
                    Price = 25,
                    Stock = 1000,
                    CreatedDate = DateTime.Now
                }
                );
        }
    }
}
