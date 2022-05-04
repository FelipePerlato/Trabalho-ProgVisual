using ControleEstoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Context = ControleEstoque.Context;

namespace ControleEstoque1
{
    public class modelproduto
    {
       

        public List<DtoProduto2> ListProdutosNome(string text)
        {
            Context db = new Context();
            List<DtoProduto2> result = (from a in db.produto
                                        where a.nome.Contains(text)
                                        select new DtoProduto2
                                        {
                                            id = a.id,
                                            nome = a.nome,
                                            quantidade = a.quantidade
                                        }).ToList();

            return result;
        }

       
        public List<DtoProduto2> ListProdutos()
        {
            Context db = new Context();
            List<DtoProduto2> result = (from a in db.produto
                                        select new DtoProduto2
                                        {
                                            id = a.id,
                                            nome = a.nome,
                                            valorCusto = a.valorcusto,
                                            valorVenda = a.valorvenda,
                                            quantidade = a.quantidade
                                        }).ToList();

            return new List<DtoProduto2>(result);
        }

        internal void SetProduto(DtoProduto p)
        {
            Context db = new Context();

            db.produto.Add(p);
            db.SaveChanges();
        }

        internal void EditProduto(DtoProduto p)
        {
            Context db = new Context();
            DtoProduto e = db.produto.FirstOrDefault(pr => pr.id == p.id);
            e.nome = p.nome;
            e.valorcusto = p.valorcusto;
            e.valorvenda = p.valorvenda;
            e.quantidade = p.quantidade;

            db.SaveChanges();
        }

        public void DeletarProduto(int id)
        {
            Context db = new Context();
            DtoProduto p = db.produto.FirstOrDefault(prod => prod.id == id);
            db.produto.Remove(p);
            db.SaveChanges();

        }

        public DtoProduto2 GetProdutoId(int id)
        {
            Context db = new Context();
            var result1 = (from p in db.produto
                           where p.id == id
                           select new DtoProduto2
                           {
                               id = p.id,
                               nome = p.nome
                           }).FirstOrDefault();
            var result2 = db.produto.Where(p => p.id == id).FirstOrDefault();
            return result1;
        }
    }
}
