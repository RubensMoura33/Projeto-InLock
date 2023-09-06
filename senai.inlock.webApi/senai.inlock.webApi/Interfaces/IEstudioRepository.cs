using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    ///  Interface responsavel pelo repositorio UsuarioRepository
    ///  Definir os metodos que serao implementados pelo UsuarioRepository
    /// </summary>
    public interface IEstudioRepository
    {
        /// <summary>
        /// Metodo para cadastrar um novo objeto
        /// </summary>
        /// <param name="novoEstudio"></param>
        void Cadastrar(EstudioDomain novoEstudio);

        /// <summary>
        /// Metodo para Listar todos os objetos
        /// </summary>
        /// <returns>Lista de objeto (Estudio)</returns>
        List<EstudioDomain> ListarTodos();
    }
}
