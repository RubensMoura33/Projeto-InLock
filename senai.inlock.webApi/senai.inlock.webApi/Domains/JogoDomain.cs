using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade (tabela) Jogo
    /// </summary>
    public class JogoDomain
    {
        public int IdJogo { get; set; }

        public int IdEstudio { get; set; }

        [Required(ErrorMessage = "O nome do jogo e obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descricao do jogo e obrigatorio")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A data de lancamento do jogo e obrigatorio")]
        public string DataLancamento { get; set; }

        [Required(ErrorMessage = "O valor do jogo e obrigatorio")]
        public double Valor { get; set; }

        public EstudioDomain Estudio { get; set; }
    }
}
