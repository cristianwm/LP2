using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAINSS.Clear();
            txtAIRPF.Clear();
            txtINSS.Clear();
            txtIRPF.Clear();
            txtNome.Clear();
            txtSalFamilia.Clear();
            txtSalLiq.Clear();
            mskbxSalBruto.Clear();
            txtNumFilhos.Clear();

        }

        private void cbxNumFilhos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExe_Click(object sender, EventArgs e)
        {
                double INSS = 0;
                double IRPF = 0;
                double SalarioLiq = 0;
                double Salario = 0;
                double NumFilhos = 0;
                double SalarioF = 0;
               
                if (txtNome.Text == string.Empty)
                {
                MessageBox.Show("O nome do funcionário" + "\n" + "não pode ser vazio!");

                }


            if ((!double.TryParse(mskbxSalBruto.Text, out Salario)) ||
            (!double.TryParse(txtNumFilhos.Text, out NumFilhos)))
            {
                MessageBox.Show("O salário e o número de filhos deve ser números");
            }
            else
            {
                if (Salario <= 0)
                    MessageBox.Show("O salário bruto deve ser maior que 0");

                else
                {
                    if (Salario < 800.47)
                    {
                        INSS = Salario * 0.0765;
                        txtAINSS.Text = "7.65%";
                    }
                    else if (Salario >= 800.48 && Salario <= 1050.00)
                    {
                        INSS = Salario * 0.0865;
                        txtAINSS.Text = "8.65%";
                    }
                    else if (Salario >= 1050.01 && Salario <= 1400.77)
                    {
                        INSS = Salario * 0.09;
                        txtAINSS.Text = "9.00%";
                    }
                    else if (Salario >= 1400.78 && Salario <= 2801.56)
                    {
                        INSS = Salario * 0.11;
                        txtAINSS.Text = "11.00%";
                    }
                    else if (Salario > 2801.56)
                    {
                        INSS = 308.17;
                        txtAINSS.Text = "TETO";
                    }
                    txtINSS.Text = INSS.ToString("N2");


                    if (Salario < 1257.12)
                    {
                        IRPF = 0;
                        txtAIRPF.Text = "0.00%";
                    }
                    else if (Salario >= 1257.13 && Salario <= 2512.08)
                    {
                        IRPF = Salario * 0.15;
                        txtAIRPF.Text = "15.00%";
                    }
                    else if (Salario > 2512.08)
                    {
                        IRPF = Salario * 0.275;
                        txtAIRPF.Text = "27.50%";
                    }
                    txtIRPF.Text = IRPF.ToString("N2");


                    if (Salario <= 435.52)
                    {
                        SalarioF = NumFilhos * 22.33;
                    }
                    else if (Salario >= 435.53 && Salario <= 654.61)
                    {
                        SalarioF = NumFilhos * 15.74;
                    }
                    else if (Salario > 654.61)
                    {
                        SalarioF = 0;
                    }
                    txtSalFamilia.Text = SalarioF.ToString("N2");

                    SalarioLiq = Salario - INSS - IRPF + SalarioF;
                    txtSalLiq.Text = SalarioLiq.ToString("N2");

                }


                lblDados.Text = "Os descontos do salário";

                if (rbtnFem.Checked)
                    lblDados.Text = lblDados.Text + " da Sra ";
                else
                    lblDados.Text = lblDados.Text + " do Sr ";

                lblDados.Text = lblDados.Text + txtNome.Text;

                if (rbtnCasado.Checked)
                    lblDados.Text = lblDados.Text + " que é casado(a)";
                else
                    lblDados.Text = lblDados.Text + " que é solteiro(a)";

                lblDados.Text = lblDados.Text + " e que tem ";
                lblDados.Text = lblDados.Text + NumFilhos + " filhos(a) são:";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
