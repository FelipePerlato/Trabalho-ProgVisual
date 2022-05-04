using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ControleEstoque1
{
    [Table("pedido", Schema = "public")]
    public class DtoPedido

    {

        [Key]
        public int id { get; set; }
        public int idproduto {get;set;}
        public string nomecliente { get; set; }
        public decimal valorpedido { get; set;}
        public decimal quantidadepedido { get; set; }

        public DateTime? datavenda { get; set; }
    }
}
