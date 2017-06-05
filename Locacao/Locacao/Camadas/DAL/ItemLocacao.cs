using System;
using System.Collections.Generic;
using System.Data; 
using System.Data.SqlClient; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Camadas.DAL
{
    public class ItemLocacao
    {
        private string strCon = Conexao.getConexao(); 

        public List<Model.ItemLocacao> Select()
        {
            List<Model.ItemLocacao> lstItemLocacao = new List<Model.ItemLocacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from ItemLocacao;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {               
                    //instanciando objeto ItemLocacao     
                    Model.ItemLocacao ItemLocacao = new Model.ItemLocacao(); 
                    //carregar os dado no objeto ItemLocacao -- popular objeto
                    ItemLocacao.id = Convert.ToInt32(reader["id"]);
                    ItemLocacao.locacao = Convert.ToInt32(reader["locacao"]);
                    ItemLocacao.produto = Convert.ToInt32(reader["produto"]);
                    ItemLocacao.entrega = Convert.ToDateTime(reader["entrega"].ToString());
                    ItemLocacao.valor = Convert.ToSingle(reader["valor"].ToString());
                    ItemLocacao.dias = Convert.ToInt32(reader["dias"].ToString());
                    lstItemLocacao.Add(ItemLocacao); 
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Locacao....;"); 
            }
            finally
            {
                conexao.Close(); 
            }
            return lstItemLocacao; 
        }


        public List<Model.ItemLocacao> SelectById(int id)
        {
            List<Model.ItemLocacao> lstItemLocacao = new List<Model.ItemLocacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from ItemLocacao where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id); 
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto ItemLocacao     
                    Model.ItemLocacao ItemLocacao = new Model.ItemLocacao();
                    //carregar os dado no objeto ItemLocacao -- popular objeto
                    ItemLocacao.id = Convert.ToInt32(reader["id"]);
                    ItemLocacao.locacao = Convert.ToInt32(reader["locacao"]);
                    ItemLocacao.produto = Convert.ToInt32(reader["produto"]);
                    ItemLocacao.entrega = Convert.ToDateTime(reader["entrega"].ToString());
                    ItemLocacao.valor = Convert.ToSingle(reader["valor"].ToString());
                    ItemLocacao.dias = Convert.ToInt32(reader["dias"].ToString());
                    lstItemLocacao.Add(ItemLocacao);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Locacao por id....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstItemLocacao;
        }


        public List<Model.ItemLocacao> SelectByLocacao(int locacao)
        {
            List<Model.ItemLocacao> lstItemLocacao = new List<Model.ItemLocacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from ItemLocacao where locacao=@locacao;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@locacao", locacao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto ItemLocacao     
                    Model.ItemLocacao ItemLocacao = new Model.ItemLocacao();
                    //carregar os dado no objeto ItemLocacao -- popular objeto
                    ItemLocacao.id = Convert.ToInt32(reader["id"]);
                    ItemLocacao.locacao = Convert.ToInt32(reader["locacao"]);
                    ItemLocacao.produto = Convert.ToInt32(reader["produto"]);
                    ItemLocacao.entrega = Convert.ToDateTime(reader["entrega"].ToString());
                    ItemLocacao.valor = Convert.ToSingle(reader["valor"].ToString());
                    ItemLocacao.dias = Convert.ToInt32(reader["dias"].ToString());
                    lstItemLocacao.Add(ItemLocacao);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Locacao por locacao....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstItemLocacao;
        }


        public void Insert(Model.ItemLocacao ItemLocacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into ItemLocacao values ";
            sql = sql + " (@locacao ,@produto, @entrega, @valor, @dias);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@locacao", ItemLocacao.locacao);
            cmd.Parameters.AddWithValue("@produto", ItemLocacao.produto);
            cmd.Parameters.AddWithValue("@entrega", ItemLocacao.entrega);
            cmd.Parameters.AddWithValue("@valor", ItemLocacao.valor);
            cmd.Parameters.AddWithValue("@dias", ItemLocacao.dias);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Item Locacao..."); 
            }
            finally
            {
                conexao.Close(); 
            }
        }

        public void Update(Model.ItemLocacao ItemLocacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update ItemLocacao set locacao=@locacao, produto=@produto, ";
            sql += "entrega=@entrega, valor=@valor, dias=@dias ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@locacao", ItemLocacao.locacao);
            cmd.Parameters.AddWithValue("@produto", ItemLocacao.produto);
            cmd.Parameters.AddWithValue("@entrega", ItemLocacao.entrega);
            cmd.Parameters.AddWithValue("@valor", ItemLocacao.valor);
            cmd.Parameters.AddWithValue("@dias", ItemLocacao.dias);
            cmd.Parameters.AddWithValue("@id", ItemLocacao.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Item Locacao...");
            }
            finally
            {
                conexao.Close(); 
            }
        }

        public void  Delete (Model.ItemLocacao ItemLocacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from ItemLocacao where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", ItemLocacao.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Deu erro remocao Item Locacao"); 
            }
            finally
            {
                conexao.Close(); 
            }
        }



         
    }
}
