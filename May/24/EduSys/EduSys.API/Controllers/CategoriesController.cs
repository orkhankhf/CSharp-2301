using EduSys.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace EduSys.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoriyService)
        {
            _categoryService = categoriyService;
        }

        //api/categories/GetSingleCategoryByIdWithProducts/2
        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetSingleCategoryByIdWithProducts(int categoryId)
        {
            return CreateActionResult(await _categoryService.GetSingleCategoryByIdWithProductsAsync(categoryId));
        }
    }
}
