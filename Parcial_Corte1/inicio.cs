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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            if (this.txtUsuario.Text == "admin" && this.txtContraseña.Text == "admin2021")
            {
                admin adm = new admin();
                adm.Show();
                this.Hide();
            }

            else
            {
                if (this.txtUsuario.Text == "empleado" && this.txtContraseña.Text == "empleado2021")
                {
                    empleado emp = new empleado();
                    emp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta, vuelva a intentar");
                }
            }

            txtUsuario.Clear();
            txtContraseña.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var verco = cheVercontra.Checked;
            if (verco)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
