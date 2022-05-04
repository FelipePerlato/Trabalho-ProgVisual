using ControleEstoque1;
using System.Data.Entity;

namespace ControleEstoque
{
    public class Context: DbContext
    {
        public Context() : base("ControleEstoque")
        {
        }
        public DbSet<DtoUsuario> usuario { get; set; }
        public DbSet<DtoProduto> produto { get; set; }

        public DbSet<DtoPedido> pedido { get; set; }

        public DbSet<DtoEntrada> entrada { get; set; }   
    }
}
