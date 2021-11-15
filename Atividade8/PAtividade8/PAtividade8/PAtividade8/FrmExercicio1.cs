using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
        

                int i = 0;
                int caracBrancos = 0;

                char[] pPalavra = rchtLetras.Text.ToCharArray();


                for (i = 0; i < rchtLetras.Text.Length; i++)
                {
                    if (char.IsWhiteSpace(pPalavra[i]))
                    {
                        caracBrancos++;

                    }

                }

                MessageBox.Show("O total de espaços em brancos nesta frase é: "
                + caracBrancos.ToString());

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int caracR = 0;

            char[] pCaracter = rchtLetras.Text.ToCharArray();

            foreach (char r in pCaracter)
            {
                if (r == 'r')
                {
                    caracR++;
                }

            }
            MessageBox.Show("A quantidade de letras R na frase é: " + caracR.ToString());
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            int caracRepetido = 0;
            int i;

            for (i = 1; i < rchtLetras.Text.Length; i++)

            {
                if (rchtLetras.Text[i] == rchtLetras.Text[i - 1])
                {
                    caracRepetido++;
                }

            }

            MessageBox.Show("A quantidade de pares de letras repetidas na frase é: "
            + caracRepetido.ToString());
        }
    }
}
