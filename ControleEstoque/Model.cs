using ControleEstoque1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace ControleEstoque
{
    public class Model
    {
       
        public void SetUsuario(DtoUsuario u)
        {
            Context db = new Context();

            db.usuario.Add(u);
            db.SaveChanges();
        }
        public void SetSaida(DtoPedido p )
        {
            Context db = new Context();

            db.pedido.Add(p);
            db.SaveChanges();
        }
        public void EditUsuario(DtoUsuario u)
        {
            Context db = new Context();
            DtoUsuario e = db.usuario.FirstOrDefault(p => p.id == u.id);
            e.nome = u.nome;
            e.login = u.login;
            e.senha = u.senha;
            
            db.SaveChanges();
        }

      
        public List<DtoUsuario2> ListUsuarios()
        {
            Context db = new Context();
            List<DtoUsuario2> result = (from a in db.usuario
                                  select new DtoUsuario2
                                  {
                                      id = a.id,
                                      nome = a.nome
                                  }).ToList();

            return new List<DtoUsuario2>(result);
        }
      
        internal void EditSaidaProd(DtoProduto p)
        {
            Context db = new Context();
            DtoProduto e = db.produto.FirstOrDefault(pr => pr.id == p.id);
            
            e.quantidade = p.quantidade;

            db.SaveChanges();
        }

        public DtoUsuario2 GetUsuarioId(int id)
        {
            Context db = new Context();
            var result = (from a in db.usuario
                             where a.id == id
                                   select new DtoUsuario2
                                   {
                                       id = a.id,
                                       nome = a.nome
                                   }).FirstOrDefault();

            var result1 = db.usuario.Where(p => p.id == id).FirstOrDefault();

            return result;
        }
       
        public void DeletarUsuario(int id)
        {
            Context db = new Context();
            DtoUsuario u = db.usuario.FirstOrDefault(p => p.id == id);
            db.usuario.Remove(u);
            db.SaveChanges();
        }

       

        public DtoPedido2 GetPedidoId(int id)
        {
            Context db = new Context();
            var result1 = (from p in db.pedido
                           where p.id == id
                           select new DtoPedido2
                           {
                               id = p.id,
                               idproduto=p.idproduto,
                               nomecliente = p.nomecliente,
                               valorpedido = p.valorpedido,
                               quantidadepedido=p.quantidadepedido
                           }).FirstOrDefault();
            var result2 = db.pedido.Where(p => p.id == id).FirstOrDefault();
            return result1;
        }
        public List<DtoPedido2> ListPedidos()
        {
            Context db = new Context();
            List<DtoPedido2> result = (from p in db.pedido
                                        select new DtoPedido2
                                        {
                                            id = p.id,
                                            idproduto=p.idproduto,
                                            nomecliente = p.nomecliente,
                                            quantidadepedido =p.quantidadepedido,
                                            valorpedido=p.valorpedido
                                        }).ToList();

            return new List<DtoPedido2>(result);
        }
        public DtoProduto GetProdutoEntradaId(int id)
        {
            Context db = new Context();
            DtoProduto e = db.produto.FirstOrDefault(p => p.id == id);
            return e;
        }

        public void SetEntradaproduto(DtoEntrada u)
        {
            Context db = new Context();

            db.entrada.Add(u);
            db.SaveChanges();
        }
    }
}
