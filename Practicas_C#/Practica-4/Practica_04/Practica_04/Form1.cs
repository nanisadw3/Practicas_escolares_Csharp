using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_04
{
    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la forma
            this.Text = "Practica 4"; // Establecer el título de la forma
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string cuenata = txt_cuenta.Text;
            estudiantes.Add(new Estudiante(nombre, cuenata));
            MessageBox.Show("Estudiante registrado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_cuenta.Text = "";
            txt_nombre.Text = "";

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            foreach (var item in estudiantes)
            {
                MessageBox.Show("Nombre: " + item.nombre + " Cuenta: " + item.cuenata, "Asistencia" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
