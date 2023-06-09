using EduSys.Core.Models;
using EduSys.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<Product>> GetProductWithCategory()
        {
            //Eager Loading
            return await _context.Products.Include(x => x.Category).ToListAsync();


            //1. Eager Loading
            //2. Lazy Loading
        }
    }
}
