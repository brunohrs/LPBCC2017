using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Camadas.DAL
{
    public class Conexao
    {
        public static String getConexao()
        {
            return @"Data Source=.\sqlexpress;Initial Catalog=LOCACAO;Integrated Security=True"; 
        }
    }
}
