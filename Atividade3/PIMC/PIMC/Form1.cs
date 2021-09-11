using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtClassificacao.Clear();
            txtIMC.Clear();
            txtObesidade.Clear();
            txtPeso.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Peso, Altura;

            if ((double.TryParse(txtAltura.Text, out Altura))&& 
                (double.TryParse(txtPeso.Text, out Peso)))

            if (Peso >0 && Altura >0)
                {
                    double IMC;
                    IMC = Peso / Math.Pow(Altura, 2);

                    txtIMC.Text = IMC.ToString("N1");

                    if (IMC < 18.5)
                    {
                        txtClassificacao.Text = "Magreza";
                        txtObesidade.Text = "0";
                    }
                    else if (IMC >= 18.5 && IMC <= 24.9)
                    {
                        txtClassificacao.Text = "Normal";
                        txtObesidade.Text = "0";
                    }
                    else if (IMC >= 25.0 && IMC <= 29.9)
                    {
                        txtClassificacao.Text = "Sobrepeso";
                        txtObesidade.Text = "I";
                    }
                    else if (IMC >= 30.0 && IMC <= 39.9)
                    {
                        txtClassificacao.Text = "Obesidade";
                        txtObesidade.Text = "II";
                    }
                    else if (IMC > 40.0)
                    {
                        txtClassificacao.Text = "Obesidade grave";
                        txtObesidade.Text = "III";
                    }

                }
                else
                MessageBox.Show("Números inválidos");


        }

        private void txtClassificacao_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
