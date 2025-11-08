using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppCurso.Controller
{
    internal class Curso
    {
        private readonly string stringConexao = "Server=localhost; Database=APPCURSOS; Integrated Security=True";

        #region Ligar BD

        public bool LigarBD()
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();string query = "USE APPCURSOS";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }

                }
                catch (SqlException ex)
                {
                    throw new Exception("Erro ao ligar o bd: " + ex.Message);
                }
            }
        }

        #endregion

        #region Cadastrar Curso

        public bool CadastrarCurso(string nome, string link, string status)
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();
                    string query = "EXEC cadastrar_curso @nome = @Nome, @link = @Link, @status = @Status;";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Link", link);
                        cmd.Parameters.AddWithValue("@Status", status);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Erro ao acessar o bd: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao cadastrar curso: " + ex.Message);
                }
            }
        }

        #endregion

        #region Mostrar Cursos

        public DataTable ListarCursos()
        {
            DataTable tabela = new DataTable();
            string query = "SELECT * FROM Curso";

            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexao);
                    adaptador.Fill(tabela);
                }
                catch (SqlException ex)
                {
                    throw new Exception("Erro ao listar cursos" + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
                return tabela;

            }
        }

        #endregion

        #region Deletar Curso

        public bool DeletarCurso(int pk)
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();

                    string query = "EXEC deletar_curso @pk = @Pk";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Pk", pk);

                        return cmd.ExecuteNonQuery() > 0;
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao deletar. Erro: " + ex.Message, ex);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        #endregion

    }
}
