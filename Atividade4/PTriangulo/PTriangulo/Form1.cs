using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;

            if ((double.TryParse(txtA.Text, out ladoA)) &&
                (double.TryParse(txtB.Text, out ladoB)) &&
                (double.TryParse(txtC.Text, out ladoC)))

                if (ladoA > Math.Abs(ladoB - ladoC) && ladoA < (ladoB + ladoC) && ladoB > Math.Abs(ladoA - ladoC) && ladoB < (ladoA + ladoC) && ladoC > Math.Abs(ladoA - ladoB) && ladoC < (ladoA + ladoB))
                    {
                    if (ladoA == ladoB && ladoB == ladoC)
                        txtTriangulo.Text = "Equilátero";
                    else if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
                        txtTriangulo.Text = "Escaleno";
                    else
                        txtTriangulo.Text = "Isósceles";
                    }
                else
                    MessageBox.Show("Números inválidos");
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtTriangulo.Clear();
        }
    }
}
