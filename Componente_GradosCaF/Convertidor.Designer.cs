namespace Componente_GradosCaF
{
    partial class Convertidor
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CelsiusAF = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.FahrenheitAC = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.CantidadAConvertir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.BotonConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convertidor de Temperaturas";
            // 
            // CelsiusAF
            // 
            this.CelsiusAF.AutoSize = true;
            this.CelsiusAF.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusAF.Location = new System.Drawing.Point(70, 160);
            this.CelsiusAF.Name = "CelsiusAF";
            this.CelsiusAF.Size = new System.Drawing.Size(267, 24);
            this.CelsiusAF.TabIndex = 1;
            this.CelsiusAF.TabStop = true;
            this.CelsiusAF.Text = "Grados Celsius a Fahrenheit";
            this.CelsiusAF.UseVisualStyleBackColor = true;
            this.CelsiusAF.CheckedChanged += new System.EventHandler(this.CelsiusAF_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Conversion";
            // 
            // FahrenheitAC
            // 
            this.FahrenheitAC.AutoSize = true;
            this.FahrenheitAC.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrenheitAC.Location = new System.Drawing.Point(70, 190);
            this.FahrenheitAC.Name = "FahrenheitAC";
            this.FahrenheitAC.Size = new System.Drawing.Size(267, 24);
            this.FahrenheitAC.TabIndex = 3;
            this.FahrenheitAC.TabStop = true;
            this.FahrenheitAC.Text = "Grados Fahrenheit a Celsius";
            this.FahrenheitAC.UseVisualStyleBackColor = true;
            this.FahrenheitAC.CheckedChanged += new System.EventHandler(this.FahrenheitAC_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese su Cantidad:";
            // 
            // CantidadAConvertir
            // 
            this.CantidadAConvertir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadAConvertir.Location = new System.Drawing.Point(166, 78);
            this.CantidadAConvertir.Multiline = true;
            this.CantidadAConvertir.Name = "CantidadAConvertir";
            this.CantidadAConvertir.Size = new System.Drawing.Size(229, 32);
            this.CantidadAConvertir.TabIndex = 5;
            this.CantidadAConvertir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CantidadAConvertir.TextChanged += new System.EventHandler(this.CantidadAConvertir_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Su Resultado es: ";
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(169, 286);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(229, 32);
            this.Resultado.TabIndex = 7;
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // BotonConvertir
            // 
            this.BotonConvertir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonConvertir.Location = new System.Drawing.Point(166, 237);
            this.BotonConvertir.Name = "BotonConvertir";
            this.BotonConvertir.Size = new System.Drawing.Size(90, 30);
            this.BotonConvertir.TabIndex = 8;
            this.BotonConvertir.Text = "Convertir";
            this.BotonConvertir.UseVisualStyleBackColor = true;
            this.BotonConvertir.Click += new System.EventHandler(this.BotonConvertir_Click);
            // 
            // Convertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.BotonConvertir);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CantidadAConvertir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FahrenheitAC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CelsiusAF);
            this.Controls.Add(this.label1);
            this.Name = "Convertidor";
            this.Size = new System.Drawing.Size(398, 341);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CelsiusAF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton FahrenheitAC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CantidadAConvertir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button BotonConvertir;
    }
}
