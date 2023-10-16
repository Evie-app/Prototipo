using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace Prototipo.Classes
{
    public class ValidarLogin
    {

        string email = "";
        string senha = "";
        string msg = "";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conexao = new SqlConnection("Server = DESKTOP-NQ1GMJM\\SQLEXPRESS; DataBase = teste; trusted_connection = true");

        SqlDataReader rsUser;

        public void Valida(string email, string senha) {

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                msg = "Preencha todos os campos em branco!";
            }

            else
            {
                cmd.CommandText = "SELECT * FROM funcionario WHERE email = @email";
                cmd.Parameters.AddWithValue("@email", email);

                try 
                {
                    
                    rsUser = cmd.ExecuteReader();
                }
                catch { }
            }
        
        }

    }
}
