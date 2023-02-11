namespace la_loteria
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnJuega = new System.Windows.Forms.Button();
            this.txtPrimera = new System.Windows.Forms.TextBox();
            this.txtSegunda = new System.Windows.Forms.TextBox();
            this.txtTercera = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.primera = new System.Windows.Forms.Label();
            this.segunda = new System.Windows.Forms.Label();
            this.Tercera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(170, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // btnJuega
            // 
            this.btnJuega.Location = new System.Drawing.Point(169, 150);
            this.btnJuega.Name = "btnJuega";
            this.btnJuega.Size = new System.Drawing.Size(81, 36);
            this.btnJuega.TabIndex = 7;
            this.btnJuega.Text = "juega";
            this.btnJuega.UseVisualStyleBackColor = true;
            this.btnJuega.Click += new System.EventHandler(this.btnJuega_Click);
            // 
            // txtPrimera
            // 
            this.txtPrimera.Location = new System.Drawing.Point(73, 93);
            this.txtPrimera.Name = "txtPrimera";
            this.txtPrimera.Size = new System.Drawing.Size(67, 20);
            this.txtPrimera.TabIndex = 8;
            // 
            // txtSegunda
            // 
            this.txtSegunda.Location = new System.Drawing.Point(170, 93);
            this.txtSegunda.Name = "txtSegunda";
            this.txtSegunda.Size = new System.Drawing.Size(82, 20);
            this.txtSegunda.TabIndex = 9;
            // 
            // txtTercera
            // 
            this.txtTercera.Location = new System.Drawing.Point(286, 93);
            this.txtTercera.Name = "txtTercera";
            this.txtTercera.Size = new System.Drawing.Size(91, 20);
            this.txtTercera.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(81, 223);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(256, 25);
            this.lblResultado.TabIndex = 11;
            // 
            // primera
            // 
            this.primera.AutoSize = true;
            this.primera.Location = new System.Drawing.Point(81, 57);
            this.primera.Name = "primera";
            this.primera.Size = new System.Drawing.Size(42, 13);
            this.primera.TabIndex = 12;
            this.primera.Text = "Primera";
            // 
            // segunda
            // 
            this.segunda.AutoSize = true;
            this.segunda.Location = new System.Drawing.Point(195, 57);
            this.segunda.Name = "segunda";
            this.segunda.Size = new System.Drawing.Size(50, 13);
            this.segunda.TabIndex = 13;
            this.segunda.Text = "Segunda";
            // 
            // Tercera
            // 
            this.Tercera.AutoSize = true;
            this.Tercera.Location = new System.Drawing.Point(316, 57);
            this.Tercera.Name = "Tercera";
            this.Tercera.Size = new System.Drawing.Size(44, 13);
            this.Tercera.TabIndex = 14;
            this.Tercera.Text = "Tercera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 336);
            this.Controls.Add(this.Tercera);
            this.Controls.Add(this.segunda);
            this.Controls.Add(this.primera);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtTercera);
            this.Controls.Add(this.txtSegunda);
            this.Controls.Add(this.txtPrimera);
            this.Controls.Add(this.btnJuega);
            this.Controls.Add(this.txtNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnJuega;
        private System.Windows.Forms.TextBox txtPrimera;
        private System.Windows.Forms.TextBox txtSegunda;
        private System.Windows.Forms.TextBox txtTercera;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label primera;
        private System.Windows.Forms.Label segunda;
        private System.Windows.Forms.Label Tercera;
    }
}

