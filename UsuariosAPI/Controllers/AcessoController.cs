using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UsuariosAPI.Controllers
{
    //validador de acesso a partir do token

    [ApiController]
    [Route("[Controller]")]
    public class AcessoController: ControllerBase
    {
        [HttpGet]
        [Authorize(Policy = "IdadeMinima")]
        public ActionResult Get() 
        {
            return Ok("Acesso permitido");
        }
    }
}
