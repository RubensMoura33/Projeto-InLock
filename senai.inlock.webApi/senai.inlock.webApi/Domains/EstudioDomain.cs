using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade (tabela) Estudio
    /// </summary>
    public class EstudioDomain
    {
        public int IdEstudio { get; set; }

        [Required(ErrorMessage = "O nome do estudio e obrigatorio")]
        public string Nome { get; set; }
    }
}
