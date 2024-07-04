using Microsoft.AspNetCore.Mvc;

namespace ApiEstacionamento.Api.Controllers.V1
{

    [ApiController]
    [Route("v1/[controller]")]
    public class ColaboradorController : ControllerBase
    {
        private readonly ILogger<ColaboradorController> _logger;

        public ColaboradorController(
            ILogger<ColaboradorController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Realizar cadstro do colaborador
        /// </summary>
        /// <returns></returns>
        [HttpPost()]
        public async Task<IActionResult> PostAsync()
        {
            return Ok();
        }
        
        /// <summary>
        /// Realizar atualização de dados do colaborador
        /// </summary>
        /// <returns></returns>
        [HttpPut()]
        public async Task<IActionResult> PutAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Realizar exclusão de colaborador
        /// </summary>
        /// <returns></returns>
        [HttpDelete()]
        public async Task<IActionResult> DeleteAsync()
        {
            return Ok();
        }
        
        /// <summary>
        /// Obter listagem de colaboradores
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public async Task<IActionResult> GetAsync()
        {
            return Ok();
        }
        
        /// <summary>
        /// Obter colaborador por id
        /// </summary>
        /// <returns></returns>
        [HttpGet("id")]
        public async Task<IActionResult> GetIdAsync()
        {
            return Ok();
        }
    }

}
