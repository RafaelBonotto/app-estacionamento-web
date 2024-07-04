using Microsoft.AspNetCore.Mvc;

namespace ApiEstacionamento.Api.Controllers.V1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(
            ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Realizar cadastro de cliente
        /// </summary>
        /// <returns></returns>
        [HttpPost()]
        public async Task<IActionResult> PostAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Realizar atuialização de dados do cliente
        /// </summary>
        /// <returns></returns>
        [HttpPut()]
        public async Task<IActionResult> PutAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Realizar exclusão de cliente
        /// </summary>
        /// <returns></returns>
        [HttpDelete()]
        public async Task<IActionResult> DeleteAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Obter listagem de clientes
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public async Task<IActionResult> GetAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Obter cliente por id
        /// </summary>
        /// <returns></returns>
        [HttpGet("id")]
        public async Task<IActionResult> GetIdAsync()
        {
            return Ok();
        }
    }
}
