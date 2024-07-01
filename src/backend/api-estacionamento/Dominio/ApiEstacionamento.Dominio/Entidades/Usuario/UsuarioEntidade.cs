using ApiEstacionamento.Dominio.Entidades.Base;
using Dapper.Contrib.Extensions;

namespace ApiEstacionamento.Dominio.Entidades.Usuario
{
    [Table("tb_usuario")]
    public class UsuarioEntidade : EntidadeBase
    {
        public long Id { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public long Id_role { get; set; }
    }
}
