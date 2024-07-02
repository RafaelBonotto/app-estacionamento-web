using ApiEstacionamento.Dominio.Entidades.Usuario;
using ApiEstacionamento.Dominio.Interfaces.Usuario;

namespace ApiEstacionamento.Infra.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public Task<UsuarioOperacao> InsereUsuarioAsync(UsuarioEntidade usuario)
        {
            throw new NotImplementedException();
        }
    }
}
