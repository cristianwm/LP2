using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResul.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            double Num1, Num2;

            if ((double.TryParse(txtNum1.Text, out Num1)) &&
                (double.TryParse(txtNum2.Text, out Num2))) 

            { double Resultado;
                Resultado = Num1 + Num2;

                txtResul.Text = Resultado.ToString("N2");
            }
            else
                MessageBox.Show("Valores inválidos");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            double Num1, Num2;

            if ((double.TryParse(txtNum1.Text, out Num1)) &&
                (double.TryParse(txtNum2.Text, out Num2)))

            {
                double Resultado;
                Resultado = Num1 - Num2;

                txtResul.Text = Resultado.ToString("N2");
            }
            else
                MessageBox.Show("Valores inválidos");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double Num1, Num2;

            if ((double.TryParse(txtNum1.Text, out Num1)) &&
                (double.TryParse(txtNum2.Text, out Num2)))

            {
                double Resultado;
                Resultado = Num1 * Num2;

                txtResul.Text = Resultado.ToString("N2");
            }
            else
                MessageBox.Show("Valores inválidos");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double Num1, Num2;


            if ((double.TryParse(txtNum1.Text, out Num1)) &&
                (double.TryParse(txtNum2.Text, out Num2)))

            if (Num2 != 0)
                {

                double Resultado;
                Resultado = Num1 / Num2;

                txtResul.Text = Resultado.ToString("N2");
            }
            else
                MessageBox.Show("Numero 2 inválido");
        }

        private void txtResul_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
