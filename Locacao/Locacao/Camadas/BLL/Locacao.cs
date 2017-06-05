using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Camadas.BLL
{
    public class Locacao
    {
        public List<Model.Locacao> Select()
        {
            DAL.Locacao dalLoc = new DAL.Locacao();
            return dalLoc.Select(); 
        }

        public List<Model.Locacao> SelectById(int id)
        {
            DAL.Locacao dalLoc = new DAL.Locacao();
            return dalLoc.SelectById(id);
           
        }

        public List<Model.Locacao> SelectByCliente(int cliente)
        {
            DAL.Locacao dalLoc = new DAL.Locacao();
            return dalLoc.SelectByCliente(cliente);
        }


        public void Insert(Model.Locacao Locacao)
        {
            DAL.Locacao dalLoc = new DAL.Locacao();
            //regras de negócio caso existam
            dalLoc.Insert(Locacao);
        }

        public void Update(Model.Locacao Locacao)
        {
            DAL.Locacao dalLoc = new DAL.Locacao();
            dalLoc.Update(Locacao); 
        }

        public void Delete(Model.Locacao Locacao)
        {
            DAL.Locacao dalLoc = new DAL.Locacao();
            dalLoc.Delete(Locacao);  
        }

    }
}
