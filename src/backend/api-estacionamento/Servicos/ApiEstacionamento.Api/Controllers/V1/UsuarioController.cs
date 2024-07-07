using ApiEstacionamento.Api.ViewModel.Usuario;
using ApiEstacionamento.Aplicacao.Handles.Usuario;
using ApiEstacionamento.Dominio.Entidades.Usuario;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ApiEstacionamento.Api.Controllers.V1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        //private readonly IMapper _mapper;
        //private readonly IUsuarioHandle _usuarioHandle;

        public UsuarioController(
            ILogger<UsuarioController> logger)
            //IUsuarioHandle usuarioHandle,
            //IMapper mapper)
        {
            _logger = logger;
            //_usuarioHandle = usuarioHandle;
            //_mapper = mapper;
        }

        /// <summary>
        /// Realizar cadastro de usuário
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostAsync(UsuarioInVM viewModel)
        {
            //var usuario = _mapper.Map<UsuarioEntidade>(viewModel);
            //var response = await _usuarioHandle.InsereUsuarioAsync(usuario);
            //var usuarioOperacao = _mapper.Map<UsuarioOperacao>(response);
            //return Ok(usuarioOperacao);
            return Ok();
        }

        /// <summary>
        /// Realizar login de usuário
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(UsuarioInVM viewModel)
        {
            return Ok();
        }
        
        /// <summary>
        /// Realizar recuperação de senha do usuário
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost("recuperar-senha")]
        public async Task<IActionResult> ValidateAsync(UsuarioInVM viewModel)
        {
            return Ok();
        }
    }
}
