using Prototipo.Classes;
using Prototipo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo.Forms
{
    public partial class DashAnunciantes : Form
    {

        private Form currentChildForm;
        public DashAnunciantes()
        {
            InitializeComponent();
        }


         private void OpenChildForm(Form childForm)
        {

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;


            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

        }

        private void DashAnunciantes_Load(object sender, EventArgs e)
        {
           Anunciante anunciante = new Anunciante();
           guna2DataGridView1.DataSource = anunciante.exibirAnuncianteDataGrid();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Settings.Default["atualizaAnunciante"] == "2")
            {
                Anunciante anunciante = new Anunciante();
                guna2DataGridView1.DataSource = anunciante.exibirAnuncianteDataGrid();

                Settings.Default["atualizaAnunciante"] = "1";
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2DataGridView1.Visible = true;
            OpenChildForm(new AlteraAnunciante(id));
        }
    }
}
