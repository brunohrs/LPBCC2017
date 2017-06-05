using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locacao
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(); 
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.MdiParent = this; 
            frmCli.Show();
            tsstLabel.Text = "Cliente"; 
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frmPro = new frmProduto();
            frmPro.MdiParent = this;
            frmPro.Show();
            tsstLabel.Text = "Produtos"; 
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSb = new frmSobre();
            frmSb.ShowDialog(); 
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsstlabelHora.Text = DateTime.Now.ToString(); 
        }

        private void locacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao frmLoc = new frmLocacao();
            frmLoc.MdiParent = this;
            frmLoc.Show(); 

        }
    }
}
