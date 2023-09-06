using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    ///  Interface responsavel pelo repositorio UsuarioRepository
    ///  Definir os metodos que serao implementados pelo UsuarioRepository
    /// </summary>
    public interface IUsuarioRepository
    {
        //tipoRetorno  NomeMetodo(tipoParametro nomeParametro)

        /// <summary>
        /// Metodo para cadastrar um novo objeto
        /// </summary>
        /// <param name="novoUsuario"></param>
        void Cadastrar(UsuarioDomain novoUsuario);

        /// <summary>
        /// Metodo para Listar todos os objetos
        /// </summary>
        /// <returns>Lista de objeto (Usuario)</returns>
        List<UsuarioDomain> ListarTodos();
    }
}
