using Microsoft.AspNetCore.Mvc;

namespace Estudo_Api_DDD.Controllers
{
    public class BaseController : Controller
    {
        protected ActionResult CustomResponse(object? result = null)
        {
            if (true)
            {
                return StatusCode(StatusCodes.Status200OK, new
                {
                    sucess = true,
                    data = result
                });
            }

            return StatusCode(StatusCodes.Status400BadRequest, new
            {
                sucess = false,
                error = ""
            });
        }
    }
}
