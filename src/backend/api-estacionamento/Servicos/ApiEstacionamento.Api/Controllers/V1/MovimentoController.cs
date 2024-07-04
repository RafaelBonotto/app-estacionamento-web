using Microsoft.AspNetCore.Mvc;

namespace ApiEstacionamento.Api.Controllers.V1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class MovimentoController : ControllerBase
    {
        private readonly ILogger<MovimentoController> _logger;

        public MovimentoController(
            ILogger<MovimentoController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Realizar registro de entrada de veículo
        /// </summary>
        /// <returns></returns>
        [HttpPost("registrar-entrada")]
        public async Task<IActionResult> RegistraEntradaAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Realizar registro de saída de veículo
        /// </summary>
        /// <returns></returns>
        [HttpPost("registrar-saida")]
        public async Task<IActionResult> RegistraSaidaAsync()
        {
            return Ok();
        }
    }
}
