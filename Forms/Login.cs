using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Transitions;
using Color = System.Drawing.Color;
using System.Xml;

namespace Prototipo.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labelEmailFocus()
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(400));
            t.add(lblEmail, "Left", 502);
            t.add(lblEmail, "Top", 134);
            t.run();

            lblEmail.Font = new Font(this.Font.Name, 10, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(69, 117, 230);

            txtEmail.PlaceholderText = "usuario@exemplo.com";
        }

        private void labelEmailBlur()
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(400));
            t.add(lblEmail, "Left", 526);
            t.add(lblEmail, "Top", 157);
            t.run();

            lblEmail.Font = new Font(this.Font.Name, 12, FontStyle.Regular);
            lblEmail.ForeColor = Color.DimGray;

            txtEmail.PlaceholderText = "";
        }

        // Pass
        private void labelPassFocus()
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(400));
            t.add(lblPass, "Left", 502);
            t.add(lblPass, "Top", 212);
            t.run();

            lblPass.Font = new Font(this.Font.Name, 10, FontStyle.Bold);
            lblPass.ForeColor = Color.FromArgb(69, 117, 230);

            txtPass.PlaceholderText = "••••••••";
        }

        private void labelPassBlur()
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(400));
            t.add(lblPass, "Left", 526);
            t.add(lblPass, "Top", 235);
            t.run();

            lblPass.Font = new Font(this.Font.Name, 12, FontStyle.Regular);
            lblPass.ForeColor = Color.DimGray;

            txtPass.PlaceholderText = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            
            
            Principal principal = new Principal("");
            principal.Show();
            this.Hide();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            labelEmailFocus();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "") { labelEmailBlur(); }

        }

        private void lblPass_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            labelPassFocus();
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text == "") { labelPassBlur(); }

        }

        private void showHidePass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '•')
            {
                txtPass.Focus();
                txtPass.PasswordChar = '\0';
                showHidePass.Image = Properties.Resources.eye_regular;
            }
            else
            {
                txtPass.ActiveControl = null;
                txtPass.PasswordChar = '•';
                showHidePass.Image = Properties.Resources.eye_slash_regular;
            }
        }
    }
}
