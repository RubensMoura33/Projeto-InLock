using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        /// <summary>
        /// String de conexao com o banco de dados que recebe os seguintes parametros:
        /// Data Source : Nome do Servidor
        /// Initial Catalog : Nome do Bnacco de dados
        /// Autenticacao :
        /// - Windows : Integrated Security = true
        /// -SqlServer : User Id = Login; Pwd = Senha
        /// </summary>
        /// 

        //private string StringConexao = "Data Source = NOTE11-S13; Initial Catalog = inlock_games; User Id = sa; Pwd = Senai@134";
        private string StringConexao = "Data Source = R4ULM1LGR4U\\SQLEXPRESSS; Initial Catalog = inlock_games; User Id = sa; Pwd = Binho$2022";
        /// <summary>
        /// Cadastrar um novo estudio
        /// </summary>
        /// <param name="novoEstudio">Objeto com as informacoes que serao cadastradas</param>
        public void Cadastrar(EstudioDomain novoEstudio)
        {
            //Declara a conexao passando a string de conexao como parametro
            using (SqlConnection con = new SqlConnection(StringConexao) )
            {
                //Declara a query que sera executada
                string queryInsert = "INSERT INTO Estudio (Nome) VALUES (@Nome)";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    //Passa o valor do parametro @Nome
                    cmd.Parameters.AddWithValue("@Nome", novoEstudio.Nome);

                    //Abre a conexao com banco de dados
                    con.Open();

                    //Executa a query(queryInsert)
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Listar todos objetos (estudios)
        /// </summary>
        /// <returns>Lista de objeto (estudios)</returns>
        public List<EstudioDomain> ListarTodos()
        {
            //Cria uma lista de objetos do tipo genero
            List<EstudioDomain> listaEstudios = new List<EstudioDomain>();

            //Declara a SqlConnection passando a string de conexao como parametro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelctAll = "SELECT * FROM Estudio";

                //Abre a conexao com banco de dados
                con.Open();

                //Declara o SqlDataReader para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                //
                using(SqlCommand cmd = new SqlCommand(querySelctAll, con))
                {
                    //Declara o SqlDataReader para percorrer a tabela do banco de dados
                    rdr = cmd.ExecuteReader();

                    while(rdr.Read())
                    {

                        EstudioDomain estudio = new EstudioDomain()

                        {
                            //Atribui a propriedade IdEstudio o valor recebido no rdr
                            IdEstudio = Convert.ToInt32(rdr[0]),

                            //atribui a propriedade Nome o valr recebeido no rdr
                            Nome = rdr[1].ToString()

                        };

                        listaEstudios.Add(estudio);
                    }

                }

                return listaEstudios;

            }
        }
    }
}
