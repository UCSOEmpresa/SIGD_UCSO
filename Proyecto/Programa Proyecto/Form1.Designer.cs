namespace Programa_Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.pBIsologo = new System.Windows.Forms.PictureBox();
            this.btnInvitado = new System.Windows.Forms.Button();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.cBMostrar = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIsologo)).BeginInit();
            this.SuspendLayout();
            // 
            // pBLogo
            // 
            this.pBLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBLogo.Image = global::Programa_Proyecto.Properties.Resources.LOGO_UCSO;
            this.pBLogo.Location = new System.Drawing.Point(528, 34);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(115, 93);
            this.pBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBLogo.TabIndex = 0;
            this.pBLogo.TabStop = false;
            // 
            // pBIsologo
            // 
            this.pBIsologo.BackColor = System.Drawing.Color.Transparent;
            this.pBIsologo.Image = global::Programa_Proyecto.Properties.Resources.isologotipo;
            this.pBIsologo.Location = new System.Drawing.Point(12, 12);
            this.pBIsologo.Name = "pBIsologo";
            this.pBIsologo.Size = new System.Drawing.Size(149, 104);
            this.pBIsologo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBIsologo.TabIndex = 1;
            this.pBIsologo.TabStop = false;
            // 
            // btnInvitado
            // 
            this.btnInvitado.Location = new System.Drawing.Point(1041, 22);
            this.btnInvitado.Name = "btnInvitado";
            this.btnInvitado.Size = new System.Drawing.Size(101, 56);
            this.btnInvitado.TabIndex = 2;
            this.btnInvitado.Text = "Invitado";
            this.btnInvitado.UseVisualStyleBackColor = true;
            this.btnInvitado.Click += new System.EventHandler(this.btnInvitado_Click);
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciarSesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.Location = new System.Drawing.Point(472, 182);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(207, 35);
            this.lblIniciarSesion.TabIndex = 3;
            this.lblIniciarSesion.Text = "Iniciar Sesión";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(455, 273);
            this.txtUsuario.MaxLength = 8;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(265, 22);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(455, 327);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(265, 22);
            this.txtContra.TabIndex = 5;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // cBMostrar
            // 
            this.cBMostrar.AutoSize = true;
            this.cBMostrar.BackColor = System.Drawing.Color.Transparent;
            this.cBMostrar.Location = new System.Drawing.Point(455, 373);
            this.cBMostrar.Name = "cBMostrar";
            this.cBMostrar.Size = new System.Drawing.Size(118, 17);
            this.cBMostrar.TabIndex = 6;
            this.cBMostrar.Text = "Mostrar Contraseña";
            this.cBMostrar.UseVisualStyleBackColor = false;
            this.cBMostrar.CheckedChanged += new System.EventHandler(this.cBMostrar_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(619, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 45);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(455, 413);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(118, 45);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(469, 506);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(257, 24);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Has olvidado tu contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Programa_Proyecto.Properties.Resources.Fondo_ventanas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 632);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cBMostrar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.btnInvitado);
            this.Controls.Add(this.pBIsologo);
            this.Controls.Add(this.pBLogo);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Ventana Iniciar Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIsologo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBLogo;
        private System.Windows.Forms.PictureBox pBIsologo;
        private System.Windows.Forms.Button btnInvitado;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.CheckBox cBMostrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

