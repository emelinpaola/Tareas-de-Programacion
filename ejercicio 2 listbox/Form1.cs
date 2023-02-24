using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adicionar elementos 
            lstfrutas.Items.Add("Banana");
            lstfrutas.Items.Add("Durazno");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lstfrutas.Items.Add(txtfruta.Text);

            txtfruta.Text = String.Empty;


        }

        private void lstfrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstfrutas.SelectedIndex ! =-1)
           lblfruta.Text = (string)lstfrutas.Items[Istfrutas.SelectedIndex];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = lstfrutas.SelectedIndex;

            if (indice ! = -1)
            {
                lstfrutas.Items.RemoveAt(indice);
            }
        }
    }
}
