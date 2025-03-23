namespace Practica_10
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
            this.radio_te = new System.Windows.Forms.RadioButton();
            this.radio_cafe = new System.Windows.Forms.RadioButton();
            this.btn_preparar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_calentar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radio_te
            // 
            this.radio_te.AutoSize = true;
            this.radio_te.Location = new System.Drawing.Point(41, 29);
            this.radio_te.Name = "radio_te";
            this.radio_te.Size = new System.Drawing.Size(38, 17);
            this.radio_te.TabIndex = 0;
            this.radio_te.TabStop = true;
            this.radio_te.Text = "Te";
            this.radio_te.UseVisualStyleBackColor = true;
            // 
            // radio_cafe
            // 
            this.radio_cafe.AutoSize = true;
            this.radio_cafe.Location = new System.Drawing.Point(91, 29);
            this.radio_cafe.Name = "radio_cafe";
            this.radio_cafe.Size = new System.Drawing.Size(47, 17);
            this.radio_cafe.TabIndex = 1;
            this.radio_cafe.TabStop = true;
            this.radio_cafe.Text = "Cafe";
            this.radio_cafe.UseVisualStyleBackColor = true;
            // 
            // btn_preparar
            // 
            this.btn_preparar.Location = new System.Drawing.Point(51, 99);
            this.btn_preparar.Name = "btn_preparar";
            this.btn_preparar.Size = new System.Drawing.Size(75, 23);
            this.btn_preparar.TabIndex = 2;
            this.btn_preparar.Text = "Preparar";
            this.btn_preparar.UseVisualStyleBackColor = true;
            this.btn_preparar.Click += new System.EventHandler(this.btn_preparar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calentar:";
            // 
            // txt_calentar
            // 
            this.txt_calentar.Location = new System.Drawing.Point(67, 58);
            this.txt_calentar.Name = "txt_calentar";
            this.txt_calentar.Size = new System.Drawing.Size(100, 20);
            this.txt_calentar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 156);
            this.Controls.Add(this.txt_calentar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_preparar);
            this.Controls.Add(this.radio_cafe);
            this.Controls.Add(this.radio_te);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_te;
        private System.Windows.Forms.RadioButton radio_cafe;
        private System.Windows.Forms.Button btn_preparar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_calentar;
    }
}

