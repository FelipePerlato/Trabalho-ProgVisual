using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    public class DtoPedido2
    {
        public int id { get; set; }

        public int idproduto { get; set; }
        public string nomecliente { get; set; }
        public decimal valorpedido { get; set; }
        public decimal quantidadepedido { get; set; }
        public DateTime? datavenda { get; set; }
    }
}
