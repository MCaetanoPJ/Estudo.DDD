using Microsoft.AspNetCore.Mvc;

namespace Estudo_Api_DDD.Controllers
{
    [Route("api/paciente")]
    public class PacienteController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return CustomResponse();
        }
    }
}
