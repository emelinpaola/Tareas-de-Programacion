namespace LiteDBProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnGuardarDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.dtpedad = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dtgvCustomers = new System.Windows.Forms.DataGridView();
            this.dtgNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscardb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.Menu;
            this.txtnombre.Location = new System.Drawing.Point(27, 34);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(110, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // btnGuardarDB
            // 
            this.btnGuardarDB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnGuardarDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDB.Location = new System.Drawing.Point(142, 184);
            this.btnGuardarDB.Name = "btnGuardarDB";
            this.btnGuardarDB.Size = new System.Drawing.Size(111, 63);
            this.btnGuardarDB.TabIndex = 1;
            this.btnGuardarDB.Text = "GuardaDB";
            this.btnGuardarDB.UseVisualStyleBackColor = false;
            this.btnGuardarDB.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.SystemColors.Info;
            this.txtapellido.Location = new System.Drawing.Point(247, 25);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(107, 20);
            this.txtapellido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTelefono.Location = new System.Drawing.Point(4, 104);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(111, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cedula";
            // 
            // txtcedula
            // 
            this.txtcedula.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtcedula.Location = new System.Drawing.Point(226, 104);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(110, 20);
            this.txtcedula.TabIndex = 7;
            // 
            // dtpedad
            // 
            this.dtpedad.CalendarMonthBackground = System.Drawing.SystemColors.GrayText;
            this.dtpedad.Location = new System.Drawing.Point(408, 104);
            this.dtpedad.Name = "dtpedad";
            this.dtpedad.Size = new System.Drawing.Size(183, 20);
            this.dtpedad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(4, 184);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(111, 62);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(426, 181);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(111, 65);
            this.btnbuscar.TabIndex = 12;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dtgvCustomers
            // 
            this.dtgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgNombre,
            this.dtgApellido,
            this.dtgTelefono,
            this.dtgCedula,
            this.dtgEdad});
            this.dtgvCustomers.Location = new System.Drawing.Point(4, 337);
            this.dtgvCustomers.Name = "dtgvCustomers";
            this.dtgvCustomers.Size = new System.Drawing.Size(587, 203);
            this.dtgvCustomers.TabIndex = 14;
            // 
            // dtgNombre
            // 
            this.dtgNombre.HeaderText = "Nombre";
            this.dtgNombre.Name = "dtgNombre";
            // 
            // dtgApellido
            // 
            this.dtgApellido.HeaderText = "Apellido";
            this.dtgApellido.Name = "dtgApellido";
            // 
            // dtgTelefono
            // 
            this.dtgTelefono.HeaderText = "Telefono";
            this.dtgTelefono.Name = "dtgTelefono";
            // 
            // dtgCedula
            // 
            this.dtgCedula.HeaderText = "Cedula";
            this.dtgCedula.Name = "dtgCedula";
            // 
            // dtgEdad
            // 
            this.dtgEdad.HeaderText = "Edad";
            this.dtgEdad.Name = "dtgEdad";
            // 
            // btnbuscardb
            // 
            this.btnbuscardb.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnbuscardb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscardb.Location = new System.Drawing.Point(283, 182);
            this.btnbuscardb.Name = "btnbuscardb";
            this.btnbuscardb.Size = new System.Drawing.Size(111, 65);
            this.btnbuscardb.TabIndex = 15;
            this.btnbuscardb.Text = "BuscarDB";
            this.btnbuscardb.UseVisualStyleBackColor = false;
            this.btnbuscardb.Click += new System.EventHandler(this.btnbuscardb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(591, 552);
            this.Controls.Add(this.btnbuscardb);
            this.Controls.Add(this.dtgvCustomers);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpedad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarDB);
            this.Controls.Add(this.txtnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnGuardarDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.DateTimePicker dtpedad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dtgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgEdad;
        private System.Windows.Forms.Button btnbuscardb;
    }
}

