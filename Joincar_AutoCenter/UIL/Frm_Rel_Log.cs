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
    public partial class Frm_Rel_Log : Frm_Master
    {
        public Frm_Rel_Log()
        {
            InitializeComponent();

            FuncionarioCollection funcionario_todos_temp = new FuncionarioCollection(true);
            FuncionarioCollection funcionario_todos = new FuncionarioCollection();

            Funcionario funcionario_temp = new Funcionario();
            funcionario_temp.FUN_CODIGO = 0;
            funcionario_temp.FUN_NOME = "Todos";
            funcionario_todos.Add(funcionario_temp);

            foreach (Funcionario funcionario in funcionario_todos_temp)
            {
                funcionario_todos.Add(funcionario);
            }
            cb_funcionario.DataSource = funcionario_todos;

            cb_funcionario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_funcionario.AutoCompleteSource = AutoCompleteSource.ListItems;

            this.Text = Titulo_Tela("Relatório de Log");
            gb_contas_pagar.Text = Titulo_Grupo("Relatório");

            cb_funcionario.SelectedIndex = 0;
            cb_separado.SelectedIndex = 0;
            tb_final.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_inicio.Text = "01/" + DateTime.Now.ToString("MM/yyyy");
            tb_inicio.Select();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Frm_Imp_Log form = new Frm_Imp_Log(DateTime.Parse(tb_inicio.Text), DateTime.Parse(tb_final.Text), int.Parse(cb_funcionario.SelectedValue.ToString()), cb_separado.SelectedIndex);
            form.Show();
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}