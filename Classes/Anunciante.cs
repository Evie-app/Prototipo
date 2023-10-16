using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Classes
{
    internal class Anunciante
    {


        public object exibirAnuncianteDataGrid()
        {
            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Server = DESKTOP-NQ1GMJM\\SQLEXPRESS; DataBase = teste; trusted_connection = true");
            conexao.Open();
            string query = "Select * from anunciante";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexao);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return (dt);
        }

        public SqlDataReader exibir(string id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Server = DESKTOP-NQ1GMJM\\SQLEXPRESS; DataBase = teste; trusted_connection = true");
            SqlCommand query = new SqlCommand("Select * from Anunciante where idAnunciante = @id;", conexao);
            query.Parameters.AddWithValue("@id", id);
            conexao.Open();

            SqlDataReader dataReader = query.ExecuteReader();

            dataReader.Read();

            return dataReader;
        }

        public void excluir(string id)
        {
            SqlConnection conexao = new SqlConnection("Server = DESKTOP-NQ1GMJM\\SQLEXPRESS; DataBase = teste; trusted_connection = true");
            SqlCommand query = new SqlCommand("delete from Anunciante where idAnunciante = @id;", conexao);
            query.Parameters.AddWithValue("@id", id);
            conexao.Open();
            query.ExecuteNonQuery();

        }

        public void atualizar(string id, string nome, string dataInvestimento, string dataExpiracao, decimal pagamento, bool ativo, int metricas)
        {
            SqlConnection conexao = new SqlConnection("Server = DESKTOP-NQ1GMJM\\SQLEXPRESS; DataBase = teste; trusted_connection = true");
            SqlCommand query = new SqlCommand("update Anunciante set nomeAnunciante = @nome, dt_investimento_inicio = @dataInvestimento, dt_investimento_expiracao = @dataExpiracao, pagamento = @pagamento, ativo = @ativo, metricas = @metricas where idAnunciante = @id", conexao);
            query.Parameters.AddWithValue("@id", id);
            query.Parameters.AddWithValue("@nome", nome);
            query.Parameters.AddWithValue("@dataInvestimento", dataInvestimento);
            query.Parameters.AddWithValue("@dataExpiracao", dataExpiracao);
            query.Parameters.AddWithValue("@pagamento", pagamento);
            query.Parameters.AddWithValue("@ativo",ativo);
            query.Parameters.AddWithValue("@metricas", metricas);
            conexao.Open();
            query.ExecuteNonQuery();
        }
    }
}
