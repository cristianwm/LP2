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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio3 FRM3 = new FrmExercicio3();
            FRM3.MdiParent = this;
            FRM3.WindowState = FormWindowState.Maximized;
            FRM3.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio2 FRM2 = new FrmExercicio2();
            FRM2.MdiParent = this;
            FRM2.WindowState = FormWindowState.Maximized;
            FRM2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio4 FRM4 = new FrmExercicio4();
            FRM4.MdiParent = this;
            FRM4.WindowState = FormWindowState.Maximized;
            FRM4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio5 FRM5 = new FrmExercicio5();
            FRM5.MdiParent = this;
            FRM5.WindowState = FormWindowState.Maximized;
            FRM5.Show();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou o menu copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou o menu colar");
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
