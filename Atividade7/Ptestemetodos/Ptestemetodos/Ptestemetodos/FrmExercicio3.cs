using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //a te ss r
            //casa fatec assessoria carro
            //csa fac aessoria caro
            //cs -- aeoria cao




            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            while (posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);
                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sorocaba
            char[] vetor = txtPalavra1.Text.ToCharArray();



            Array.Reverse(vetor);
            //abacoroS



            txtPalavra2.Text = "";



            foreach (char c in vetor)
                txtPalavra2.Text += c;



            // ou
            /*
            for (var x = 0; x < vetor.Length; x++)
            txtPalavra2.Text += vetor[x];
            */
        }
    }
}
