using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;

namespace senai.inlock.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Cadastrar(UsuarioDomain novoUsuario)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public UsuarioDomain Login(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
