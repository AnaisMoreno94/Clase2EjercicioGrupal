namespace WindowsTPGrupal
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
            this.btnCrearBicicleta = new System.Windows.Forms.Button();
            this.btnCreateAutoF1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearBicicleta
            // 
            this.btnCrearBicicleta.Location = new System.Drawing.Point(111, 103);
            this.btnCrearBicicleta.Name = "btnCrearBicicleta";
            this.btnCrearBicicleta.Size = new System.Drawing.Size(168, 23);
            this.btnCrearBicicleta.TabIndex = 0;
            this.btnCrearBicicleta.Text = "Crear Bicicleta";
            this.btnCrearBicicleta.UseVisualStyleBackColor = true;
            this.btnCrearBicicleta.Click += new System.EventHandler(this.btnCrearBicicleta_Click);
            // 
            // btnCreateAutoF1
            // 
            this.btnCreateAutoF1.Location = new System.Drawing.Point(111, 55);
            this.btnCreateAutoF1.Name = "btnCreateAutoF1";
            this.btnCreateAutoF1.Size = new System.Drawing.Size(168, 23);
            this.btnCreateAutoF1.TabIndex = 1;
            this.btnCreateAutoF1.Text = "Crear Auto de  Formula 1";
            this.btnCreateAutoF1.UseVisualStyleBackColor = true;
            this.btnCreateAutoF1.Click += new System.EventHandler(this.btnCreateAutoF1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.btnCreateAutoF1);
            this.Controls.Add(this.btnCrearBicicleta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearBicicleta;
        private System.Windows.Forms.Button btnCreateAutoF1;
    }
}

