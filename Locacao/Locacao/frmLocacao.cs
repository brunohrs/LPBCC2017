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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


        private void HabilitaControlesLocacao(bool status)
        {
            dtpData.Enabled = status;
            txtCliente.Enabled = status;
            cmbCliente.Enabled = status;
            dgvLocacao.Enabled = !status;

            //botões
            btnInsLoc.Enabled = !status;
            btnUpdLoc.Enabled = !status;
            btnDelLoc.Enabled = !status;
            btnSaveLoc.Enabled = status;
            btnCancLoc.Enabled = status;
        }

        private void LimpaControlesLocacao()
        {
            lblLocID.Text = "";
            txtCliente.Text = "";
            dtpData.Value = DateTime.Now.Date;
        }

        private void HabilitaControlesItemLocacao(bool status)
        {
            txtProduto.Enabled = status;
            cmbProduto.Enabled = status;
            dtpEntrega.Enabled = status;
            txtValor.Enabled = status;
            txtDias.Enabled = status; 
            dgvItemLocacao.Enabled = !status;

            //botões
            btnInsIL.Enabled = !status;
            btnUpdIL.Enabled = !status;
            btnDelIL.Enabled = !status;
            btnSaveIL.Enabled = status;
            btnCanIL.Enabled = status;
        }

        private void LimpaControlesIL()
        {
            lblItmLocID.Text = "";
            txtProduto.Text = "";
            dtpEntrega.Value = DateTime.Now.Date; 
            txtValor.Text = "";
            txtDias.Text = ""; 
        }
        private void pnlLocacao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLocacao_Load(object sender, EventArgs e)
        {
            HabilitaControlesLocacao(false);
            HabilitaControlesItemLocacao(false);
            LimpaControlesLocacao();
            LimpaControlesIL();
            Camadas.BLL.Locacao bllLocacao = new Camadas.BLL.Locacao();
            Camadas.BLL.ItemLocacao bllItemLocacao = new Camadas.BLL.ItemLocacao();

            dgvLocacao.DataSource = bllLocacao.Select();

            dgvItemLocacao.DataSource = bllItemLocacao.Select();
        }

        private void btnInsLoc_Click(object sender, EventArgs e)
        {
            LimpaControlesLocacao();
            lblLocID.Text = "-1";
            HabilitaControlesLocacao(true);
            dtpData.Focus();
        }

        private void btnUpdLoc_Click(object sender, EventArgs e)
        {
            if (lblLocID.Text != string.Empty)
            {
                HabilitaControlesLocacao(true);
                dtpData.Focus();
            }
            else
            {
                string msg = "Não há Locação para edição...";
                MessageBox.Show(msg, "Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelLoc_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblLocID.Text != string.Empty)
            {
                msg = "Confirma Remoção de Locação " + lblLocID.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblLocID.Text);
                    Camadas.BLL.Locacao bllLocacao = new Camadas.BLL.Locacao();
                    Camadas.Model.Locacao locacao = new Camadas.Model.Locacao();
                    locacao.id = id;
                    // informar outros campos caso necessite no bll
                    bllLocacao.Delete(locacao);
                    dgvLocacao.DataSource = "";
                    dgvLocacao.DataSource = bllLocacao.Select();
                }
            }
            else
            {
                msg = "Não há Locação para remoção...";
                MessageBox.Show(msg, "Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpaControlesLocacao();
            HabilitaControlesLocacao(false);
        }

        private void btnSaveLoc_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Locacao bllLocacao = new Camadas.BLL.Locacao();
            Camadas.Model.Locacao locacao = new Camadas.Model.Locacao();
            int id = Convert.ToInt32(lblLocID.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão de Locação?";
            else msg = "Confirma Atualização de Locação?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                locacao.id = id;
                locacao.data = dtpData.Value;
                locacao.cliente = Convert.ToInt32(txtCliente.Text);
                if (id == -1)  //-1 indica inserir 
                    bllLocacao.Insert(locacao);
                else bllLocacao.Update(locacao);
            }
            dgvLocacao.DataSource = "";
            dgvLocacao.DataSource = bllLocacao.Select();  //atualiza a grid
            LimpaControlesLocacao(); //limpa campos
            HabilitaControlesLocacao(false);  //desabilita controles
        }

        private void btnCancLoc_Click(object sender, EventArgs e)
        {
           LimpaControlesLocacao();
           HabilitaControlesLocacao(false);
        }

        private void dgvLocacao_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLocacao.SelectedRows.Count > 0)
            {
                lblLocID.Text = dgvLocacao.SelectedRows[0].Cells["id"].Value.ToString();
                txtCliente.Text = dgvLocacao.SelectedRows[0].Cells["cliente"].Value.ToString();
                dtpData.Value = Convert.ToDateTime(dgvLocacao.SelectedRows[0].Cells["data"].Value.ToString());
            }
        }

        private void dgvItemLocacao_DoubleClick(object sender, EventArgs e)
        {
            if (dgvItemLocacao.SelectedRows.Count > 0)
            {
                lblItmLocID.Text = dgvItemLocacao.SelectedRows[0].Cells["id"].Value.ToString();
                txtProduto.Text = dgvItemLocacao.SelectedRows[0].Cells["produto"].Value.ToString();
                dtpEntrega.Value = Convert.ToDateTime(dgvItemLocacao.SelectedRows[0].Cells["entrega"].Value.ToString());
                txtValor.Text = dgvItemLocacao.SelectedRows[0].Cells["valor"].Value.ToString();
                txtDias.Text = dgvItemLocacao.SelectedRows[0].Cells["dias"].Value.ToString();
            }
        }

        private void dgvItemLocacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsIL_Click(object sender, EventArgs e)
        {
            
            if (lblLocID.Text!="" && lblLocID.Text!="-1")
            {
                LimpaControlesIL();
                lblItmLocID.Text = "-1";
                HabilitaControlesItemLocacao(true);
                txtProduto.Focus();
            }
        }

        private void btnUpdIL_Click(object sender, EventArgs e)
        {
            if (lblItmLocID.Text != string.Empty)
            {
                HabilitaControlesItemLocacao(true);
                txtProduto.Focus();
            }
            else
            {
                string msg = "Não há Itens Locação para edição...";
                MessageBox.Show(msg, "Itens Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelIL_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblItmLocID.Text != string.Empty)
            {
                msg = "Confirma Remoção de Itens de Locação " + lblItmLocID.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover Item Locação", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblItmLocID.Text);
                    Camadas.BLL.ItemLocacao bllItemLocacao = new Camadas.BLL.ItemLocacao();
                    Camadas.Model.ItemLocacao itemLocacao = new Camadas.Model.ItemLocacao();
                    itemLocacao.id = id;
                    // informar outros campos caso necessite no bll
                    bllItemLocacao.Delete(itemLocacao);
                    dgvItemLocacao.DataSource = "";
                    dgvItemLocacao.DataSource = bllItemLocacao.Select();
                }
            }
            else
            {
                msg = "Não há Item Locação para remoção...";
                MessageBox.Show(msg, "Item Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpaControlesLocacao();
            HabilitaControlesLocacao(false);
        }

        private void btnSaveIL_Click(object sender, EventArgs e)
        {
            Camadas.BLL.ItemLocacao bllItemLocacao = new Camadas.BLL.ItemLocacao();
            Camadas.Model.ItemLocacao itemLocacao = new Camadas.Model.ItemLocacao();
            int id = Convert.ToInt32(lblItmLocID.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão de Item de Locação?";
            else msg = "Confirma Atualização de Item de Locação?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar Item de Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                itemLocacao.id = id;
                itemLocacao.locacao = Convert.ToInt32(lblLocID.Text);
                itemLocacao.produto = Convert.ToInt32(txtProduto.Text);
                itemLocacao.entrega = dtpEntrega.Value;
                itemLocacao.valor = Convert.ToSingle(txtValor.Text);
                itemLocacao.dias = Convert.ToInt32(txtDias.Text);

                if (id == -1)  //-1 indica inserir 
                    bllItemLocacao.Insert(itemLocacao);
                else bllItemLocacao.Update(itemLocacao);
            }
            dgvItemLocacao.DataSource = "";
            dgvItemLocacao.DataSource = bllItemLocacao.Select();  //atualiza a grid
            LimpaControlesIL(); //limpa campos
            HabilitaControlesItemLocacao(false);  //desabilita controles
        }
    }
}
