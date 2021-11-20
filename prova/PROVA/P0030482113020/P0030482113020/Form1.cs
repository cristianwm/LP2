using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P0030482113020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double[] Semana = new double[4];
                double TotalMes = 0, Total = 0, seman = 0;
                int i, j;
                string auxiliar = "";
                double gambi = 0;



                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        auxiliar = Interaction.InputBox("Total vendido na " +
                         (j + 1) + "ª semana".ToString(), (i + 1) + "º mês");

                        if (!double.TryParse(auxiliar, out Semana[j]))

                        {
                            MessageBox.Show("Numero invalido,digite novamente!");
                            j--;

                        }
                        else
                        {
                            seman = Semana[j];
                            TotalMes += Semana[j];
                            gambi = TotalMes;



                        }

                        Total += seman;
                        lstbxDados.Items.Insert(0, "Total do mês " + (i + 1).ToString() + " Semana " + (j + 1).ToString() + " " + seman.ToString("C2"));


                    }


                    lstbxDados.Items.Insert(0, " " + "Total do mês " + " " + TotalMes.ToString("C2"));
                    lstbxDados.Items.Insert(0, "------------------------------------------------------");
                    TotalMes -= gambi;

                }



                lstbxDados.Items.Insert(0, ">> " + "Total geral " + " " + Total.ToString("C2"));
                lstbxDados.Items.Insert(0, "------------------------------------------------------");
            }
        }
    }
}
