using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    ///  Interface responsavel pelo repositorio JogoRepository
    ///  Definir os metodos que serao implementados pelo JogoRepository
    /// </summary>
    public interface IJogoRepository
    {
        /// <summary>
        /// Metodo para cadastrar um novo objeto
        /// </summary>
        /// <param name="novoJogo"></param>
        void Cadastrar(JogoDomain novoJogo);

        /// <summary>
        /// Metodo para Listar todos os objetos
        /// </summary>
        /// <returns>Lista de objeto (Jogo)</returns>
        List<JogoDomain> ListarTodos();
    }
}
