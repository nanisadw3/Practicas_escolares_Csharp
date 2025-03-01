using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_08
{
    public partial class Form1 : Form
    {
        List<Pizzeria> pizzeria = new List<Pizzeria>();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Centrar la forma
            this.Text = "Practica 8"; // Establecer el título de la forma
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//para que no se pueda cambiar el tamaño de la ventana
            this.MaximizeBox = false;//para que no se pueda mazimisar la ventana

            txt_repartidor.Enabled = false;
            combo_clave.Enabled = true;
            combo_estatus.Enabled = false;
            try
            {
                StreamReader r = new StreamReader("Entregas.dat");
                while (!r.EndOfStream)
                {
                    string linea = r.ReadLine();
                    string[] separar = linea.Split('|'); // Divide la línea en partes usando "|"
                    
                    if (separar.Length >= 2) // Asegurarse de que hay al menos clave y estado
                    {
                        combo_clave.Items.Add(separar[0]);//Clave
        
                        string repartidor = separar[2];   //Estado
                        Pizzeria p = new Pizzeria(separar[0], separar[1], repartidor);
                        pizzeria.Add(p);
                    }
                }
                combo_estatus.Items.Add("Preparando");//Estado
                combo_estatus.Items.Add("Horneando");//Estado
                combo_estatus.Items.Add("Entregando");//Estado
                r.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargo el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reparti = txt_repartidor.Text;
            string clave = combo_clave.SelectedItem.ToString();
            string estatus = combo_estatus.SelectedItem.ToString();

            try
            {

                foreach (var item in pizzeria)
                {
                    if (clave == item.Clave)
                    {
                        item.Repartidor = reparti;
                        break;
                    }

                }

                using (StreamWriter w = new StreamWriter("Entregas.dat", false))
                {
                    foreach (var item in pizzeria)
                    {
                        w.WriteLine(item.Clave + "|" + item.Estatus + "|" + item.Repartidor);
                    }
                }
                
                MessageBox.Show("Editado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combo_clave_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = combo_clave.SelectedItem.ToString();
            bool bandera = false;
            string repartidor = "";
            string estatus = "";

            foreach (var item in pizzeria)
            {
                if (clave == item.Clave)
                {
                    bandera = true;
                    repartidor = item.Repartidor;
                    estatus = item.Estatus;
                    break;
                }
            }
            if (bandera)
            {
                txt_repartidor.Text = repartidor;
                combo_estatus.Text = estatus;
                if (combo_estatus.Text == "Preparando" || combo_estatus.Text == "Horneando")
                {
                    txt_repartidor.Enabled = false;
                    combo_estatus.Enabled = false;
                }
                else {

                    txt_repartidor.Enabled = true;
                    combo_estatus.Enabled = true; 

                }
            }
            else
            {
                MessageBox.Show("No se encontro la clave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
