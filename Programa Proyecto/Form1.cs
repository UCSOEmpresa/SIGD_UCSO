using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cBMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cBMostrar.Checked == true)
            {
                txtContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEntrar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContra.Clear();
            txtUsuario.Clear();
        }

        private void validarcampo()
        {
            var vr = !string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContra.Text);
            btnEntrar.Enabled = vr;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            validarcampo();
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            validarcampo();
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInicio frm = new VentanaInicio();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaCambiarContraseña frm = new VentanaCambiarContraseña();
            frm.Show();
        }
    }
}
