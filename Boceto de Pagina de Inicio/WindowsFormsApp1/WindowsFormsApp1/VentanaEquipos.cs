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
    public partial class VentanaEquipos : Form
    {
        public VentanaEquipos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaEquiposFut frm = new VentanaEquiposFut();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaEquiposBasket frm = new VentanaEquiposBasket();
            frm.Show();
        }
    }
}
