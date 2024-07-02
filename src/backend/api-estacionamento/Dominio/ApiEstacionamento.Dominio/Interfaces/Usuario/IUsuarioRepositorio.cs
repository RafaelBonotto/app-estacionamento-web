using ApiEstacionamento.Dominio.Entidades.Usuario;

namespace ApiEstacionamento.Dominio.Interfaces.Usuario
{
    public interface IUsuarioRepositorio
    {
        Task<UsuarioOperacao> InsereUsuarioAsync(UsuarioEntidade usuario);
    }
}
