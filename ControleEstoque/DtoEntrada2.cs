using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    public  class DtoEntrada2
    {
        public int id { get; set; }
        public string produtoid { get; set; }
        public string nome { get; set; }
        public decimal? quantidade { get; set; }
        public decimal? valortotal { get; set; }
        public decimal? valorunitario { get; set; }
        public DateTime? datacompra { get; set; }
    }
}
