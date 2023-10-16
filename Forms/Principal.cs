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

namespace Prototipo
{
    public partial class Principal : Form
    {
        private Form currentChildForm;

        string parametro;

        public Principal( string ver)
        {
            InitializeComponent();

             parametro = ver;
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

            panelPrincipal.Controls.Add(childForm);
            panelPrincipal.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
     
            Application.Exit();

        }


        private void Principal_Load(object sender, EventArgs e)
        {
            
            if(parametro == "1")
            {
                OpenChildForm(new DashAnunciantes());
            }
            else if(parametro == "2")
            {
                OpenChildForm(new DashUser());
            }


        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard());
        }

        private void btnAnunciantes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashAnunciantes());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashUser());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
