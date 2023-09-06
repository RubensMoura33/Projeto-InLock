using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;

namespace senai.inlock.webApi.Controllers
{
    //Define que a rota de uma aquisicao sera no seguinte formato
    //dominio/api/nomeController
    //Ex: http://localhost:5000/api/genero
    [Route("api/[controller]")]

    //Define que e um controlador de API
    [ApiController]

    //Define que o tipo de resposta da Api sera no formato JSON
    [Produces("application/json")]

    //Metodo controlador que herda da controller base
    //Onde sera criado os Endpoints (rotas)

    public class EstudioController : ControllerBase
    {
        /// <summary>
        /// Objeto _estudioRepository que ira receber todos os metodos definidos na Interface IEstudioRepository
        /// </summary>
        private IEstudioRepository _estudioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _filmeRepository para que haja referencia aos metodos no repositorio
        /// </summary>
        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }
        /// <summary>
        ///  Endpoint que aciona o metodo de cadastro de estudio
        /// </summary>
        /// <param name="novoEstudio">Objeto recebido na requisicao</param>
        /// <returns></returns>
        [HttpPost]

        public IActionResult Post(EstudioDomain novoEstudio)
        {
            try
            {
                //Fazendo a chamada para o metodo cadastrar passando o objeto como parametro
                _estudioRepository.Cadastrar(novoEstudio);

                //Retorna um status code 201 - Created
                return StatusCode(201);

            }
            catch (Exception erro)
            {
                //Retorna um status code 400(BadRequest) e a mensagem do erro
                return BadRequest(erro.Message);
            }
        }
    }
}
