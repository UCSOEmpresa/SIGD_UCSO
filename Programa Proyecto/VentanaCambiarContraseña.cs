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
    public partial class VentanaCambiarContraseña : Form
    {
        public VentanaCambiarContraseña()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Esta vacío");
            }

            string agregar = "";
            string a = txtCorreo.Text;


            if (a.Contains("@") && a.Contains(".com"))
            {
                agregar += " " + a;
                MessageBox.Show("Se le ha enviado un mail con instrucciones para restablecer su contraseña");
                txtCorreo.Clear();
            }
            else
            {
                MessageBox.Show("El correo introducido es incorrecto");
                txtCorreo.Clear();
            }
        }

        private void pBIcono_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSN_Click(object sender, EventArgs e)
        {
            
            VentanaSobreNosotros frm = new VentanaSobreNosotros();
            frm.Show();
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            VentanaSoporte frm = new VentanaSoporte();
            frm.Show();
        }
    }
}
