using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BO;

namespace UIL
{
    public partial class Frm_Rel_ProdutoXFornecedor : Frm_Master
    {
        public Frm_Rel_ProdutoXFornecedor()
        {
            InitializeComponent();
            this.Text = Titulo_Tela("Relatório de Produtos X Fornecedor"); 
            //tb_final.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //tb_inicio.Text = "01/" + DateTime.Now.ToString("MM/yyyy");
            //tb_inicio.Select(); 
            
            FornecedorCollection fornecedor_todos_temp = new FornecedorCollection(true);
            FornecedorCollection fornecedor_todos = new FornecedorCollection();

            Fornecedor fornecedor_temp = new Fornecedor();
            fornecedor_temp.FOR_CODIGO = 0;
            fornecedor_temp.FOR_NOME = "Todos";
            fornecedor_todos.Add(fornecedor_temp);

            foreach (Fornecedor fornecedor in fornecedor_todos_temp)
            {
                fornecedor_todos.Add(fornecedor);
            }
            cb_fornecedor.DataSource = fornecedor_todos;
            cb_fornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_fornecedor.AutoCompleteSource = AutoCompleteSource.ListItems;

            ProdutoCollection produto_todos_temp = new ProdutoCollection(true);
            ProdutoCollection produto_todos = new ProdutoCollection();

            Produto produto_temp = new Produto();
            produto_temp.PRO_CODIGO = 0;
            produto_temp.PRO_NOME = "Todos";
            produto_todos.Add(produto_temp);

            foreach (Produto produto in produto_todos_temp)
            {
                produto_todos.Add(produto);
            }
            cb_produto.DataSource = produto_todos;
            cb_produto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_produto.AutoCompleteSource = AutoCompleteSource.ListItems;

            tb_final.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_inicio.Text = "01/" + DateTime.Now.ToString("MM/yyyy");
            tb_inicio.Select();

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Frm_Imp_ProdutosXFornecedor form = new Frm_Imp_ProdutosXFornecedor(DateTime.Parse(tb_inicio.Text), DateTime.Parse(tb_final.Text), int.Parse(cb_fornecedor.SelectedValue.ToString()), int.Parse(cb_produto.SelectedValue.ToString()));
            form.Show();
        }
    }
}
