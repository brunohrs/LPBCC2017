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

        private void habilitaControles(bool status)
        {
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;

            txtNome.Enabled= status;
            txtEndereco.Enabled = status;
            txtCidade.Enabled = status;
            txtEstado.Enabled = status;
            txtFone.Enabled = status;

            dgvClientes.Enabled = !status; 
        }

        private void limpaControles()
        {
            lblId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = string.Empty;  // ""
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtFone.Text = "";
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            dgvClientes.DataSource = bllCli.Select();
            limpaControles(); 
            habilitaControles(false); 
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limpaControles();
            lblId.Text = "-1"; 
            habilitaControles(true);
            txtNome.Focus(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles(); 
            habilitaControles(false);
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            txtEstado.Text = txtEstado.Text.ToUpper(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != string.Empty)
            {
                habilitaControles(true);
                txtNome.Focus();
            }
            else {
                    string msg = "Não há registro selecionado para edição...";
                    MessageBox.Show(msg, "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
            int id = Convert.ToInt32(lblId.Text);

            string msg;
            if (id == -1)
                msg = "Confirma inserção dos dados?";
            else msg = "Confirma alteração dos dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1); 
            if (resp == DialogResult.Yes)
            {
                cliente.id = id;
                cliente.nome = txtNome.Text;
                cliente.endereco = txtEndereco.Text;
                cliente.cidade = txtCidade.Text;
                cliente.estado = txtEstado.Text;
                cliente.fone = txtFone.Text;

                if (id == -1)
                    bllCli.Insert(cliente);
                else bllCli.Update(cliente); 
            }
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCli.Select();
            limpaControles();
            habilitaControles(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente(); 
            string msg;
            if (lblId.Text!=string.Empty)
            {
                msg = "Deseja Remover o Cliente Selecionado?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    cliente.id = Convert.ToInt32(lblId.Text); 
                    bllCli.Delete(cliente);
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCli.Select();
            limpaControles();
            habilitaControles(false); 

        }
    }
}
