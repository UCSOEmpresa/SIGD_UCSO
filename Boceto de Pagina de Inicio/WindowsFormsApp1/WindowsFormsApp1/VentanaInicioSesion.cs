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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaCambiarContraseña frm = new VentanaCambiarContraseña();
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void cBMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cBMostrar.Checked == true)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else{
                txtContraseña.PasswordChar = '*';
            }
                    
        }
    }
}
