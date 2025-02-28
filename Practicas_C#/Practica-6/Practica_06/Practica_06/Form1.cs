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

namespace Practica_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la forma
            this.Text = "Practica 6"; // Establecer el título de la forma
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string password = txt_constrasena.Text;
            string fecha = dataT_fecha.Value.ToString();
            if (usuario == "")
            {
                MessageBox.Show("Ingrese un usuario");
            }
            else if (password == "")
            {
                MessageBox.Show("Ingrese una contraseña");
            }
            else if (dataT_fecha.Value.Year > 2012)
            {
                MessageBox.Show("Fecha no valida");
            }
            else
            {
                Usuario user = new Usuario(usuario, password, fecha);
                MessageBox.Show("Usuario registrado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try {
                    using (StreamWriter writer = new StreamWriter("usuarios.txt", true))
                    {
                        writer.WriteLine("El usuario es " + usuario + " la contrasena es " + password + " la fecha es " + fecha);
                        writer.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


            }
        }
    }
}
