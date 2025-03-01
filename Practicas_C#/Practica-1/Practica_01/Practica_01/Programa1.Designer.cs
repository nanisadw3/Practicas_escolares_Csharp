namespace Practica_01
{
    partial class Programa1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_crear = new System.Windows.Forms.Button();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.txt_anualidad = new System.Windows.Forms.TextBox();
            this.txt_titular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_Distancia = new System.Windows.Forms.TextBox();
            this.txt_tiempo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sistolica = new System.Windows.Forms.TextBox();
            this.txt_diastolica = new System.Windows.Forms.TextBox();
            this.btn_calcDS = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_titular);
            this.tabPage1.Controls.Add(this.txt_anualidad);
            this.tabPage1.Controls.Add(this.txt_cuenta);
            this.tabPage1.Controls.Add(this.txt_saldo);
            this.tabPage1.Controls.Add(this.btn_crear);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Programa 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_tiempo);
            this.tabPage2.Controls.Add(this.txt_Distancia);
            this.tabPage2.Controls.Add(this.btn_calcular);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Programa 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_calcDS);
            this.tabPage3.Controls.Add(this.txt_diastolica);
            this.tabPage3.Controls.Add(this.txt_sistolica);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(385, 277);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Programa 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Cuneta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anuelidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Titular:";
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(172, 155);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 4;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(147, 46);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(100, 20);
            this.txt_saldo.TabIndex = 5;
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.Location = new System.Drawing.Point(147, 73);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(100, 20);
            this.txt_cuenta.TabIndex = 6;
            // 
            // txt_anualidad
            // 
            this.txt_anualidad.Location = new System.Drawing.Point(147, 102);
            this.txt_anualidad.Name = "txt_anualidad";
            this.txt_anualidad.Size = new System.Drawing.Size(100, 20);
            this.txt_anualidad.TabIndex = 7;
            // 
            // txt_titular
            // 
            this.txt_titular.Location = new System.Drawing.Point(147, 129);
            this.txt_titular.Name = "txt_titular";
            this.txt_titular.Size = new System.Drawing.Size(100, 20);
            this.txt_titular.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Distancia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tiempo:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(164, 119);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_Distancia
            // 
            this.txt_Distancia.Location = new System.Drawing.Point(152, 65);
            this.txt_Distancia.Name = "txt_Distancia";
            this.txt_Distancia.Size = new System.Drawing.Size(100, 20);
            this.txt_Distancia.TabIndex = 3;
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.Location = new System.Drawing.Point(152, 93);
            this.txt_tiempo.Name = "txt_tiempo";
            this.txt_tiempo.Size = new System.Drawing.Size(100, 20);
            this.txt_tiempo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sistolica:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Diastolica:";
            // 
            // txt_sistolica
            // 
            this.txt_sistolica.Location = new System.Drawing.Point(147, 61);
            this.txt_sistolica.Name = "txt_sistolica";
            this.txt_sistolica.Size = new System.Drawing.Size(100, 20);
            this.txt_sistolica.TabIndex = 2;
            // 
            // txt_diastolica
            // 
            this.txt_diastolica.Location = new System.Drawing.Point(147, 91);
            this.txt_diastolica.Name = "txt_diastolica";
            this.txt_diastolica.Size = new System.Drawing.Size(100, 20);
            this.txt_diastolica.TabIndex = 3;
            this.txt_diastolica.TextChanged += new System.EventHandler(this.txt_diastolica_TextChanged);
            // 
            // btn_calcDS
            // 
            this.btn_calcDS.Location = new System.Drawing.Point(157, 117);
            this.btn_calcDS.Name = "btn_calcDS";
            this.btn_calcDS.Size = new System.Drawing.Size(75, 23);
            this.btn_calcDS.TabIndex = 4;
            this.btn_calcDS.Text = "Calcullar";
            this.btn_calcDS.UseVisualStyleBackColor = true;
            this.btn_calcDS.Click += new System.EventHandler(this.btn_calcDS_Click);
            // 
            // Programa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 324);
            this.Controls.Add(this.tabControl1);
            this.Name = "Programa1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Programa1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_titular;
        private System.Windows.Forms.TextBox txt_anualidad;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tiempo;
        private System.Windows.Forms.TextBox txt_Distancia;
        private System.Windows.Forms.Button btn_calcDS;
        private System.Windows.Forms.TextBox txt_diastolica;
        private System.Windows.Forms.TextBox txt_sistolica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

