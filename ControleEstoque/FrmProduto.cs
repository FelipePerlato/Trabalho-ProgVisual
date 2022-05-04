using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ControleEstoque1;

namespace ControleEstoque
{
    public partial class FrmProduto : ControleEstoque.FrmBase
    {
        public FrmProduto()
        {
            InitializeComponent();
            BloqueiaCampos();
            CarregarGrid();
        }

        private void BloqueiaCampos()
        {
            textBoxNome.Enabled = false;
            textBoxVlCusto.Enabled = false;
            textBoxVlVenda.Enabled = false;
            textBoxQte.Enabled = false;
        }

        private void CarregarGrid()
        {
            modelproduto get = new modelproduto();
            List<DtoProduto2> lista = get.ListProdutos();
            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                modelproduto set = new modelproduto();
                DtoProduto p = new DtoProduto();
                p.nome = textBoxNome.Text;
                p.valorcusto = decimal.Parse(textBoxVlCusto.Text);
                p.valorvenda = decimal.Parse(textBoxVlVenda.Text);
                p.quantidade = decimal.Parse(textBoxQte.Text);
                if (textBoxID.Text != string.Empty)
                {
                    p.id = int.Parse(textBoxID.Text);
                    set.EditProduto(p);
                }
                else
                {
                    set.SetProduto(p);
                }
                BloqueiaCampos();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            LiberarCampos();
            textBoxNome.Focus();

        }

        private void LiberarCampos()
        {
            textBoxNome.Enabled = true;
            textBoxVlCusto.Enabled = true;
            textBoxVlVenda.Enabled = true;
            textBoxQte.Enabled = true;
        }
     

     
     

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
          
            LiberarCampos();
            textBoxNome.Focus();
           
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (textBoxID.Text != string.Empty)
            {
                modelproduto del = new modelproduto();
                del.DeletarProduto(int.Parse(textBoxID.Text));
                BloqueiaCampos();
                CarregarGrid();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (Int32)dataGridView1.CurrentRow.Cells[0].Value;

            modelproduto get = new modelproduto();
            DtoProduto2 p = get.GetProdutoId(id);
            textBoxID.Text = p.id.ToString();
            textBoxNome.Text = p.nome.ToString();

            LiberarCampos();
            textBoxNome.Focus();
        }
    }
}
