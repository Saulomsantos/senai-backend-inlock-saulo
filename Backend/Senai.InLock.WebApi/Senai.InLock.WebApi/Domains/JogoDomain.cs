using System;
using System.ComponentModel.DataAnnotations;

namespace Senai.InLock.WebApi.Domains
{
    /// <summary>
    /// Classe responsável pela tabela jogos
    /// </summary>
    public class JogoDomain
    {
        public int JogoId { get; set; }

        [Required(ErrorMessage = "Informe o nome do jogo")]
        public string NomeJogo { get; set; }

        [Required(ErrorMessage = "Informe a descrição do jogo")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe a data de lançamento do jogo")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Informe o valor do jogo")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Informe o ID do estudio")]
        public int EstudioId { get; set; }
        public EstudioDomain Estudio { get; set; }
    }
}
