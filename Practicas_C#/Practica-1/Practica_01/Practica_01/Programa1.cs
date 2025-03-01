using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_01
{
    public partial class Programa1 : Form
    {
        public Programa1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la forma
            this.Text = "Practica 1"; // Establecer el título de la forma

        }

        private void Programa1_Load(object sender, EventArgs e)
        {

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            string titular = txt_titular.Text;
            string numeroCuenta = txt_cuenta.Text;
            string anualidad = txt_anualidad.Text;
            
            if (titular == "" || numeroCuenta == "" || anualidad == "" || txt_saldo.Text == "")
            {

                MessageBox.Show("Llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int saldo = int.Parse(txt_saldo.Text);
                Cuenta cuenta = new Cuenta(saldo, titular, numeroCuenta, anualidad);
                MessageBox.Show("Cuenta creada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_titular.Text = "";
                txt_cuenta.Text = "";
                txt_anualidad.Text = "";
                txt_saldo.Text = "";

            }
            

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            
            if (txt_Distancia.Text ==""|| txt_tiempo.Text=="")
            {
                MessageBox.Show("Llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int distancia = int.Parse(txt_Distancia.Text);
                int tiempo = int.Parse(txt_tiempo.Text);
                Calcular calcular = new Calcular(distancia, tiempo);
                MessageBox.Show("La velocidad es: " + calcular.CalcularVelocidad() + " m/s", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txt_Distancia.Text = "";
            txt_tiempo.Text = "";

        }

        private void txt_diastolica_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcDS_Click(object sender, EventArgs e)
        {
            if (txt_sistolica.Text == "" || txt_diastolica.Text == "")
            {
                
                MessageBox.Show("Llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int sistolica = int.Parse(txt_sistolica.Text);
                int diastolica = int.Parse(txt_diastolica.Text);
                Precion precion = new Precion(sistolica, diastolica);
                MessageBox.Show("La precion es: " + precion.CalcularPrecion(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sistolica.Text = "";
                txt_diastolica.Text = "";
            }
        }
    }
}
