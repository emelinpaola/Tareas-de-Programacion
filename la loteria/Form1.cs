using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace la_loteria
{
    public partial class Form1 : Form
    {
        Random NumeroAleatorio = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJuega_Click(object sender, EventArgs e)
        {
            int primera;
            int segunda;
            int tercera;
            int Numero;

            Numero = Convert.ToInt32(txtNumero.Text);
            primera = NumeroAleatorio.Next(0, 99);
            segunda = NumeroAleatorio.Next(0, 99);
            tercera = NumeroAleatorio.Next(0, 99);

            txtPrimera.Text = primera.ToString();
            txtSegunda.Text = segunda.ToString();
            txtTercera.Text = tercera.ToString();

            if (Numero == primera)
            {
                lblResultado.Text = "Te sacaste en Primera";
            }
            else if (Numero == segunda)
            {
                lblResultado.Text = "Te sacaste en Segunda";
            }
            else if (Numero == tercera)
            {
                lblResultado.Text = "Te sacaste en Tercera";
            }
            else
            {
                lblResultado.Text = "No te sacaste intenta de nuevo";
            }

        }
    }
}
