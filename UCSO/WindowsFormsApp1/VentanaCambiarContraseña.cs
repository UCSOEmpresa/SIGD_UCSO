using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VentanaCambiarContraseña : Form
    {
        public VentanaCambiarContraseña()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            MessageBox.Show("Se le ha enviado un correo para restablecer su contraseña");
        }
    }
}
