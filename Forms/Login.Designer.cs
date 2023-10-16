namespace Prototipo.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblEsqueciSenha = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.showHidePass = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showHidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.Location = new System.Drawing.Point(480, 306);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(326, 52);
            this.btnLogin.TabIndex = 31;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseTransparentBackground = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEsqueciSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueciSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblEsqueciSenha.Location = new System.Drawing.Point(565, 380);
            this.lblEsqueciSenha.Name = "lblEsqueciSenha";
            this.lblEsqueciSenha.Size = new System.Drawing.Size(157, 18);
            this.lblEsqueciSenha.TabIndex = 26;
            this.lblEsqueciSenha.Text = "Esqueci minha senha";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(412, 461);
            this.guna2Panel1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(593, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 34);
            this.label2.TabIndex = 41;
            this.label2.Text = "LOGIN";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.guna2Panel2.Location = new System.Drawing.Point(590, 102);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(120, 3);
            this.guna2Panel2.TabIndex = 42;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lblPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPass.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblPass.Location = new System.Drawing.Point(526, 235);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 18);
            this.lblPass.TabIndex = 46;
            this.lblPass.Text = "Senha";
            this.lblPass.Click += new System.EventHandler(this.lblPass_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(526, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 18);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "E-mail";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // showHidePass
            // 
            this.showHidePass.BackColor = System.Drawing.Color.Transparent;
            this.showHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showHidePass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.showHidePass.Image = global::Prototipo.Properties.Resources.eye_slash_regular;
            this.showHidePass.ImageRotate = 0F;
            this.showHidePass.Location = new System.Drawing.Point(767, 233);
            this.showHidePass.Name = "showHidePass";
            this.showHidePass.Size = new System.Drawing.Size(25, 25);
            this.showHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showHidePass.TabIndex = 47;
            this.showHidePass.TabStop = false;
            this.showHidePass.UseTransparentBackground = true;
            this.showHidePass.Click += new System.EventHandler(this.showHidePass_Click);
            // 
            // txtPass
            // 
            this.txtPass.Animated = true;
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.txtPass.BorderRadius = 8;
            this.txtPass.BorderThickness = 2;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.txtPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.txtPass.IconLeft = global::Prototipo.Properties.Resources.cad;
            this.txtPass.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtPass.IconLeftSize = new System.Drawing.Size(17, 17);
            this.txtPass.Location = new System.Drawing.Point(485, 218);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(326, 52);
            this.txtPass.TabIndex = 44;
            this.txtPass.TextOffset = new System.Drawing.Point(8, 0);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.txtEmail.IconLeft = global::Prototipo.Properties.Resources.emails;
            this.txtEmail.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtEmail.IconLeftSize = new System.Drawing.Size(17, 17);
            this.txtEmail.Location = new System.Drawing.Point(485, 140);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(326, 52);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.TextOffset = new System.Drawing.Point(8, 0);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Prototipo.Properties.Resources.logo_removebg_preview;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(54, 102);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(293, 254);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.showHidePass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblEsqueciSenha);
            this.Controls.Add(this.btnLogin);
            this.MaximumSize = new System.Drawing.Size(880, 500);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showHidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblEsqueciSenha;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox showHidePass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
    }
}