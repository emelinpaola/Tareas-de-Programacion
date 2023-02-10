using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double numero1 = 0, numero2 = 0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarnumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtresultado.Text == "0")
                txtresultado.Text = "";

            txtresultado.Text += boton.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtresultado.Text);

            if (operador == '+')
            {
                txtresultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (operador == '─')
            {
                txtresultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (operador == 'X')
            {
                txtresultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (operador == '∕')
            {
                if (txtresultado.Text != "0")
                {
                    txtresultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txtresultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length > 1)
            {
                txtresultado.Text = txtresultado.Text.Substring(0, txtresultado.Text.Length - 1);
            }
            else
            {
                txtresultado.Text = "0";
            }
        }

        private void btnborrartodo_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador = '\0';
            txtresultado.Text = "0";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (!txtresultado.Text.Contains("."))
            {
                txtresultado.Text += ".";
            }
        }

        private void btnsigno_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtresultado.Text);
            numero1 *= -1;
            txtresultado.Text = numero1.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "0";
        }

        private void clickoperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            numero1 = Convert.ToDouble(txtresultado.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '²')
            {
                numero1 = Math.Pow(numero1, 2);
                txtresultado.Text = numero1.ToString();
            }
            else if (operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                txtresultado.Text = numero1.ToString();
            }
            else
            {
                txtresultado.Text = "0";
            }
        }
    }
}