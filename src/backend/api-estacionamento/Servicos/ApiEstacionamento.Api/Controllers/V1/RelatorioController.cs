using Microsoft.AspNetCore.Mvc;

namespace ApiEstacionamento.Api.Controllers.V1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class RelatorioController : ControllerBase
    {
        private readonly ILogger<RelatorioController> _logger;

        public RelatorioController(
            ILogger<RelatorioController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gerar relatório diário de movimento
        /// </summary>
        /// <returns></returns>
        [HttpPost("diario")]
        public async Task<IActionResult> RelatorioDiarioAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Gerar relatório semanal de movimento
        /// </summary>
        /// <returns></returns>
        [HttpPost("semanal")]
        public async Task<IActionResult> RelatorioSemanalAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Gerar relatório mensal de movimento
        /// </summary>
        /// <returns></returns>
        [HttpPost("mensal")]
        public async Task<IActionResult> RelatorioMensalAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Gerar relatório anual de movimento
        /// </summary>
        /// <returns></returns>
        [HttpPost("anual")]
        public async Task<IActionResult> RelatorioAnualAsync()
        {
            return Ok();
        }

    }
}
