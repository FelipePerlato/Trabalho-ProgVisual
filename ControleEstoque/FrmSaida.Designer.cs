namespace ControleEstoque1
{
    partial class FrmSaida
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdProduto = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_QteVen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_VlrTotal = new System.Windows.Forms.TextBox();
            this.dataGridViewSaida = new System.Windows.Forms.DataGridView();
            this.bntConsulta = new System.Windows.Forms.Button();
            this.txt_NomeProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_VlrProd = new System.Windows.Forms.TextBox();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IdPedido = new System.Windows.Forms.TextBox();
            this.txt_IdProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_EstAtu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNovo
            // 
            this.bntNovo.FlatAppearance.BorderSize = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produto";
            // 
            // txt_IdProduto
            // 
            this.txt_IdProduto.Location = new System.Drawing.Point(11, 144);
            this.txt_IdProduto.Name = "txt_IdProduto";
            this.txt_IdProduto.Size = new System.Drawing.Size(100, 20);
            this.txt_IdProduto.TabIndex = 3;
            this.txt_IdProduto.Leave += new System.EventHandler(this.textBoxIdproduto_leave);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(274, 312);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(115, 23);
            this.btn_Adicionar.TabIndex = 4;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qtd vendida";
            // 
            // txt_QteVen
            // 
            this.txt_QteVen.Location = new System.Drawing.Point(80, 285);
            this.txt_QteVen.Name = "txt_QteVen";
            this.txt_QteVen.Size = new System.Drawing.Size(116, 20);
            this.txt_QteVen.TabIndex = 6;
            this.txt_QteVen.Leave += new System.EventHandler(this.text_qtde_leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor total da venda";
            // 
            // txt_VlrTotal
            // 
            this.txt_VlrTotal.Location = new System.Drawing.Point(289, 271);
            this.txt_VlrTotal.Name = "txt_VlrTotal";
            this.txt_VlrTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_VlrTotal.TabIndex = 8;
            // 
            // dataGridViewSaida
            // 
            this.dataGridViewSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaida.Location = new System.Drawing.Point(395, 141);
            this.dataGridViewSaida.Name = "dataGridViewSaida";
            this.dataGridViewSaida.Size = new System.Drawing.Size(405, 150);
            this.dataGridViewSaida.TabIndex = 13;
            this.dataGridViewSaida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSaida_CellContentClick);
            // 
            // bntConsulta
            // 
            this.bntConsulta.Location = new System.Drawing.Point(345, 137);
            this.bntConsulta.Name = "bntConsulta";
            this.bntConsulta.Size = new System.Drawing.Size(29, 27);
            this.bntConsulta.TabIndex = 15;
            this.bntConsulta.Text = "...";
            this.bntConsulta.UseVisualStyleBackColor = true;
            this.bntConsulta.Click += new System.EventHandler(this.bntConsulta_Click);
            // 
            // txt_NomeProduto
            // 
            this.txt_NomeProduto.Location = new System.Drawing.Point(190, 141);
            this.txt_NomeProduto.Name = "txt_NomeProduto";
            this.txt_NomeProduto.Size = new System.Drawing.Size(139, 20);
            this.txt_NomeProduto.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor produto";
            // 
            // txt_VlrProd
            // 
            this.txt_VlrProd.Location = new System.Drawing.Point(234, 195);
            this.txt_VlrProd.Name = "txt_VlrProd";
            this.txt_VlrProd.Size = new System.Drawing.Size(100, 20);
            this.txt_VlrProd.TabIndex = 18;
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Location = new System.Drawing.Point(54, 246);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cliente.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "id";
            // 
            // txt_IdPedido
            // 
            this.txt_IdPedido.Location = new System.Drawing.Point(29, 179);
            this.txt_IdPedido.Name = "txt_IdPedido";
            this.txt_IdPedido.Size = new System.Drawing.Size(116, 20);
            this.txt_IdPedido.TabIndex = 19;
            // 
            // txt_IdProd
            // 
            this.txt_IdProd.Location = new System.Drawing.Point(71, 208);
            this.txt_IdProd.Name = "txt_IdProd";
            this.txt_IdProd.Size = new System.Drawing.Size(100, 20);
            this.txt_IdProd.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Id Produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Qtd Atualizada";
            // 
            // txt_EstAtu
            // 
            this.txt_EstAtu.Location = new System.Drawing.Point(86, 319);
            this.txt_EstAtu.Name = "txt_EstAtu";
            this.txt_EstAtu.Size = new System.Drawing.Size(116, 20);
            this.txt_EstAtu.TabIndex = 25;
            // 
            // FrmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_EstAtu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_IdProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Cliente);
            this.Controls.Add(this.txt_IdPedido);
            this.Controls.Add(this.txt_VlrProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NomeProduto);
            this.Controls.Add(this.bntConsulta);
            this.Controls.Add(this.dataGridViewSaida);
            this.Controls.Add(this.txt_VlrTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_QteVen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_IdProduto);
            this.Controls.Add(this.label1);
            this.Name = "FrmSaida";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_IdProduto, 0);
            this.Controls.SetChildIndex(this.btn_Adicionar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_QteVen, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_VlrTotal, 0);
            this.Controls.SetChildIndex(this.dataGridViewSaida, 0);
            this.Controls.SetChildIndex(this.bntConsulta, 0);
            this.Controls.SetChildIndex(this.txt_NomeProduto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txt_VlrProd, 0);
            this.Controls.SetChildIndex(this.txt_IdPedido, 0);
            this.Controls.SetChildIndex(this.Txt_Cliente, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txt_IdProd, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txt_EstAtu, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdProduto;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_QteVen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_VlrTotal;
        private System.Windows.Forms.DataGridView dataGridViewSaida;
        private System.Windows.Forms.Button bntConsulta;
        private System.Windows.Forms.TextBox txt_NomeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_VlrProd;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IdPedido;
        private System.Windows.Forms.TextBox txt_IdProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_EstAtu;
    }
}
