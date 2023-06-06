using EduSys.Core.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EduSys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode,
                    Value = response.Data
                };

            return new ObjectResult(null)
            {
                StatusCode = response.StatusCode,
                Value = response.Data
            };
        }
    }
}
