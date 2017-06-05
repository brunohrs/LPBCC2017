using System;
using System.Collections.Generic;
using System.Data; 
using System.Data.SqlClient; 

namespace Locacao.Camadas.DAL
{
    public class Locacao
    {
        private string strCon = Conexao.getConexao(); 

        public List<Model.Locacao> Select()
        {
            List<Model.Locacao> lstLocacao = new List<Model.Locacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select locacao.id, locacao.data, locacao.cliente, cliente.nome from Locacao inner join cliente on cliente.id=locacao.cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {               
                    //instanciando objeto Locacao     
                    Model.Locacao Locacao = new Model.Locacao(); 
                    //carregar os dado no objeto Locacao -- popular objeto
                    Locacao.id = Convert.ToInt32(reader["id"]);
                    Locacao.cliente = Convert.ToInt32(reader["cliente"]);
                    Locacao.data = Convert.ToDateTime(reader["data"].ToString());
                    Locacao.nome = reader["nome"].ToString();
                    lstLocacao.Add(Locacao); 
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Locacao....;"); 
            }
            finally
            {
                conexao.Close(); 
            }
            return lstLocacao; 
        }


        public List<Model.Locacao> SelectById(int id)
        {
            List<Model.Locacao> lstLocacao = new List<Model.Locacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Locacao where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id); 
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Locacao     
                    Model.Locacao Locacao = new Model.Locacao();
                    //carregar os dado no objeto Locacao -- popular objeto
                    Locacao.id = Convert.ToInt32(reader["id"]);
                    Locacao.cliente = Convert.ToInt32(reader["cliente"]);
                    Locacao.data = Convert.ToDateTime(reader["data"].ToString());
                    lstLocacao.Add(Locacao);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Locacao....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstLocacao;
        }


        public List<Model.Locacao> SelectByCliente(int cliente)
        {
            List<Model.Locacao> lstLocacao = new List<Model.Locacao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Locacao where cliente=@cliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cliente", cliente);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Locacao     
                    Model.Locacao Locacao = new Model.Locacao();
                    //carregar os dado no objeto Locacao -- popular objeto
                    Locacao.id = Convert.ToInt32(reader["id"]);
                    Locacao.cliente = Convert.ToInt32(reader["cliente"]);
                    Locacao.data = Convert.ToDateTime(reader["data"].ToString());
                    lstLocacao.Add(Locacao);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Locacao....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstLocacao;
        }


        public void Insert(Model.Locacao Locacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Locacao values ";
            sql = sql + " (@data, @cliente);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@data", Locacao.data);
            cmd.Parameters.AddWithValue("@cliente", Locacao.cliente);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Locacao..."); 
            }
            finally
            {
                conexao.Close(); 
            }
        }

        public void Update(Model.Locacao Locacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Locacao set data=@data, cliente=@cliente ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@data", Locacao.data);
            cmd.Parameters.AddWithValue("@cliente", Locacao.cliente);
            cmd.Parameters.AddWithValue("@id", Locacao.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Locacao...");
            }
            finally
            {
                conexao.Close(); 
            }
        }

        public void  Delete (Model.Locacao Locacao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Locacao where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", Locacao.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Deu erro remocao Locacao"); 
            }
            finally
            {
                conexao.Close(); 
            }
        }    
    }
}
