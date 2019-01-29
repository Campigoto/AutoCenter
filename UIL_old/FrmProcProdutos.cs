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
    public partial class FrmProcProdutos : Frm_Master
    {
        int ORIGEM = 0;

        public FrmProcProdutos(int ORIGEM_TEMP)
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Pesquisa de Produto");
            gb_produto.Text = Titulo_Grupo("Pesquisa");
            ORIGEM = ORIGEM_TEMP;

            if (ORIGEM_TEMP == 1)
            {
                btn_voltar.Visible = true;
            }
            else
            {
                btn_voltar.Visible = false;
            }
            
            Global.PRO_CODIGO = 0;
            Global.PC_PRODUTO = 0;

            cb_criterio.SelectedIndex = 1;

            Carregar_DGV();

            tb_igual.Select();
        }

        private void Carregar_DGV()
        {
            ProdutoCollection produto_todos;

            if (cb_criterio.SelectedIndex == 0 && tb_igual.Text != "")
            {
                try
                {
                    produto_todos = new ProdutoCollection(int.Parse(tb_igual.Text));
                }
                catch (Exception)
                {
                    produto_todos = new ProdutoCollection(true);
                }
            }
            else if (cb_criterio.SelectedIndex == 1 && tb_igual.Text != "")
            {
                produto_todos = new ProdutoCollection(ProdutoLoadType.LoadByNome, tb_igual.Text);
            }
            else
            {
                produto_todos = new ProdutoCollection(true);
            }
            dgv_Produtos.AutoGenerateColumns = false;
            dgv_Produtos.DataSource = produto_todos;
        }

        private void tb_igual_TextChanged(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgv_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ORIGEM == 1)
            {
                Global.PC_PRODUTO = int.Parse(dgv_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            else
            {
                Global.PRO_CODIGO = int.Parse(dgv_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            this.Close();
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            Global.PRO_CODIGO = -1;

            this.Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Global.PC_PRODUTO = -1;

            this.Close();
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
                tb_igual.MaxLength = 60;
            }
            tb_igual.Text = "";
            tb_igual.Focus();
        }

        private void FrmProcProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.PRO_CODIGO == 0)
            {
                if (ORIGEM == 1)
                {
                    foreach (Form form_aberto in Application.OpenForms)
                    {
                        if (form_aberto.Text.Contains("Cadastro de Compra"))
                        {
                            Frm_Compra form = (Frm_Compra)form_aberto;

                            if (Global.PC_PRODUTO != 0)
                            {
                                if (Global.PC_PRODUTO > 0)
                                {
                                    Produto produto = new Produto(Global.PC_PRODUTO);
                                    Produtos_Compra produtos_compra = new Produtos_Compra();
                                    Global.PC_PRODUTO = 0;

                                    produtos_compra.PC_COMPRA = 0;
                                    produtos_compra.PC_ITEM = form.produtos_compra_todos.Count + 1;
                                    produtos_compra.PC_PRODUTO = produto.PRO_CODIGO;
                                    produtos_compra.PRO_NOME = produto.PRO_NOME;
                                    produtos_compra.PC_UNIDADE = produto.PRO_UNIDADE;
                                    produtos_compra.PC_QTDE = 1;
                                    produtos_compra.PC_PRECO_COMPRA = produto.PRO_PRECO_COMPRA;
                                    produtos_compra.PC_TOTAL = produto.PRO_PRECO_COMPRA;
                                    form.produtos_compra_todos.Add(produtos_compra);
                                    form.Carregar_Grid(form.produtos_compra_todos);
                                }
                                form.Enabled = true;
                                form.Show();
                            }
                            else
                            {
                                form.Close();
                            }
                            break;
                        }
                    }
                }
            }
            else 
            {
                if (Global.PRO_CODIGO == -1)
                {
                    Global.PRO_CODIGO = 0;
                }
                if (ORIGEM == 1)
                {
                    FrmProdutos form = new FrmProdutos(1);
                    form.Show();
                }
                else
                {
                    FrmProdutos form = new FrmProdutos(0);
                    form.Show();
                }
            }
        }
    }
}
