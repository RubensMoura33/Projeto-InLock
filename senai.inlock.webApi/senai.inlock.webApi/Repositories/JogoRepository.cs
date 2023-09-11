using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;
using System.Drawing;

namespace senai.inlock.webApi.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private string StringConexao = "Data Source = NOTE11-S13; Initial Catalog = inlock_games; User Id = sa; Pwd = Senai@134";
        public void Cadastrar(JogoDomain novoJogo)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryInsert = "INSERT INTO Jogo (IdEstudio, Nome, Descricao, DataLancamento, Valor) VALUES (@IdEstudio, @Nome, @Descricao, @DataLancamento, @Valor)";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdEstudio", novoJogo.IdEstudio);

                    cmd.Parameters.AddWithValue("@Nome", novoJogo.Nome);

                    cmd.Parameters.AddWithValue("@Descricao", novoJogo.Descricao);

                    cmd.Parameters.AddWithValue("@DataLancamento", novoJogo.DataLancamento);

                    cmd.Parameters.AddWithValue("@Valor", novoJogo.Valor);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        public List<JogoDomain> ListarTodos()
        {
            List<JogoDomain> listarJogos = new List<JogoDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelectAll = "SELECT IdJogo, Estudio.IdEstudio , Jogo.Nome, Jogo.Descricao , Jogo.DataLancamento , Jogo.Valor , Estudio.Nome AS NomeEstudio FROM Jogo INNER JOIN Estudio ON Estudio.IdEstudio = Jogo.IdEstudio";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        JogoDomain jogo = new JogoDomain()
                        {
                            IdJogo = Convert.ToInt32(rdr["IdJogo"]),

                            IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),

                            Nome = Convert.ToString(rdr["Nome"]),

                            Descricao = Convert.ToString(rdr["Descricao"]),

                            DataLancamento = Convert.ToString(rdr["DataLancamento"]),

                            Valor = Convert.ToDouble(rdr["Valor"]),

                            Estudio = new EstudioDomain() 
                            {
                                IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),

                                Nome = Convert.ToString(rdr["NomeEstudio"])
                            }

                        };

                        listarJogos.Add(jogo);
                        }
                    
                }

            }
            return listarJogos;
        }
    }
}
