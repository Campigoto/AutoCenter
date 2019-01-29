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
    public partial class Frm_Atualizar_Estoque : Frm_Master
    {
        public Frm_Atualizar_Estoque()
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Histórico de Estoque / Preço");
            gb_estoque.Text = Titulo_Grupo("Histórico");

            tb_qtde.Text = "1,000";
            cb_tipo.SelectedIndex = 0;

            if (Global.HEP_PRODUTO > 0)
            {
                Produto produto = new Produto(Global.HEP_PRODUTO);

                if (produto.PRO_CODIGO > 0)
                {
                    tb_codigo.Text = produto.PRO_CODIGO.ToString();
                    tb_produto.Text = produto.PRO_NOME;
                    tb_estoque.Text = produto.PRO_ESTOQUE.ToString("0.000");

                    Carregar_DGV(Global.HEP_PRODUTO);

                    tb_qtde.Select();
                }
                else
                {
                    btn_pesquisar.Select();
                }
                Global.HEP_PRODUTO = 0;
            }
            else
            {
                btn_pesquisar.Select();
            }
        }

        private void Carregar_DGV(int HEP_PRODUTO)
        {
            Historico_Estoque_PrecoCollection historico_todos = new Historico_Estoque_PrecoCollection(int.Parse(tb_codigo.Text));

            dgv_historico.AutoGenerateColumns = false;
            dgv_historico.DataSource = historico_todos;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            FrmProcProdutos form = new FrmProcProdutos(2);
            form.Show();

            this.Hide();
            this.Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try 
	        {	        
		        float.Parse(tb_qtde.Text);
	        }
	        catch (Exception)
	        {
        		tb_qtde.Text = "0,000";
	        }
            if (tb_codigo.Text == "")
            {
                MessageBox.Show("Produto obrigatório!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_pesquisar.Select();
            }
            else if (float.Parse(tb_qtde.Text) <= 0)
	        {
                MessageBox.Show("Quantidade precisa ser maior que zero!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_qtde.Select();
	        }
            else
            {
                Produto produto = new Produto(int.Parse(tb_codigo.Text));
                if (cb_tipo.SelectedIndex == 0)
                {
                    produto.PRO_ESTOQUE -= float.Parse(tb_qtde.Text);
                }
                else
                {
                    produto.PRO_ESTOQUE += float.Parse(tb_qtde.Text);
                }
                produto.Salvar();

                Historico_Estoque_Preco historico = new Historico_Estoque_Preco();
                historico.HEP_CODIGO = 0;
                historico.HEP_COMPRA = 0;
                historico.HEP_DATA = DateTime.Now;
                if (cb_tipo.SelectedIndex == 0)
                {
                    historico.HEP_ESTOQUE_ANTERIOR = produto.PRO_ESTOQUE + float.Parse(tb_qtde.Text);
                }
                else
                {
                    historico.HEP_ESTOQUE_ANTERIOR = produto.PRO_ESTOQUE - float.Parse(tb_qtde.Text);
                }
                historico.HEP_ESTOQUE_ATUAL = produto.PRO_ESTOQUE;
                historico.HEP_PRECO_UNITARIO = produto.PRO_PRECO_COMPRA;
                historico.HEP_PRECO_TOTAL = produto.PRO_PRECO_COMPRA * float.Parse(tb_qtde.Text);
                historico.HEP_PRODUTO = produto.PRO_CODIGO;
                historico.HEP_QTDE = float.Parse(tb_qtde.Text);
                historico.HEP_USUARIO = Global.FUN_CODIGO;
                historico.Salvar();

                tb_qtde.Text = "1,000";
                cb_tipo.SelectedIndex = 1;

                Carregar_DGV(int.Parse(tb_codigo.Text));

                tb_qtde.Select();
            }
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != "," && e.KeyChar.ToString() != "\b";
        }

        private void Valor_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            try
            {
                tb.Text = float.Parse(tb.Text).ToString("0.000");
            }
            catch (Exception)
            {
                tb.Text = "0,000";
            }
        }
    }
}