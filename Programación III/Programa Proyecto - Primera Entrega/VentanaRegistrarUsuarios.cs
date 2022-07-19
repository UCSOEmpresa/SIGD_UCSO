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
    public partial class VentanaRegistrarUsuarios : Form
    {
        public VentanaRegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

            if (cBMostrar.Checked == true)
            {
                txtConfContra.PasswordChar = '\0';
            }
            else
            {
                txtConfContra.PasswordChar = '*';
            }
        }

        private void cBTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cBTipoUsuario.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Esta vacío");
            }

            if (txtCorreo.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Esta vacío");
            }

            if (txtCI.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Esta vacío");
            }

            if (txtContra.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Esta vacío");
            }

            if (txtConfContra.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Esta vacío");
            }
        }

        private void VentanaRegistrarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void Error(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Ya te encuentras en la ventana Sobre Nosotros");
        }

        private void btnSN_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaSobreNosotros frm = new VentanaSobreNosotros();
            frm.Show();
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaSoporte frm = new VentanaSoporte();
            frm.Show();
        }

        private void pBIsologo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInicio frm = new VentanaInicio();
            frm.Show();
        }

        private void btnUSA_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaRegistrarUsuariosENG frm = new VentanaRegistrarUsuariosENG();
            frm.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
