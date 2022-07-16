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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaBuscarJugadores frm = new VentanaBuscarJugadores();
            frm.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaEquipos frm = new VentanaEquipos();
            frm.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaContacto frm = new VentanaContacto();
            frm.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaTorneos frm = new VentanaTorneos();
            frm.Show();
        }

       

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaSoporte frm = new VentanaSoporte();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (fLidioma.Visible==true)
                {
                fLidioma.Visible = false;
            }
            else
            {
                fLidioma.Visible = true;
            }
        }

        private void fLidioma_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fLidioma.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.pictureBox6.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (pictureBox6.Visible == false) {
                this.pictureBox6.Visible = true;
                this.pBespaña.Visible = false;
            }
            else
            {
                this.pictureBox6.Visible = false;
                this.pBespaña.Visible = true;
            }
              
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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

        private void label8_Click_1(object sender, EventArgs e)
        {
            VentanaFutbolFix frm = new VentanaFutbolFix();
            frm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ventana_Registrar frm = new Ventana_Registrar();
            frm.Show();

        }

        private void fLFixture_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ventana_Registrar frm = new Ventana_Registrar();
            frm.Show();
        }
    }
}
