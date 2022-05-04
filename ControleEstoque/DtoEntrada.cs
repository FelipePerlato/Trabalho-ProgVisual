using DocumentFormat.OpenXml.CustomXmlSchemaReferences;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    [Table("entrada", Schema = "public")]
    public  class DtoEntrada
    {
        [Key]
        public int id {get;set;}
        public string produtoid {get;set;}
        public string nomeproduto { get;set;}
        public decimal? quantidade {get;set;}    
        public decimal? valortotal {get;set;}
        public decimal? valorunitario {get;set;}    
        public DateTime? datacompra {get;set;}
    }
}
