namespace ejercicio_2_listbox
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
            this.lstfrutas = new System.Windows.Forms.ListBox();
            this.Istfrutas = new System.Windows.Forms.CheckedListBox();
            this.txtfruta = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblfruta = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstfrutas
            // 
            this.lstfrutas.FormattingEnabled = true;
            this.lstfrutas.Items.AddRange(new object[] {
            "manzana ",
            "aguacate",
            "pera"});
            this.lstfrutas.Location = new System.Drawing.Point(114, 127);
            this.lstfrutas.Name = "lstfrutas";
            this.lstfrutas.Size = new System.Drawing.Size(120, 95);
            this.lstfrutas.TabIndex = 0;
            this.lstfrutas.SelectedIndexChanged += new System.EventHandler(this.lstfrutas_SelectedIndexChanged);
            // 
            // Istfrutas
            // 
            this.Istfrutas.FormattingEnabled = true;
            this.Istfrutas.Location = new System.Drawing.Point(164, 117);
            this.Istfrutas.Name = "Istfrutas";
            this.Istfrutas.Size = new System.Drawing.Size(8, 4);
            this.Istfrutas.TabIndex = 1;
            // 
            // txtfruta
            // 
            this.txtfruta.Location = new System.Drawing.Point(12, 12);
            this.txtfruta.Name = "txtfruta";
            this.txtfruta.Size = new System.Drawing.Size(100, 20);
            this.txtfruta.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(270, 10);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblfruta
            // 
            this.lblfruta.AutoSize = true;
            this.lblfruta.Location = new System.Drawing.Point(84, 108);
            this.lblfruta.Name = "lblfruta";
            this.lblfruta.Size = new System.Drawing.Size(35, 13);
            this.lblfruta.TabIndex = 4;
            this.lblfruta.Text = "label1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(270, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 271);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblfruta);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtfruta);
            this.Controls.Add(this.Istfrutas);
            this.Controls.Add(this.lstfrutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstfrutas;
        private System.Windows.Forms.CheckedListBox Istfrutas;
        private System.Windows.Forms.TextBox txtfruta;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblfruta;
        private System.Windows.Forms.Button btnEliminar;
    }
}

