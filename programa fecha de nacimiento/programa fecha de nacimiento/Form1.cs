using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_fecha_de_nacimiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Write("ingrese el año actual:");
            int año_actual = int.Parse(Console.ReadLine());
            Console.Write("ingrese su año de nacimiento:");
            int año_nacimiento = int.Parse(Console.ReadLine());
            int edad = año_actual - año_nacimiento;
            Console.Write("usted tiene" + edad + "años.");
            Console.ReadKey();



        }
    }
}
