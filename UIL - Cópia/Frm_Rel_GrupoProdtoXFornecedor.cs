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
    public partial class Frm_Rel_GrupoProdtoXFornecedor : Frm_Master
    {
        public Frm_Rel_GrupoProdtoXFornecedor()
        {
            InitializeComponent();
            this.Text = Titulo_Tela("Relatório de Grupo de Produtos X Fornecedor");
            //tb_final.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //tb_inicio.Text = "01/" + DateTime.Now.ToString("MM/yyyy");
            //tb_inicio.Select();

            GrupoProdutoCollection grupo_todos_temp = new GrupoProdutoCollection(true);
            GrupoProdutoCollection grupo_todos      = new GrupoProdutoCollection();

           

            GrupoProduto grupo_temp = new GrupoProduto();
            grupo_temp.GRP_CODIGO = 0;
            grupo_temp.GRP_NOME = "Todos";
            grupo_todos.Add(grupo_temp);

            foreach (GrupoProduto grupos in grupo_todos_temp)
            {
                grupo_todos.Add(grupos);
            }
            cb_grupo.DataSource = grupo_todos;
            cb_grupo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_grupo.AutoCompleteSource = AutoCompleteSource.ListItems;

            tb_final.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_inicio.Text = "01/" + DateTime.Now.ToString("MM/yyyy");
            tb_inicio.Select();

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Frm_Imp_GrupoProdutosXFornecedor form = new Frm_Imp_GrupoProdutosXFornecedor(DateTime.Parse(tb_inicio.Text), DateTime.Parse(tb_final.Text), int.Parse(cb_grupo.SelectedValue.ToString()));
            form.Show();
        }
    }
}
