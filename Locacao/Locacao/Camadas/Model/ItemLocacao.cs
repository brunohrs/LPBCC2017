using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Camadas.Model
{
    public class ItemLocacao
    {
        public int id { get; set; }
        public int locacao { get; set; }
        public int produto { get; set; }
        public DateTime entrega { get; set; }
        public float valor { get; set; }
        public int dias { get; set; }
    }
}
