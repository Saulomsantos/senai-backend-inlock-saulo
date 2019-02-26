using System.ComponentModel.DataAnnotations;

namespace Senai.InLock.WebApi.Domains
{
    /// <summary>
    /// Classe responsável pela tabela Estudios
    /// </summary>
    public class EstudioDomain
    {
        public int EstudioId { get; set; }

        [Required(ErrorMessage = "Informe o nome do estúdio")]
        public string NomeEstudio { get; set; }
    }
}
