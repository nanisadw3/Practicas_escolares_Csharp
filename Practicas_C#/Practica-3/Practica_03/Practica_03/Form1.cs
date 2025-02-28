using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_03
{
    public partial class Form1 : Form
    {
        List<Almacen> productos = new List<Almacen>();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la forma
            this.Text = "Practica 3"; // Establecer el título de la forma
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string clave = txt_clave.Text;
            string nombre = txt_nombre.Text;
            string ubicacion = txt_ubicacion.Text;
            

            if (clave == "" || nombre == "" || ubicacion == "" || txt_cantidad.Text == "")
            {
                MessageBox.Show("Llena todos los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else if (int.Parse(txt_cantidad.Text)<=0)
            {
                MessageBox.Show("La cantidad no puede ser menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int cantidad = int.Parse(txt_cantidad.Text);
                Almacen producto = new Almacen(clave, nombre, ubicacion, cantidad);
                productos.Add(producto);
                MessageBox.Show("Se ha agregado el producto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_buscar.Text = "";
                txt_clave.Text = "";
                txt_nombre.Text = "";
                txt_ubicacion.Text = "";
                txt_cantidad.Text = "";
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string buscar = txt_buscar.Text;
            string clave = "";
            string nombre = "";
            string ubicacion = "";
            int cantidad = 0;
            bool bandera = false;
            foreach (var item in productos)
            {
                if (buscar == item.ubicacion)
                {
                    bandera = true;
                    clave = item.clave;
                    nombre = item.nombre;
                    ubicacion = item.ubicacion;
                    cantidad = item.cantidad;
                    break;

                }
            }
            if (bandera)
            {
                MessageBox.Show("Nombre: " + nombre + " Clave: " + clave + " Ubicacion " +  ubicacion + " Cantidad " + cantidad.ToString(),"Almacen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontro el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
