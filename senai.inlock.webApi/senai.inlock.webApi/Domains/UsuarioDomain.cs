using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade (tabela) Usuario
    /// </summary>
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O email do usuario e obrigatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "a senha do usuario e obrigatorio")]
        public string Senha { get; set; }

        public TipoDeUsuarioDomain TipoUsuario { get; set; }
    }
}
