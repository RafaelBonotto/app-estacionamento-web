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
            return Ok();
        }
    }
}
