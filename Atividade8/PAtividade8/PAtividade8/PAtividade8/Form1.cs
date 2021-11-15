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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio1 FRM1 = new FrmExercicio1();
            FRM1.MdiParent = this;
            FRM1.WindowState = FormWindowState.Maximized;
            FRM1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
