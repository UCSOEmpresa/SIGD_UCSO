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
    public partial class VentanaFixtureBasketball : Form
    {
        public VentanaFixtureBasketball()
        {
            InitializeComponent();
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

        private void pBAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            this.Hide();
            VentanaJugadores frm = new VentanaJugadores();
            frm.Show();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaEquipos frm = new VentanaEquipos();
            frm.Show();
        }

        private void Error(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Ya estas viendo el fixture de los torneos de basketball");
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContacto frm = new VentanaContacto();
            frm.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void lblHandball_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaFixtureHandball frm = new VentanaFixtureHandball();
            frm.Show();
        }

        private void lblFutbol2_Click(object sender, EventArgs e)
        {
            VentanaTorneosFutbol frm = new VentanaTorneosFutbol();
            frm.Show();
        }

        private void lblBasket2_Click(object sender, EventArgs e)
        {
            VentanaTorneosBasketball frm = new VentanaTorneosBasketball();
            frm.Show();
        }

        private void lblHandball2_Click(object sender, EventArgs e)
        {
            VentanaTorneosHandball frm = new VentanaTorneosHandball();
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

        private void lblFutbol_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaFixtureFutbol frm = new VentanaFixtureFutbol();
            frm.Show();
        }

        private void btnSN_Click(object sender, EventArgs e)
        {
            VentanaSobreNosotros frm = new VentanaSobreNosotros();
            frm.Show();
        }

        private void Clear(object sender, MouseEventArgs e)
        {
            txtBusqueda.Clear();
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            VentanaSoporte frm = new VentanaSoporte();
            frm.Show();
        }

        private void btnBuscarFix_Click(object sender, EventArgs e)
        {
            if (txtFix.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Esta vacío");
            }
        }

        private void lblBasket_Click(object sender, EventArgs e)
        {

        }

        private void pBIsologo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInicio frm = new VentanaInicio();
            frm.Show();
        }
    }
}
