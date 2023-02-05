using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loteria1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num1;
            Random rnd = new Random();
            num1 = rnd.Next(1, 49);
            textBox1.Text = Convert.ToString(num1);


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int num2;
            Random rnd = new Random();
            num2 = rnd.Next(1, 49);
            textBox2.Text = Convert.ToString(num2);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int num3;
            Random rnd = new Random();
            num3 = rnd.Next(1, 49);
            textBox3.Text = Convert.ToString(num3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if
                (textBox4.Text == textBox1.Text)
            {
                textBox5.Text = "usted a ganado";
                Text = textBox4.Text;
            }



            textBox5.Text = "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if
            (textBox1.Text == textBox4.Text)

            {
                textBox5.Text = "usted a ganado 2000!";
                Text = textBox5.Text;
            }
            else if
            (textBox1.Text != textBox4.Text)
            {

                textBox5.Text = "usted a perdido";
                Text = textBox5.Text;
            }
            else if
            (textBox2.Text == textBox4.Text)

            {
                textBox5.Text = "usted a ganado 1000!";
                Text = textBox5.Text;
            }
            else if
            (textBox2.Text != textBox4.Text)
            {

                textBox5.Text = "usted a perdido";
                Text = textBox5.Text;
            }
            else if
            (textBox3.Text == textBox4.Text)

            {
                textBox5.Text = "usted a ganado 500 !";
                Text = textBox5.Text;
            }
            else if
           (textBox3.Text != textBox4.Text)
            {

                textBox5.Text = "usted a perdido";
                Text = textBox5.Text;
            }















        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}