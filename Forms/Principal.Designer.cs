namespace Prototipo
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnAnunciantes = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMenu.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnAnunciantes);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.guna2Panel4);
            this.panelMenu.Controls.Add(this.guna2Panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.MaximumSize = new System.Drawing.Size(250, 681);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(86)))));
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(164)))), ((int)(((byte)(246)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(164)))), ((int)(((byte)(246)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnSair.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSair.IconSize = 40;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 599);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(17, 0, 20, 0);
            this.btnSair.Rotation = 180D;
            this.btnSair.Size = new System.Drawing.Size(250, 82);
            this.btnSair.TabIndex = 24;
            this.btnSair.Text = "Finalizar Sessão";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(86)))));
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(164)))), ((int)(((byte)(246)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(164)))), ((int)(((byte)(246)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial", 10F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 40;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 343);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(17, 0, 20, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(250, 81);
            this.btnUsuarios.TabIndex = 23;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnAnunciantes
            // 
            this.btnAnunciantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnAnunciantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnunciantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnunciantes.FlatAppearance.BorderSize = 0;
            this.btnAnunciantes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(86)))));
            this.btnAnunciantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(164)))), ((int)(((byte)(246)))));
            this.btnAnunciantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(164)))), ((int)(((byte)(246)))));
            this.btnAnunciantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnunciantes.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAnunciantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAnunciantes.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            this.btnAnunciantes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnAnunciantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnunciantes.IconSize = 40;
            this.btnAnunciantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnunciantes.Location = new System.Drawing.Point(0, 262);
            this.btnAnunciantes.Name = "btnAnunciantes";
            this.btnAnunciantes.Padding = new System.Windows.Forms.Padding(17, 0, 20, 0);
            this.btnAnunciantes.Size = new System.Drawing.Size(250, 81);
            this.btnAnunciantes.TabIndex = 22;
            this.btnAnunciantes.Text = "Anunciantes";
            this.btnAnunciantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnunciantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnunciantes.UseVisualStyleBackColor = false;
            this.btnAnunciantes.Click += new System.EventHandler(this.btnAnunciantes_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(86)))));
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(164)))), ((int)(((byte)(246)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(164)))), ((int)(((byte)(246)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 40;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 181);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(17, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(250, 81);
            this.btnDashboard.TabIndex = 20;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 110);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(250, 71);
            this.guna2Panel4.TabIndex = 19;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.guna2Panel3.BackgroundImage = global::Prototipo.Properties.Resources.logo_removebg_preview;
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(250, 110);
            this.guna2Panel3.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.guna2Panel2.Controls.Add(this.panelPrincipal);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.CustomizableEdges.BottomRight = false;
            this.guna2Panel2.CustomizableEdges.TopRight = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(164)))), ((int)(((byte)(246)))));
            this.guna2Panel2.Location = new System.Drawing.Point(250, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(994, 681);
            this.guna2Panel2.TabIndex = 15;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(994, 681);
            this.panelPrincipal.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(81)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1244, 681);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1260, 720);
            this.MinimumSize = new System.Drawing.Size(1260, 720);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelMenu.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel panelPrincipal;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private FontAwesome.Sharp.IconButton btnAnunciantes;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnUsuarios;
    }
}