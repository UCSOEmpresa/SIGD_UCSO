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
    public partial class VentanaFixtureBasketballENG : Form
    {
        public VentanaFixtureBasketballENG()
        {
            InitializeComponent();
        }

        private void btnEspaña_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaFixtureBasketball frm = new VentanaFixtureBasketball();
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
            VentanaSobreNosotrosENG frm = new VentanaSobreNosotrosENG();
            frm.Show();
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
                MessageBox.Show("It is empty");
            }
        }

        private void lblFutbol_Click(object sender, EventArgs e)
        {
            VentanaFixtureFutbolENG frm = new VentanaFixtureFutbolENG();
            frm.Show();
        }

        private void lblBasket_Click(object sender, EventArgs e)
        {
            
        }

        private void lblHandball_Click(object sender, EventArgs e)
        {
            VentanaFixtureHandballENG frm = new VentanaFixtureHandballENG();
            frm.Show();
        }

        private void lblFutbol2_Click(object sender, EventArgs e)
        {
            VentanaTorneosFutbolENG frm = new VentanaTorneosFutbolENG();
            frm.Show();
        }

        private void lblBasket2_Click(object sender, EventArgs e)
        {
           
        }

        private void lblHandball2_Click(object sender, EventArgs e)
        {
            VentanaTorneosHandballENG frm = new VentanaTorneosHandballENG();
            frm.Show();
        }

        private void pBIsologo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInicio frm = new VentanaInicio();
            frm.Show();
        }

        private void Clear(object sender, MouseEventArgs e)
        {
            txtBusqueda.Clear();
        }

        private void btnBuscarFix_Click(object sender, EventArgs e)
        {
            if (txtFix.Text != "")
            {

            }
            else
            {
                MessageBox.Show("It is empty");
            }
        }

        private void Error(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You are already watching the fixture of the basketball tournaments");
        }
    }
}
