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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            dgvClientes.DataSource = bllCli.Select(); 

        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                lblId.Text = dgvClientes.SelectedRows[0].Cells["id"].Value.ToString();  
                txtNome.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
                txtEndereco.Text = dgvClientes.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtCidade.Text = dgvClientes.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtEstado.Text = dgvClientes.SelectedRows[0].Cells["estado"].Value.ToString();
                txtFone.Text = dgvClientes.SelectedRows[0].Cells["fone"].Value.ToString();
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
