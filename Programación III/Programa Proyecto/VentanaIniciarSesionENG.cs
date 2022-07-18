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
    public partial class VentanaIniciarSesionENG : Form
    {
        public VentanaIniciarSesionENG()
        {
            InitializeComponent();
        }

        private void btnEspaña_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnIdioma_Click(object sender, EventArgs e)
        {
            if (fLIdioma.Visible == true)
            {
                fLIdioma.Visible = false;
            }
            else
            {
                fLIdioma.Visible = true;
            }
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            VentanaInicioENG frm = new VentanaInicioENG();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaCambiarContraseñaENG frm = new VentanaCambiarContraseñaENG();
            frm.Show();
        }

        private void VentanaIniciarSesionENG_Load(object sender, EventArgs e)
        {
            btnEntrar.Enabled = false;
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
    }
}

