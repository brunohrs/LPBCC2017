using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Camadas.BLL
{
    public class ItemLocacao
    {
        public List<Model.ItemLocacao> Select()
        {
            DAL.ItemLocacao dalItmLoc = new DAL.ItemLocacao();
            //regras de negócio caso existam
            return dalItmLoc.Select(); 
        }

        public List<Model.ItemLocacao> SelectById(int id)
        {
            DAL.ItemLocacao dalItmLoc = new DAL.ItemLocacao();
            //regras de negócio caso existam
            return dalItmLoc.SelectById(id);
           
        }

        public List<Model.ItemLocacao> SelectByLocacao(int locacao)
        {
            DAL.ItemLocacao dalItmLoc = new DAL.ItemLocacao();
            //regras de negócio caso existam
            return dalItmLoc.SelectByLocacao (locacao);
        }


        public void Insert(Model.ItemLocacao ItemLocacao)
        {
            DAL.ItemLocacao dalItmLoc = new DAL.ItemLocacao();
            //regras de negócio caso existam
            dalItmLoc.Insert(ItemLocacao);
        }

        public void Update(Model.ItemLocacao ItemLocacao)
        {
            DAL.ItemLocacao dalItmLoc = new DAL.ItemLocacao();
            dalItmLoc.Update(ItemLocacao); 
        }

        public void Delete(Model.ItemLocacao ItemLocacao)
        {
            DAL.ItemLocacao dalItmLoc = new DAL.ItemLocacao();
            dalItmLoc.Delete(ItemLocacao);  
        }

        public void Baixa(Model.ItemLocacao ItemLocacao)
        {
            DAL.ItemLocacao dalItmLoc = new DAL.ItemLocacao();
            //atualização da tabela produto para gravar L  de Livre
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            //recupera produto
            Model.Produto produto = new Model.Produto();
            List<Model.Produto> lstProd = new List<Model.Produto>();
            lstProd = bllProd.SelectById(ItemLocacao.produto);
            produto = lstProd[0];
            //muda status produto
            produto.status = 'L';

            //atualiza produto
            bllProd.Update(produto);

            //gravar item locacao
            dalItmLoc.Update(ItemLocacao);

        }

    }
}
