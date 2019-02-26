using System.ComponentModel.DataAnnotations;

namespace Senai.InLock.WebApi.Domains
{
    public class UsuarioDomain
    {
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe o nome do jogo")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o nome do jogo")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe o nome do jogo")]
        public string TipoUsuario { get; set; }
    }
}
