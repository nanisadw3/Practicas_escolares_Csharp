using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Centrar la forma
            this.Text = "Practica 9"; // Establecer el título de la forma
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//para que no se pueda cambiar el tamaño de la ventana
            this.MaximizeBox = false;//para que no se pueda mazimisar la ventana
        }

        private void btn_preparar_Click(object sender, EventArgs e)
        {
            try
            {
                int calentar = int.Parse(txt_calentar.Text);
                if (radio_cafe.Checked)
                {
                    Cafe cafe = new Cafe();
                    cafe.calentar(calentar);
                    MessageBox.Show(cafe.mostrarDescripcion(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radio_te.Checked)
                {
                    Te te = new Te();
                    te.calentar(calentar);
                    MessageBox.Show(te.mostrarDescripcion(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecciona una bebida");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
