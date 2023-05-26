using EduSys.Core.Models;
using EduSys.Repository.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().HasKey(c => c.Id).HasName("CategoryId");

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductFeatureConfiguration());

            //Nümunə üçün AppDbContext'də configuration yazmaq: (doğru deyil)
            modelBuilder.Entity<ProductFeature>().HasData(
                new ProductFeature
                {
                    Id = 1,
                    Color = "Red",
                    Height = 30,
                    Width = 70,
                    ProductId = 1
                },
                new ProductFeature
                {
                    Id = 2,
                    Color = "Red",
                    Height = 20,
                    Width = 25,
                    ProductId = 3
                }
                );
        }
    }
}
