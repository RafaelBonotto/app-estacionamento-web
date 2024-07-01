using ApiEstacionamento.Dominio.Entidades.Usuario;

namespace ApiEstacionamento.Aplicacao.Handles.Usuario
{
    public interface IUsuarioHandle
    {
        Task<UsuarioOperacao> InsereUsuarioAsync(UsuarioEntidade usuario);
    }
}
