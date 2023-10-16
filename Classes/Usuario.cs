using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Classes
{
    internal class Usuario
    {

        public object exibirUserDataGrid()
        {
            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Server = DESKTOP-NQ1GMJM\\SQLEXPRESS; DataBase = teste; trusted_connection = true");
            conexao.Open();
            string query = "Select idUsuario as ID, idTipoUsuario as Tipo, nomeUsuario as Nome, CPF, dt_Nascimento as Nascimento, telefone as Telefone, email as 'E-mail' from usuario;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexao);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return (dt);
        }

        public SqlDataReader exibir( string id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Server = DESKTOP-NQ1GMJM\\SQLEXPRESS; DataBase = teste; trusted_connection = true");
            SqlCommand query = new SqlCommand("Select nomeUsuario, dt_Nascimento, CPF, telefone, email, idTipoUsuario from Usuario where idUsuario = @id;", conexao);
            query.Parameters.AddWithValue("@id", id);
            conexao.Open();

            SqlDataReader dataReader = query.ExecuteReader();

            dataReader.Read();

            return dataReader;
        }

        public void excluir(string id)
        {
            SqlConnection conexao = new SqlConnection("Server = DESKTOP-NQ1GMJM\\SQLEXPRESS; DataBase = teste; trusted_connection = true");
            SqlCommand query = new SqlCommand("delete from Usuario where idUsuario = @id;", conexao);
            query.Parameters.AddWithValue("@id", id);
            conexao.Open();
            query.ExecuteNonQuery();

        }

        public void atualizar(string id, string nome, string data, string cpf, string telefone, string email)
        {
            SqlConnection conexao = new SqlConnection("Server = DESKTOP-NQ1GMJM\\SQLEXPRESS; DataBase = teste; trusted_connection = true");
            SqlCommand query = new SqlCommand("update Usuario set nomeUsuario = @nome, dt_nascimento = @data, cpf = @cpf, telefone = @telefone, email = @email  where idUsuario = @id;", conexao);
            query.Parameters.AddWithValue("@id", id);
            query.Parameters.AddWithValue("@nome", nome);
            query.Parameters.AddWithValue("@data", data);
            query.Parameters.AddWithValue("@cpf", cpf);
            query.Parameters.AddWithValue("@telefone", telefone);
            query.Parameters.AddWithValue("@email", email);
            conexao.Open();
            query.ExecuteNonQuery();
        }
    }
}
