using Prototipo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Prototipo.Forms;
using Prototipo.Properties;

namespace Prototipo
{
    public partial class AlteraUsuarios : Form
    {

        string paramentro;
        public AlteraUsuarios(String pesquisa)
        {
            InitializeComponent();
            
            paramentro = pesquisa;
        }

        private void AlteraUsuarios_Load(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            SqlDataReader reader = usuario.exibir(paramentro);
            if (reader!=null)
            {
                txtNome.Text =  reader.GetString(0);
                DateTime data = Convert.ToDateTime(reader["dt_Nascimento"]);
                DateTime dataOnly = data.Date;
                string dataFinal = dataOnly.ToString("d");
                txtDataNasci.Text = dataFinal;
                txtCpf.Text = reader.GetString(2);
                txtTelefone.Text =Convert.ToString(reader["telefone"]);
                txtEmail.Text = reader.GetString(4);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario=new Usuario();
            usuario.atualizar(paramentro, txtNome.Text, txtDataNasci.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text);
            MessageBox.Show("Dados atualizado com sucesso!");
            Settings.Default["atualiza"] = "2";
            Settings.Default.Save();
            this.Close();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Settings.Default["atualiza"] = "2";
            Settings.Default.Save();
            Usuario usuario = new Usuario();
            usuario.excluir(paramentro);
            this.Close();
        }
    }
}
