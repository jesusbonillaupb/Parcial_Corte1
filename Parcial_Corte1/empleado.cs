using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Corte1
{
    public partial class empleados : Form
    {
        public empleados()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            inicio reg = new inicio();
            reg.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var n = txtNombre.Text;
            var c = txtCedula.Text;
            var h = txtHora.Text;
            var al = "aliñados="+ numPanesAL.Text +", ";
            var na = "no aliñados=" + numPanesNA.Text +", ";
            var es = "especiales" + numPanesE.Text + ", ";
            var am = radAm.Checked;
            var pm = radPm.Checked;
            var amopm = "";

            if (this.numPanesAL.Text == "0") {
                al = "";
            }
            if (this.numPanesNA.Text == "0")
            {
                na = "";
            }
            if (this.numPanesE.Text == "0")
            {
                es = "";
            }
            if (am)
            {
                amopm= "am";

            }
            if (pm)
            {
                amopm = "pm";

            }
            double pal, pan, pes,ca,cna,ce,total;
            ca =double.Parse(numPanesAL.Text);
            cna = double.Parse(numPanesNA.Text);
            ce = double.Parse(numPanesE.Text);
            pal = ca * 1000;
            pan = cna * 500;
            pes = ce * 2000;
            total = pal + pan + pes;
            rtbDatos.Text += "nombre: "+ n +", "+"cc="+ c +", hora "+ h+amopm+" compro: "+ al + na + es+ "total; "+total+"\n"; 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rtbDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            rtbDatos.Clear();
        }
    }
}
