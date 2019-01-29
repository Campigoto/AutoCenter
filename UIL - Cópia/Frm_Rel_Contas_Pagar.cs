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
    public partial class Frm_Rel_Contas_Pagar : Frm_Master
    {
        public Frm_Rel_Contas_Pagar()
        {
            InitializeComponent();

            FornecedorCollection fornecedor_todos_temp = new FornecedorCollection(true, 1);
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

            Historico_LancamentoCollection lancamento_todos_temp = new Historico_LancamentoCollection(true);
            Historico_LancamentoCollection lancamento_todos = new Historico_LancamentoCollection();

            Historico_Lancamento lancamento_temp = new Historico_Lancamento();
            lancamento_temp.HIS_ID = 0;
            lancamento_temp.HIS_CODIGO = "";
            lancamento_temp.HIS_DESCRICAO = "Todos";
            lancamento_todos.Add(lancamento_temp);

            foreach (Historico_Lancamento lancamento in lancamento_todos_temp)
            {
                lancamento_todos.Add(lancamento);
            }
            cb_lancamento.DataSource = lancamento_todos;
            cb_lancamento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_lancamento.AutoCompleteSource = AutoCompleteSource.ListItems;

            this.Text = Titulo_Tela("Relatório do Contas a Pagar");
            gb_contas_pagar.Text = Titulo_Grupo("Relatório");

            cb_origem.SelectedIndex = 0;
            cb_tipo.SelectedIndex = 0;
            cb_situacao.SelectedIndex = 2;
            cb_separado.SelectedIndex = 0;
            tb_final.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_inicio.Text = "01/" + DateTime.Now.ToString("MM/yyyy");
            tb_inicio.Select();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Frm_Imp_Contas_Pagar form = new Frm_Imp_Contas_Pagar(cb_tipo.SelectedIndex, DateTime.Parse(tb_inicio.Text), DateTime.Parse(tb_final.Text), int.Parse(cb_fornecedor.SelectedValue.ToString()), int.Parse(cb_lancamento.SelectedValue.ToString()), cb_origem.SelectedIndex, cb_situacao.SelectedIndex, cb_separado.SelectedIndex);
            form.Show();
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}