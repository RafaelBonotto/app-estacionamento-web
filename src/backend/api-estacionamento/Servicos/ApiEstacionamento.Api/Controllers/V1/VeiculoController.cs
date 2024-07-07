using Microsoft.AspNetCore.Mvc;

namespace ApiEstacionamento.Api.Controllers.V1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class VeiculoController : ControllerBase
    {
        private readonly ILogger<VeiculoController> _logger;

        public VeiculoController(
            ILogger<VeiculoController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Realizar cadastro de veículo do cliente
        /// </summary>
        /// <returns></returns>
        [HttpPost()]
        public async Task<IActionResult> PostAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Realizar atualização de dados de veículo do cliente
        /// </summary>
        /// <returns></returns>
        [HttpPut()]
        public async Task<IActionResult> PutAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Realizar exclusão de veículo do cliente
        /// </summary>
        /// <returns></returns>
        [HttpDelete()]
        public async Task<IActionResult> DeleteAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Obter listagem de veículos cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public async Task<IActionResult> GetAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Obter veículo por id
        /// </summary>
        /// <returns></returns>
        [HttpGet("id")]
        public async Task<IActionResult> GetIdAsync()
        {
            return Ok();
        }
    }
}
