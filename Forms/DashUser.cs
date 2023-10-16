using Prototipo.Classes;
using FontAwesome.Sharp;
using Prototipo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototipo.Properties;

namespace Prototipo.Forms
{
    public partial class DashUser : Form
    {

        private Form currentChildForm;

        public DashUser()
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

            guna2Panel1.Controls.Add(childForm);
            guna2Panel1.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

        }


        private void DashUser_Load(object sender, EventArgs e)
        {
        
            Usuario usuario = new Usuario();
            guna2DataGridView1.DataSource = usuario.exibirUserDataGrid(); 

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2DataGridView1.Visible = true;

            OpenChildForm(new AlteraUsuarios(id));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Settings.Default["atualiza"] == "2")
            {
                Usuario usuario = new Usuario();
                guna2DataGridView1.DataSource = usuario.exibirUserDataGrid();

                Settings.Default["atualiza"] = "1";
            }
        }
    }
}
