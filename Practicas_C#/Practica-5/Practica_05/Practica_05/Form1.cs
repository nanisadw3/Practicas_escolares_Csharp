using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_05
{
    public partial class Form1 : Form
    {
        List<Guitarra> guitarras = new List<Guitarra>();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la forma
            this.Text = "Practica 5"; // Establecer el título de la forma
            numeric_nc.Value = 5;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string clave = txt_clave.Text;
            string nombre = txt_nombre.Text;
            int numeroCuerdas = (int)numeric_nc.Value;
            if (clave == "" || nombre =="" || txt_precio.Text =="")
            {
                MessageBox.Show("Llena todos los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(int.Parse(txt_precio.Text) <= 0)
            {
                MessageBox.Show("El precio no puede ser menor o igual a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (numeroCuerdas<4 ||numeroCuerdas>7)
            {
                MessageBox.Show("El numero de cuerdas no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float precio = float.Parse(txt_precio.Text);
                MessageBox.Show("Guitarra registrada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Guitarra g = new Guitarra(clave, nombre, precio, numeroCuerdas);
                guitarras.Add(g);
                txt_clave.Text = "";
                txt_nombre.Text = "";
                txt_precio.Text = "";
                numeric_nc.Value = 5;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            
            txt_consulta.Text = "";
            foreach (var g in guitarras)
            {
                txt_consulta.Text += "Clave: " + g.Clave + " Nombre: " + g.Nombre + " Precio: " + g.CalcularPrecio() + " Numero de cuerdas: " + g.NumeroCuerdas + Environment.NewLine;
            }
            
        }
    }
}
