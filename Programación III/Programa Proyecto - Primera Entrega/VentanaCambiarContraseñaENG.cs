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
    public partial class VentanaCambiarContraseñaENG : Form
    {
        public VentanaCambiarContraseñaENG()
        {
            InitializeComponent();
        }

        private void btnEspaña_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaCambiarContraseña frm = new VentanaCambiarContraseña();
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

        private void pBAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "")
            {

            }
            else
            {
                MessageBox.Show("It is empty");
            }

            string agregar = "";
            string a = txtCorreo.Text;


            if (a.Contains("@") && a.Contains(".com"))
            {
                agregar += " " + a;
                MessageBox.Show("An email has been sent to you with instructions to reset your password");
                txtCorreo.Clear();
            }
            else
            {
                MessageBox.Show("The email entered is incorrect");
                txtCorreo.Clear();
            }
        }

        private void pBIsologo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInicio frm = new VentanaInicio();
            frm.Show();
        }
    }
}
