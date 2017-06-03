using System;
using System.Collections.Generic;
using System.Data; 
using System.Data.SqlClient; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Camadas.DAL
{
    public class Produto
    {
        private string strCon = Conexao.getConexao(); 

        public List<Model.Produto> Select()
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {               
                    //instanciando objeto Produto     
                    Model.Produto Produto = new Model.Produto(); 
                    //carregar os dado no objeto Produto -- popular objeto
                    Produto.id = Convert.ToInt32(reader["id"]);
                    Produto.descricao = reader["descricao"].ToString();
                    Produto.valor = Convert.ToSingle(reader["valor"].ToString());
                    Produto.status = Convert.ToChar(reader["status"].ToString());
                    lstProduto.Add(Produto); 
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto....;"); 
            }
            finally
            {
                conexao.Close(); 
            }
            return lstProduto; 
        }

        public List<Model.Produto> SelectById(int id)
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Produto     
                    Model.Produto Produto = new Model.Produto();
                    //carregar os dado no objeto Produto -- popular objeto
                    Produto.id = Convert.ToInt32(reader["id"]);
                    Produto.descricao = reader["descricao"].ToString();
                    Produto.valor = Convert.ToSingle(reader["valor"].ToString());
                    Produto.status = Convert.ToChar(reader["status"].ToString());
                    lstProduto.Add(Produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }

        public List<Model.Produto> SelectByDescricao(string desc)
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto where (descricao like @desc);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@desc", "%" + desc +"%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Produto     
                    Model.Produto Produto = new Model.Produto();
                    //carregar os dado no objeto Produto -- popular objeto
                    Produto.id = Convert.ToInt32(reader["id"]);
                    Produto.descricao = reader["descricao"].ToString();
                    Produto.valor = Convert.ToSingle(reader["valor"].ToString());
                    Produto.status = Convert.ToChar(reader["status"].ToString());
                    lstProduto.Add(Produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }


        public void Insert(Model.Produto Produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Produto values ";
            sql = sql + " (@descricao, @valor, @status);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", Produto.descricao);
            cmd.Parameters.AddWithValue("@valor", Produto.valor);
            cmd.Parameters.AddWithValue("@status", Produto.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Produto..."); 
            }
            finally
            {
                conexao.Close(); 
            }
        }

        public void Update(Model.Produto Produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set descricao=@descricao, valor=@valor, status=@status ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", Produto.descricao);
            cmd.Parameters.AddWithValue("@valor", Produto.valor);
            cmd.Parameters.AddWithValue("@status", Produto.status);
            cmd.Parameters.AddWithValue("@id", Produto.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Produtos...");
            }
            finally
            {
                conexao.Close(); 
            }
        }

        public void  Delete (Model.Produto Produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Produto where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", Produto.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Deu erro remocao Produto"); 
            }
            finally
            {
                conexao.Close(); 
            }
        }
    }
}
