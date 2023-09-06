using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    ///  Interface responsavel pelo repositorio TipoDeUsuarioRepository
    ///  Definir os metodos que serao implementados pelo TipoDeUsuarioRepository
    /// </summary>
    public interface ITipoDeUsuarioRepository
    {
        /// <summary>
        /// Metodo para cadastrar um novo objeto
        /// </summary>
        /// <param name="novoTipoDeUsuario"></param>
        void Cadastrar(TipoDeUsuarioDomain novoTipoDeUsuario);

        /// <summary>
        /// Metodo para Listar todos os objetos
        /// </summary>
        /// <returns>Lista de objeto (TipoDeUsuario)</returns>
        List<TipoDeUsuarioDomain> ListarTodos();
    }
}
