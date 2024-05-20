using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace PeakInvestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private readonly List<KeyValuePair<int, string>> lista = new()
        {
            new KeyValuePair<int, string>(1, "João"),
            new KeyValuePair<int, string>(2, "Maria"),
            new KeyValuePair<int, string>(3, "Ana")
        };

        [HttpGet("buscar/{id:int}")]
        public ActionResult<object> Buscar(int id)
        {
            var item = lista.FirstOrDefault(kvp => kvp.Key == id);

            if (item.Equals(default(KeyValuePair<int, string>)))
            {
                return NotFound(new { mensagem = "ID não encontrado." });
            }

            return Ok(new { id = item.Key, nome = item.Value });
        }
    }
}
