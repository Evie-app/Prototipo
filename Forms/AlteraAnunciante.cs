using Prototipo.Classes;
using Prototipo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo.Forms
{
    public partial class AlteraAnunciante : Form
    {

        string parametro;

        public AlteraAnunciante(String pesquisa)
        {
            InitializeComponent();
            parametro = pesquisa;
        }


        private void AlteraAnunciante_Load(object sender, EventArgs e)
        {
            Anunciante anunciante = new Anunciante();
            SqlDataReader reader =  anunciante.exibir(parametro);
            if (reader != null)
            {
                txtNome.Text = reader.GetString(1);
                dtpInvestimento.Value = Convert.ToDateTime(reader["dt_investimento_inicio"]);
                dtpExpiracao.Value = Convert.ToDateTime(reader["dt_investimento_expiracao"]);
                decimal ver = Convert.ToDecimal(reader["pagamento"]);
                txtValor.Text = Convert.ToString(ver);


                if (Convert.ToBoolean(reader["ativo"]) == true) {

                    cbxAtivo.Text = "Ativo";
                    cbxAtivo.SelectedIndex = 0;
                }
                else { cbxAtivo.Text = "Desativado"; cbxAtivo.SelectedIndex = 1; }

               txtMetricas.Text = Convert.ToString(reader["metricas"]);

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Settings.Default["atualizaAnunciante"] = "2";
            Settings.Default.Save();
            Anunciante anunciante = new Anunciante();
            anunciante.excluir(parametro);
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool ativos;
            if (cbxAtivo.Text == "Ativo")
            {
                ativos = true;
            }
            else { ativos = false; }

            Settings.Default["atualizaAnunciante"] = "2";
            Settings.Default.Save();
            Anunciante anunciante = new Anunciante();
            anunciante.atualizar(parametro, txtNome.Text, dtpInvestimento.Text, dtpExpiracao.Text, Convert.ToDecimal(txtValor.Text), ativos, Convert.ToInt32(txtMetricas.Text));
            this.Close();
        }
    }
}
