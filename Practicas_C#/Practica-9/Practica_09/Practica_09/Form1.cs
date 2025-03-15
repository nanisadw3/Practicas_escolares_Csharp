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

namespace Practica_09
{
    public partial class Form1 : Form
    {
        List<Registros> registros = new List<Registros>();
        public Form1()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Centrar la forma
            this.Text = "Practica 9"; // Establecer el título de la forma
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//para que no se pueda cambiar el tamaño de la ventana
            this.MaximizeBox = false;//para que no se pueda mazimisar la ventana
            try
            {
                StreamReader sr = new StreamReader("usuarios.txt");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split(',');
                    string usuario = parts[0];
                    string password = parts[1];
                    Registros r = new Registros(usuario, password);
                    registros.Add(r);

                }
                sr.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                string usuario = txt_nombre.Text;
                string password = txt_constrasena.Text;
                int anio = int.Parse(dtp.Value.Year.ToString());
                if (usuario =="" || password == "")
                {
                    throw new MiExepcionCampoVacio("No se permiten campos vacios");
                }else if (password.Length<6)
                {
                    MessageBox.Show("La contraseña debe tener al menos 6 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if(anio>2009)
                {
                    MessageBox.Show("El anio no puede ser superior al 2009", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    bool bandera = false;
                    foreach (Registros r in registros)
                    {
                        if (usuario == r.usuario)
                        {
                            bandera = true;
                            break;
                        }
                    }
                    if (bandera)
                    {
                        MessageBox.Show("El usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        StreamWriter w = new StreamWriter("usuarios.txt",true);
                        w.WriteLine(usuario + "," + password);
                        w.Close();
                        Registros r = new Registros(usuario, password);
                        registros.Add(r);
                        MessageBox.Show("Usuario registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MiExepcionCampoVacio ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
