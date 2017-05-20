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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dataGridView1.DataSource = dalCli.Select(); 
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
                        
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.cidade = txtCidade.Text;
            cliente.estado = txtEstado.Text;
            cliente.fone = txtFone.Text;

            dalCli.Insert(cliente);
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = dalCli.Select(); 

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();

            cliente.id = Convert.ToInt32(txtId.Text); 
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.cidade = txtCidade.Text;
            cliente.estado = txtEstado.Text;
            cliente.fone = txtFone.Text;

            dalCli.Update(cliente);
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = dalCli.Select();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();

            cliente.id = Convert.ToInt32(txtId.Text);
      
            dalCli.Delete(cliente);
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = dalCli.Select();
        }
    }
}
