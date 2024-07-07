using ApiEstacionamento.Dominio.Entidades.Usuario;
using ApiEstacionamento.Dominio.Interfaces.Usuario;

namespace ApiEstacionamento.Aplicacao.Handles.Usuario
{
    public class UsuarioHandle : IUsuarioHandle
    {
        //private readonly IUsuarioRepositorio _usuarioRepositorio;

        //public UsuarioHandle(IUsuarioRepositorio usuarioRepositorio)
        //{
        //    _usuarioRepositorio = usuarioRepositorio;
        //}

        public async Task<UsuarioOperacao> InsereUsuarioAsync(UsuarioEntidade usuario)
        {
            //return await _usuarioRepositorio.InsereUsuarioAsync(usuario);
            return new UsuarioOperacao();
        }
    }
}
