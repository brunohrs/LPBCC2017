using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace Locacao.Camadas.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Cliente> Select()
        {
            List<Model.Cliente> lstClientes = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();  //popular (preencher)objeto
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de clientes...");
            }
            finally
            {
                conexao.Close();
            }

            return lstClientes;
        }

        public void Insert (Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Cliente values ";
            sql +=  " (@nome, @endereco, @cidade, @estado, @fone);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@fone", cliente.fone);
            conexao.Open(); 
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Erro insercao de cliente..."); 
            }
            finally
            {
                conexao.Close();
            }

        }


        public void Update (Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set nome=@nome, endereco=@endereco, ";
            sql += " cidade=@cidade, estado=@estado, fone=@fone ";
            sql += " where id=@id;"; 
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id); 
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@fone", cliente.fone);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro insercao de cliente...");
            }
            finally
            {
                conexao.Close();
            }

        }


        public void Delete (Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cliente where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro insercao de cliente...");
            }
            finally
            {
                conexao.Close();
            }

        }



    }
}
