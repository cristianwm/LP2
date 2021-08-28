using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRaio.Clear();
            txtVolume.Clear();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, raio;

            if ((double.TryParse(txtAltura.Text, out altura)) &&
                (double.TryParse(txtRaio.Text, out raio)))
            {
                double volume;
                volume = Math.PI * Math.Pow(raio, 2) * altura;

                txtVolume.Text = volume.ToString("N2");
            }
            else
                MessageBox.Show("Valores inválidos");

        }
    }
}
