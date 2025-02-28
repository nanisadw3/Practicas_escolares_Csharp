using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_07
{
    public partial class Form1 : Form
    {
        //variable global
        List<Asistencia> lista = new List<Asistencia>();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la forma
            this.Text = "Practica 7"; // Establecer el título de la forma

            try
            {

                StreamReader r = new StreamReader("nombres.txt");
                while (!r.EndOfStream)
                {
                    string linea = r.ReadLine();

                    combo_nombres.Items.Add(linea);
                }
                r.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargo el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = combo_nombres.Text;
            string fecha = txt_fecha.Text;
            int asistencia;
            if (ch_asistio.Checked)
            {
                asistencia = 1;
            }
            else
            {
                asistencia = 0;
            }
            Asistencia asis = new Asistencia(fecha, asistencia, nombre);
            lista.Add(asis);

            try
            {

                StreamWriter w = new StreamWriter("asistencia.txt", false);
                w.WriteLine(nombre + "," + fecha + "," + asis + "\n");
                w.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la creacion del archivo asistencia.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Asistencia registrada", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            string asist;
            string fecha = txt_fecha.Text;
            foreach (var a in lista)
            {
                if (a.fecha == fecha)
                {
                    if (a.asistio == 1)
                    {
                        asist = "Asistio";
                    }
                    else
                    {
                        asist = "falto";
                    }
                    MessageBox.Show("El nombre es: " + a.nombre + " este alumno " + asist,"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
