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
    public class JogoController : ControllerBase
    {
        private IJogoRepository _jogoRepository { get; set; }

        public JogoController()
        {
            _jogoRepository = new JogoRepository();
        }

        /// <summary>
        /// Endpoint que aciona o metodo cadastrar um novo jogo
        /// </summary>
        /// <param name="novoJogo"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(JogoDomain novoJogo)
        {
            try
            {
                _jogoRepository.Cadastrar(novoJogo);
                return StatusCode(201);

            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o metodo ListarTodos
        /// </summary>
        /// <returns>Retorna a resposta para o usuario(fromt-end)</returns>
        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                List<JogoDomain> ListaJogos = _jogoRepository.ListarTodos();
                return Ok(ListaJogos);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
    }
}
