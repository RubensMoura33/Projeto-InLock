using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade (tabela) TipoDeUsuario
    /// </summary>
    public class TipoDeUsuarioDomain
    {
        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O tipo de usuario e obrigatorio")]
        public string Titulo { get; set; }
    }
}
