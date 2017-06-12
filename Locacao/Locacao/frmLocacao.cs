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
        Camadas.Model.Produto produto = new Camadas.Model.Produto(); 

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
            lblEntrega.Text = ""; 
            lblDias.Text = "";
            txtValor.Text = "";
            lblTotal.Text = "";
            lblStatus.Text = ""; 
        }
        private void pnlLocacao_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RecuperaDadosProduto()
        {
            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
            List<Camadas.Model.Produto> lstProd = new List<Camadas.Model.Produto>();
            lstProd = bllProduto.SelectById(Convert.ToInt32(txtProduto.Text));
            if (lstProd != null)
                produto = lstProd[0];
            else  MessageBox.Show("Produto não encontrado");
            if (produto.status != 'L') {
                MessageBox.Show("Produto não pode ser locado!! " + produto.status);
                cmbProduto.Focus();                
            }
            else
            {
                lblStatus.Text = produto.status.ToString();
                txtValor.Text = produto.valor.ToString(); 
            }

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

            //Carregamento de Combobox
            //Cliente
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id"; 
            cmbCliente.DataSource = bllCliente.Select();

            //Produto
            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
            cmbProduto.DisplayMember = "descricao";
            cmbProduto.ValueMember = "id";
            cmbProduto.DataSource = bllProduto.Select(); 

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
                cmbCliente.SelectedValue = Convert.ToInt32(txtCliente.Text); 
                dtpData.Value = Convert.ToDateTime(dgvLocacao.SelectedRows[0].Cells["data"].Value.ToString());

                //atualizar gridview itens locação
                Camadas.BLL.ItemLocacao bllItemLocacao = new Camadas.BLL.ItemLocacao();
                int locacao = Convert.ToInt32(lblLocID.Text);
                dgvItemLocacao.DataSource = ""; 
                dgvItemLocacao.DataSource = bllItemLocacao.SelectByLocacao(locacao);  

            }
        }

        private void dgvItemLocacao_DoubleClick(object sender, EventArgs e)
        {
            if (dgvItemLocacao.SelectedRows.Count > 0)
            {
                lblItmLocID.Text = dgvItemLocacao.SelectedRows[0].Cells["id"].Value.ToString();
                txtProduto.Text = dgvItemLocacao.SelectedRows[0].Cells["produto"].Value.ToString();
                lblEntrega.Text = dgvItemLocacao.SelectedRows[0].Cells["entrega"].Value.ToString();
                txtValor.Text = dgvItemLocacao.SelectedRows[0].Cells["valor"].Value.ToString();
                lblDias.Text = dgvItemLocacao.SelectedRows[0].Cells["dias"].Value.ToString();
                if (Convert.ToInt32(lblDias.Text) == 0)
                {
                    lblStatus.Text = "E";
                    btnILBaixa.Enabled = true;
                }
                else {
                    lblStatus.Text = "L";
                    btnILBaixa.Enabled = false;
                }
                float total = Convert.ToInt32(lblDias.Text) * Convert.ToSingle(txtValor.Text);
                lblTotal.Text = total.ToString(); 
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
                lblEntrega.Text = dtpData.Value.AddDays(1).ToString();
                lblDias.Text = "0";
                lblTotal.Text = "0";
                btnILBaixa.Enabled = false;
                cmbProduto.Focus();
            }
            else
            {
                string msg = "Não há locação selecionada!!!";
                MessageBox.Show(msg, "Itens Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                itemLocacao.entrega = Convert.ToDateTime(lblEntrega.Text);
                itemLocacao.valor = Convert.ToSingle(txtValor.Text);
                itemLocacao.dias = Convert.ToInt32(lblDias.Text);

                if (id == -1)  //-1 indica inserir 
                    bllItemLocacao.Insert(itemLocacao);
                else bllItemLocacao.Update(itemLocacao);
            }
            dgvItemLocacao.DataSource = "";
            dgvItemLocacao.DataSource = bllItemLocacao.SelectByLocacao(Convert.ToInt32(lblLocID.Text));  //atualiza a grid
            LimpaControlesIL(); //limpa campos
            HabilitaControlesItemLocacao(false);  //desabilita controles
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCliente.Text = cmbCliente.SelectedValue.ToString(); 
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtCliente.Text); 
            }
            catch 
            {
                string msg = "ID Cliente Inválido!!!";
                MessageBox.Show(msg, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCliente.Text = "";
                txtCliente.Focus(); 
            }
        }

        private void dgvLocacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCanIL_Click(object sender, EventArgs e)
        {
            LimpaControlesIL();
            HabilitaControlesItemLocacao(false);
            Camadas.BLL.ItemLocacao bllItemLocacao = new Camadas.BLL.ItemLocacao();
            dgvItemLocacao.DataSource = bllItemLocacao.SelectByLocacao(Convert.ToInt32(lblLocID.Text));  //atualiza a grid
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProduto.Text = cmbProduto.SelectedValue.ToString();
            RecuperaDadosProduto();
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbProduto.SelectedValue = Convert.ToInt32(txtProduto.Text);
                RecuperaDadosProduto();
                txtValor.Focus();
            }
            catch 
            {
                string msg="Não existe código do Produto selecionado";
                MessageBox.Show(msg, "Combo Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduto.Text = "";
                txtProduto.Focus();
            }
        }

        private void cmbProduto_Leave(object sender, EventArgs e)
        {
            RecuperaDadosProduto(); 
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnILBaixa_Click(object sender, EventArgs e)
        {
            Camadas.BLL.ItemLocacao bllItemLocacao = new Camadas.BLL.ItemLocacao();
            Camadas.Model.ItemLocacao itemLocacao = new Camadas.Model.ItemLocacao();
            int id = Convert.ToInt32(lblItmLocID.Text);

            string msg = "";
            if (id != -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Baixa de Item de Locação?";
           
            DialogResult resp;
            resp = MessageBox.Show(msg, "Baixa Item de Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                itemLocacao.id = id;
                itemLocacao.locacao = Convert.ToInt32(lblLocID.Text);
                itemLocacao.produto = Convert.ToInt32(txtProduto.Text);
                itemLocacao.entrega = DateTime.Now;
                
                itemLocacao.valor = Convert.ToSingle(txtValor.Text);

                TimeSpan date = DateTime.Now - dtpData.Value;
                int totalDias = date.Days;

                itemLocacao.dias = totalDias;

               bllItemLocacao.Baixa(itemLocacao);
            }
            dgvItemLocacao.DataSource = "";
            dgvItemLocacao.DataSource = bllItemLocacao.SelectByLocacao(Convert.ToInt32(lblLocID.Text));  //atualiza a grid
            LimpaControlesIL(); //limpa campos
            HabilitaControlesItemLocacao(false);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
