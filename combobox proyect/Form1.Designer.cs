﻿namespace combobox_proyect
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
            this.cmbAlimentos = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtAlimentos = new System.Windows.Forms.TextBox();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lbltexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAlimentos
            // 
            this.cmbAlimentos.FormattingEnabled = true;
            this.cmbAlimentos.Items.AddRange(new object[] {
            "frijol",
            "tomate"});
            this.cmbAlimentos.Location = new System.Drawing.Point(88, 12);
            this.cmbAlimentos.Name = "cmbAlimentos";
            this.cmbAlimentos.Size = new System.Drawing.Size(121, 21);
            this.cmbAlimentos.TabIndex = 0;
            this.cmbAlimentos.Text = "Alimentos";
            this.cmbAlimentos.SelectedIndexChanged += new System.EventHandler(this.cmbAlimentos_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(223, 140);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(111, 34);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtAlimentos
            // 
            this.txtAlimentos.Location = new System.Drawing.Point(12, 148);
            this.txtAlimentos.Name = "txtAlimentos";
            this.txtAlimentos.Size = new System.Drawing.Size(100, 20);
            this.txtAlimentos.TabIndex = 2;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(9, 74);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(35, 13);
            this.lblIndice.TabIndex = 3;
            this.lblIndice.Text = "label1";
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(299, 74);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(35, 13);
            this.lbltexto.TabIndex = 4;
            this.lbltexto.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 323);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.txtAlimentos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cmbAlimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlimentos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtAlimentos;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lbltexto;
    }
}

