using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_proyect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAlimentos.Items.Add("lechuga");
            cmbAlimentos.Items.Add("leche");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cmbAlimentos.Items.Add(txtAlimentos.Text);

            int indice = cmbAlimentos.SelectedIndex;

            lblIndice.Text = indice.ToString();

            lbltexto.Text = cmbAlimentos.Items[indice].ToString();
        }
    }
}
