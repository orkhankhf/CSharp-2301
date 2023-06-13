using EduSys.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Core.Repositories
{
    public interface ICategoryRepository :IGenericRepository<Category>
    {
        Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
