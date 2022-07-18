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
    public partial class VentanaSobreNosotrosENG : Form
    {
        public VentanaSobreNosotrosENG()
        {
            InitializeComponent();
        }

        private void btnEspaña_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaSobreNosotros frm = new VentanaSobreNosotros();
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

        private void btnFixture_Click(object sender, EventArgs e)
        {
            if (fLFixture.Visible == true)
            {
                fLFixture.Visible = false;
            }
            else
            {
                fLFixture.Visible = true;
            }
        }

        private void btnTorneos_Click(object sender, EventArgs e)
        {
            if (fLTorneos.Visible == true)
            {
                fLTorneos.Visible = false;
            }
            else
            {
                fLTorneos.Visible = true;
            }
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            VentanaJugadoresENG frm = new VentanaJugadoresENG();
            frm.Show();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            VentanaEquiposENG frm = new VentanaEquiposENG();
            frm.Show();
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            VentanaContactoENG frm = new VentanaContactoENG();
            frm.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaIniciarSesionENG frm = new VentanaIniciarSesionENG();
            frm.Show();
        }

        private void btnSN_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            VentanaSoporteENG frm = new VentanaSoporteENG();
            frm.Show();
        }

        private void pBAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Esta vacío");
            }
        }
    }
}
