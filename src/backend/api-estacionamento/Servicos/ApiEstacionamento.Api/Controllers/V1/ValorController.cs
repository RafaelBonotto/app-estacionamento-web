using Microsoft.AspNetCore.Mvc;

namespace ApiEstacionamento.Api.Controllers.V1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ValorController : ControllerBase
    {
        private readonly ILogger<ValorController> _logger;

        public ValorController(
            ILogger<ValorController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Obter listagem de valores por hora, diaria e mensalidade
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public async Task<IActionResult> ValorPrimeiraHoraAsync()
        {
            var response = new List<dynamic>()
            {
                new { Periodo = "Primeira Hora", Valor = 15.00 },
                new { Periodo = "Segunda Hora", Valor = 8.00 },
                new { Periodo = "Hora Adicional", Valor = 5.00 },
                new { Periodo = "Diária", Valor = 35.00 },
                new { Periodo = "Mensal", Valor = 150.00 },
            };
            return Ok(response);
        }
    }
}
