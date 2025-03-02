using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la forma
            this.Text = "Practica 2"; // Establecer el título de la forma
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string clave = txt_clave.Text;
            string nombre =txt_nombre.Text;
            string ap = txt_ap.Text;
            string am = txt_am.Text;
            string salario = txt_salario.Text;

            Empleado empleado = new Empleado(clave, nombre, ap, am, salario);
            MessageBox.Show("Empleado tiene un correo " + empleado.generarCorreo(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Nombre: " + empleado.nombre + " Clave: "+ empleado.clave+" Salario: " + empleado.salario);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
