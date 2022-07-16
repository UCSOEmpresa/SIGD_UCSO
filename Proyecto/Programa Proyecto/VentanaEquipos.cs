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
    public partial class VentanaEquipos : Form
    {
        public VentanaEquipos()
        {
            InitializeComponent();
        }

        private void btnFutbol_Click(object sender, EventArgs e)
        {
            VentanaEquiposFutbol frm = new VentanaEquiposFutbol();
            frm.Show();
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
            VentanaJugadores frm = new VentanaJugadores();
            frm.Show();
        }

        private void Clear(object sender, MouseEventArgs e)
        {
            
        }

        private void Error(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Ya te encuentras en la ventana Equipos");
        }
    }
}
