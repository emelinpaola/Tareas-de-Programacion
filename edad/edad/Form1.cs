using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime fechadelusuario = dtpNacimineto.Value;
            DateTime fechadehoy = DateTime.Now;
            int diferenciaenaños = (fechadehoy.Year - fechadelusuario.Year);
            if (fechadelusuario > fechadehoy.AddYears(-diferenciaenaños))
            {
                diferenciaenaños--;
            }
            txtresultado.Text = "Usted tiene " + diferenciaenaños.ToString() + " años";
        }
        void calcularDiferencia()
        {
            
        }
       
        
       private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
