using ControleEstoque1;
using System;
using System.Collections.Generic;

namespace ControleEstoque
{
    public partial class FrmEntrada : ControleEstoque.FrmBase
    {
        public FrmEntrada()
        {
            InitializeComponent();
            BloqueiaCampos();
        }
        private void BloqueiaCampos()
        {
            textBoxId.Enabled = false;
           
        }

        private void bntConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta c = new FrmConsulta();
            c.ShowDialog();
            if (c.idProduto!=0)
            {
                textBoxProduto.Text = c.idProduto.ToString();
                textBoxProduto.Focus();
            }
        }

        private void textBoxProduto_Leave(object sender, EventArgs e)
        {
            Model get = new Model();
            DtoProduto produto = get.GetProdutoEntradaId(int.Parse(textBoxProduto.Text));
            textBoxNomeProduto.Text = produto.nome;
        }

        private void textBoxUnitario_Leave(object sender, EventArgs e)
        {
           
            decimal total = decimal.Parse(textBoxQuantidade.Text) * decimal.Parse(textBoxUnitario.Text);
            textBoxTotal.Text = total.ToString();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            LiberarCampos();
            textBoxQuantidade.Focus();

        }
          private void LiberarCampos()
        {
            textBoxTotal.Enabled = true;
            textBoxQuantidade.Enabled = true;
            textBoxUnitario.Enabled = true;
            textBoxProduto.Enabled=true;
            textBoxNomeProduto.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Model set = new Model();
            DtoEntrada p = new DtoEntrada();
            p.produtoid=textBoxProduto.Text;
            p.nomeproduto=textBoxNomeProduto.Text;
            p.valorunitario = decimal.Parse(textBoxUnitario.Text);
            p.valortotal = decimal.Parse(textBoxTotal.Text);
            p.quantidade = decimal.Parse(textBoxQuantidade.Text);
            p.datacompra = DateTime.Now;

          
            
                set.SetEntradaproduto(p);
            
            BloqueiaCampos();
            
        }
    }
}
