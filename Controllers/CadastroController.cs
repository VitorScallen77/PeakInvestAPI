using Microsoft.AspNetCore.Mvc;
using static PeakInvestAPI.Model.Request;

namespace PeakInvestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        [HttpPost("calcular")]
        public ActionResult<CadastroResponse> Calcular([FromBody] CadastroRequest request)
        {
            if (request.Parcelas <= 0 || request.Valor <= 0)
            {
                return BadRequest("Parcelas e Valor devem ser maiores que zero.");
            }

            decimal resultado = (request.Valor * request.Parcelas) * 1.05m;

            return Ok(new CadastroResponse { Resultado = resultado });
        }
    }
}
