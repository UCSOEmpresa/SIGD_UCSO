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
    public partial class VentanaRegistrarUsuariosENG : Form
    {
        public VentanaRegistrarUsuariosENG()
        {
            InitializeComponent();
        }

        private void btnEspaña_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaRegistrarUsuarios frm = new VentanaRegistrarUsuarios();
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

        private void btnSN_Click(object sender, EventArgs e)
        {
            VentanaSobreNosotrosENG frm = new VentanaSobreNosotrosENG();
            frm.Show();
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            VentanaSoporteENG frm = new VentanaSoporteENG();
            frm.Show();
        }

        private void pBIsologo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInicio frm = new VentanaInicio();
            frm.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cBTipoUsuario.Text != "")
            {

            }
            else
            {
                MessageBox.Show("It is empty");
            }

            if (txtCorreo.Text != "")
            {

            }
            else
            {
                MessageBox.Show("It is empty");
            }

            if (txtCI.Text != "")
            {

            }
            else
            {
                MessageBox.Show("It is empty");
            }

            if (txtContra.Text != "")
            {

            }
            else
            {
                MessageBox.Show("It is empty");
            }

            if (txtConfContra.Text != "")
            {

            }
            else
            {
                MessageBox.Show("It is empty");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
