namespace Practica_06
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_constrasena = new System.Windows.Forms.TextBox();
            this.dataT_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Constraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(153, 33);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 3;
            // 
            // txt_constrasena
            // 
            this.txt_constrasena.Location = new System.Drawing.Point(153, 70);
            this.txt_constrasena.Name = "txt_constrasena";
            this.txt_constrasena.Size = new System.Drawing.Size(100, 20);
            this.txt_constrasena.TabIndex = 4;
            // 
            // dataT_fecha
            // 
            this.dataT_fecha.Location = new System.Drawing.Point(153, 102);
            this.dataT_fecha.Name = "dataT_fecha";
            this.dataT_fecha.Size = new System.Drawing.Size(200, 20);
            this.dataT_fecha.TabIndex = 5;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(278, 142);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 191);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.dataT_fecha);
            this.Controls.Add(this.txt_constrasena);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_constrasena;
        private System.Windows.Forms.DateTimePicker dataT_fecha;
        private System.Windows.Forms.Button btn_registrar;
    }
}

