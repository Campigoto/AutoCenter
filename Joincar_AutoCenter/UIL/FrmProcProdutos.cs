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
        public ProdutoCollection produto_todos = new ProdutoCollection();
        int ORIGEM = 0;
        int ORDER = 1;

        public FrmProcProdutos(int ORIGEM_TEMP)
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Pesquisa de Produto");
            gb_produto.Text = Titulo_Grupo("Pesquisa");
            ORIGEM = ORIGEM_TEMP;

            if (ORIGEM_TEMP == 0)
            {
                dgv_Produtos.Columns["PRO_PRECO_COMPRA_FORMATADO"].Visible = true;
                dgv_Produtos.Columns["PRO_ESTOQUE_FORMATADO"].Visible = true;
                dgv_Produtos.Columns["COM_DATA_FORMATADA"].Visible = true;
                dgv_Produtos.Columns["PRO_EST_ANTERIOR"].Visible = false;
                dgv_Produtos.Columns["PRO_EST_ATUAL"].Visible = false;
                btn_voltar.Text = "Voltar";
                btn_voltar.Visible = false;
                btn_cadastro.Visible = true;
            }
            if (ORIGEM_TEMP == 1 || ORIGEM_TEMP == 2)
            {
                dgv_Produtos.Columns["PRO_PRECO_COMPRA_FORMATADO"].Visible = true;
                dgv_Produtos.Columns["PRO_ESTOQUE_FORMATADO"].Visible = true;
                dgv_Produtos.Columns["COM_DATA_FORMATADA"].Visible = true;
                dgv_Produtos.Columns["PRO_EST_ANTERIOR"].Visible = false;
                dgv_Produtos.Columns["PRO_EST_ATUAL"].Visible = false;
                btn_voltar.Text = "Voltar";
                btn_voltar.Visible = true;
                btn_cadastro.Visible = true;
            }
            else if (ORIGEM_TEMP == 3)
            {
                dgv_Produtos.Columns["PRO_PRECO_COMPRA_FORMATADO"].Visible = false;
                dgv_Produtos.Columns["PRO_ESTOQUE_FORMATADO"].Visible = false;
                dgv_Produtos.Columns["COM_DATA_FORMATADA"].Visible = false;
                dgv_Produtos.Columns["PRO_EST_ANTERIOR"].Visible = true;
                dgv_Produtos.Columns["PRO_EST_ATUAL"].Visible = true;
                btn_voltar.Text = "Confirmar";
                btn_voltar.Visible = true;
                btn_cadastro.Visible = false;
            }
            
            Global.PRO_CODIGO = 0;
            Global.PC_PRODUTO = 0;
            Global.HEP_PRODUTO = 0;

            cb_criterio.SelectedIndex = 1;

            Carregar_DGV();

            tb_igual.Select();
        }

        private void Carregar_DGV()
        {
            if (cb_criterio.SelectedIndex == 0 && tb_igual.Text != "")
            {
                try
                {
                    produto_todos = new ProdutoCollection(int.Parse(tb_igual.Text), ORDER);
                }
                catch (Exception)
                {
                    produto_todos = new ProdutoCollection(true, ORDER);
                }
            }
            else if (cb_criterio.SelectedIndex == 1 && tb_igual.Text != "")
            {
                produto_todos = new ProdutoCollection(ProdutoLoadType.LoadByNome, tb_igual.Text, ORDER);
            }
            else
            {
                produto_todos = new ProdutoCollection(true, ORDER);
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
            if (e.RowIndex > -1)
            {
                if (ORIGEM == 0)
                {
                    Global.PRO_CODIGO = int.Parse(dgv_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.Close();
                }
                else if (ORIGEM == 1)
                {
                    Global.PC_PRODUTO = int.Parse(dgv_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.Close();
                }
                else if (ORIGEM == 2)
                {
                    Global.HEP_PRODUTO = int.Parse(dgv_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.Close();
                }
            }
            else
            {
                ORDER = e.ColumnIndex;
                Carregar_DGV();
            }
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
            if (btn_voltar.Text == "Voltar")
            {
                if (ORIGEM == 1)
                {
                    Global.PC_PRODUTO = -1;
                }
                else if (ORIGEM == 2)
                {
                    Global.HEP_PRODUTO = -1;
                }
                this.Close();
            }
            else
            {
                int count = 0;
                foreach (Produto produto_foreach in produto_todos)
                {
                    if (produto_foreach.PRO_CODIGO > 0 && produto_foreach.PRO_ESTOQUE.ToString("0.000") != produto_foreach.PRO_EST_ATUAL)
                    {
                        count++;
                        Produto produto = new Produto(produto_foreach.PRO_CODIGO);
                        Historico_Estoque_Preco historico = new Historico_Estoque_Preco();
                        historico.HEP_CODIGO = 0;
                        historico.HEP_COMPRA = 0;
                        historico.HEP_DATA = DateTime.Now;
                        historico.HEP_ESTOQUE_ANTERIOR = produto.PRO_ESTOQUE;
                        historico.HEP_ESTOQUE_ATUAL = float.Parse(produto_foreach.PRO_EST_ATUAL);
                        historico.HEP_PRECO_UNITARIO = produto.PRO_PRECO_COMPRA;
                        historico.HEP_PRECO_TOTAL = produto.PRO_PRECO_COMPRA * float.Parse(produto_foreach.PRO_EST_ATUAL);
                        historico.HEP_PRODUTO = produto.PRO_CODIGO;
                        historico.HEP_QTDE = Math.Abs(produto.PRO_ESTOQUE - float.Parse(produto_foreach.PRO_EST_ATUAL));
                        historico.HEP_USUARIO = Global.FUN_CODIGO;
                        historico.Salvar();
                        
                        produto.PRO_ESTOQUE = float.Parse(produto_foreach.PRO_EST_ATUAL);
                        produto.Salvar();
                    }
                }
                if (count > 0)
                {
                    if (Configuracoes.Default.Mensagem_Gravar == true)
                    {
                        MessageBox.Show(count.ToString() + " produtos foram atualizados com sucesso!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Carregar_DGV();

                    tb_igual.Select();
                }
                else
                {
                    if (Configuracoes.Default.Mensagem_Gravar == true)
                    {
                        MessageBox.Show("Nenhum produto foi atualizado!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    btn_voltar.Select();
                }
            }
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

        public void Atualizar_Grid(int RowIndex)
        {
            try
            {
                produto_todos[RowIndex].PRO_EST_ATUAL = dgv_Produtos.Rows[RowIndex].Cells[9].Value.ToString();
            }
            catch (Exception) { }

            dgv_Produtos.UpdateCellValue(9, RowIndex);
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
                            break;
                        }
                    }
                }
                else if (ORIGEM == 2 && Global.HEP_PRODUTO != 0)
                {
                    if (Global.HEP_PRODUTO == -1)
                    {
                        Global.HEP_PRODUTO = 0;
                    }
                    Frm_Atualizar_Estoque form = new Frm_Atualizar_Estoque();
                    form.Show();
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

        private void dgv_Produtos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                Atualizar_Grid(e.RowIndex);
            }
        }
    }
}
