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
    public partial class FrmProcFornecedores : Frm_Master
    {
        int ORDER = 1;

        public FrmProcFornecedores()
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Pesquisa de Fornecedor");
            gb_fornecedor.Text = Titulo_Grupo("Pesquisa");

            Global.CLI_CODIGO = 0;

            cb_criterio.SelectedIndex = 1;

            Carregar_DGV();

            tb_igual.Select();
        }

        private void Carregar_DGV()
        {
            FornecedorCollection fornecedor_todos;

            if (cb_criterio.SelectedIndex == 0 && tb_igual.Text != "")
            {
                try
                {
                    fornecedor_todos = new FornecedorCollection(int.Parse(tb_igual.Text), ORDER);
                }
                catch (Exception)
                {
                    fornecedor_todos = new FornecedorCollection(true, ORDER);
                }
            }
            else if (cb_criterio.SelectedIndex == 1 && tb_igual.Text != "")
            {
                fornecedor_todos = new FornecedorCollection(FornecedorLoadType.LoadByNome, tb_igual.Text, ORDER);
            }
            else
            {
                fornecedor_todos = new FornecedorCollection(true, ORDER);
            }
            dgv_Fornecedor.AutoGenerateColumns = false;
            dgv_Fornecedor.DataSource = fornecedor_todos;
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_igual_TextChanged(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgv_Fornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Global.FOR_CODIGO = int.Parse(dgv_Fornecedor.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Close();

                FrmFornecedores form = new FrmFornecedores();
                form.Show();
            }
            else
            {
                ORDER = e.ColumnIndex;
                Carregar_DGV();
            }
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmFornecedores form = new FrmFornecedores();
            form.Show();
        }

        private void cb_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_criterio.SelectedIndex == 0)
            {
                tb_igual.KeyPress += Numero_KeyPress;
                tb_igual.MaxLength = 10;
            }
            else
            {
                tb_igual.KeyPress -= Numero_KeyPress;
                tb_igual.MaxLength = 150;
            }
            tb_igual.Text = "";
            tb_igual.Focus();
        }

        protected string FormataString(string mascara, string valor)
        {   ////Formatando CPF
            //Response.write(FormataString(“###.###.###-##”, “09289209309”));
            ////Formatando Data
            //Response.write(FormataString(“##/##/####”, “12092010”));
            ////Formata CEP
            //Response.write(FormataString(“##.###-###”, “70000000”));
            ////Formata valor
            //Response.write(FormataString(“##,##”, “2309”));

            string novoValor = string.Empty;
            int posicao = 0;

            for (int i = 0; mascara.Length > i; i++)
            {
                if (mascara[i] == '#')
                {
                    if (valor.Length > posicao)
                    {
                        novoValor = novoValor + valor[posicao];
                        posicao++;
                    }
                    else
                        break;
                }
                else
                {
                    if (valor.Length > posicao)
                        novoValor = novoValor + mascara[i];
                    else
                        break;
                }
            }
            return novoValor;
        }
    }
}
