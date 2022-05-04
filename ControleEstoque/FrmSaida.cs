using ControleEstoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque1
{
    public partial class FrmSaida : ControleEstoque.FrmBase
    {
        public FrmSaida()
        {
            InitializeComponent();
            BloqueiaCampos();
        }

      
        private void bntConsulta_Click(object sender, EventArgs e)
        {

            FrmConsulta c = new FrmConsulta();
            c.ShowDialog();
            if (c.idProduto != 0)
            {
                txt_IdProduto.Text = c.idProduto.ToString();
                txt_IdProduto.Focus();
                txt_QteVen.Focus();
                txt_VlrTotal.Focus();
            }
        }
        private void CarregarGrid()
        {
            Model get = new Model();
            List<DtoPedido2> lista = get.ListPedidos();
            this.dataGridViewSaida.DataSource = lista;
            this.dataGridViewSaida.Refresh();
        }
        private void BloqueiaCampos()
        {
            txt_IdProd.Enabled = false;
            txt_IdPedido.Enabled = false;
          
            
           
        }
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
           
                Model set = new Model();
                DtoPedido p = new DtoPedido();
                p.nomecliente = Txt_Cliente.Text;
                p.quantidadepedido = decimal.Parse(txt_QteVen.Text);
                p.valorpedido = decimal.Parse(txt_VlrTotal.Text);
                p.idproduto = int.Parse(txt_IdProd.Text);
                p.datavenda= DateTime.Now;
                set.SetSaida(p);
                
                CarregarGrid();
            Model set1 = new Model();
            DtoProduto pr = new DtoProduto();
            
            pr.quantidade = decimal.Parse(txt_EstAtu.Text);
            pr.id = p.idproduto;
           

                set1.EditSaidaProd(pr);
            
          
        }

     

        private void textBoxIdproduto_leave(object sender, EventArgs e)
        {
            Model get = new Model();
            DtoProduto produto = get.GetProdutoEntradaId(int.Parse(txt_IdProduto.Text));
            txt_IdProd.Text = produto.id.ToString();
            txt_NomeProduto.Text = produto.nome;
            txt_VlrProd.Text = produto.valorvenda.ToString(); 
            

        }

      
        private void text_qtde_leave(object sender, EventArgs e)
        {
            Model get = new Model();
            DtoProduto produto = get.GetProdutoEntradaId(int.Parse(txt_IdProduto.Text));
          
            decimal total = decimal.Parse(txt_QteVen.Text) * decimal.Parse(txt_VlrProd.Text);
            txt_VlrTotal.Text = total.ToString();
            decimal qtdeatu =(decimal) produto.quantidade - decimal.Parse(txt_QteVen.Text) ;
            txt_EstAtu.Text = qtdeatu.ToString();
           
        }

      

        private void dataGridViewSaida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (Int32)dataGridViewSaida.CurrentRow.Cells[0].Value;
            Model get = new Model();
            DtoPedido2 p = get.GetPedidoId(id);
            txt_IdPedido.Text = p.id.ToString();
            Txt_Cliente.Text = p.nomecliente.ToString();
            txt_QteVen.Text = p.quantidadepedido.ToString();
            txt_VlrTotal.Text = p.valorpedido.ToString();
            p.datavenda = DateTime.Now;
           
            Txt_Cliente.Focus();
            txt_VlrTotal.Focus();
            txt_QteVen.Focus();

        }

        

        }
    }
