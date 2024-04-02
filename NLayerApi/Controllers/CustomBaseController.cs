using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerCore.DTOs;

namespace NLayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {

        [NonAction] //Buranın bir endpoint olmadığını belirtmek için kullanıldı. Http isteğine yanıt olarak kullanılamaz.
        public IActionResult CreateActionResult<T> (CustomResponseDto<T> response)
        {
            if(response.StatusCode==204)
            {
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            }

            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
 