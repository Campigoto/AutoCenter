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
    public partial class Frm_Compra : Frm_Master
    {
        public Produtos_CompraCollection produtos_compra_todos_anterior = new Produtos_CompraCollection();
        public Produtos_CompraCollection produtos_compra_todos = new Produtos_CompraCollection();

        public Frm_Compra(int COM_CODIGO)
        {
            InitializeComponent();

            FornecedorCollection fornecedor_todos_temp = new FornecedorCollection(true, 1);
            FornecedorCollection fornecedor_todos = new FornecedorCollection();

            Fornecedor fornecedor_temp = new Fornecedor();
            fornecedor_temp.FOR_CODIGO = 0;
            fornecedor_temp.FOR_NOME = "";
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
            lancamento_temp.HIS_DESCRICAO = "";
            lancamento_todos.Add(lancamento_temp);
            
            foreach (Historico_Lancamento lancamento in lancamento_todos_temp)
            {
                lancamento_todos.Add(lancamento);
                                
            }
            
           
            this.Text = Titulo_Tela("Cadastro de Compra");

            Limpar();
            Ativar_Desativar(true);

            dgv_produtos.AutoGenerateColumns = false;

            if (COM_CODIGO > 0)
            {
                Carregar_Cadastro(COM_CODIGO);
            }
            else
            {
                gb_compra.Text = Titulo_Grupo("Cadastro");
                cb_fornecedor.Select();
            }

            //// Coloca "COMPRAS" como pradrão de histórico

            //bool Tem = false;
            //int Posicao = 0;

            //cb_lancamento.Visible = false;

            //for (int i = 0; i < cb_lancamento.Items.Count; i++)
            //{

            //    cb_lancamento.SelectedIndex = i;
            //    if (cb_lancamento.Text.ToUpper() == "COMPRAS")
            //    {
            //        Tem = true;
            //        Posicao = i;
            //    }
            //}
            //if (Tem)
            //{
            //    cb_lancamento.SelectedIndex = Posicao;
            //}
            //else
            //{
            //    cb_lancamento.SelectedIndex = 0;
            //}

            //cb_lancamento.Visible = true;
        }

        public void Carregar_Grid(Produtos_CompraCollection produtos_compra_todos_temp)
        {
            produtos_compra_todos = new Produtos_CompraCollection();
            float subtotal = 0;

            foreach (Produtos_Compra produtos_compra in produtos_compra_todos_temp)
            {
                subtotal += produtos_compra.PC_TOTAL;
                produtos_compra_todos.Add(produtos_compra);
            }
            dgv_produtos.DataSource = produtos_compra_todos;
            tb_subtotal.Text = subtotal.ToString("0.00");

            Calcular_Total();
            Esconder_Colunas();
        }

        public void Atualizar_Grid(int RowIndex, int ColumnIndex)
        {
            if (ColumnIndex == 7)
            {
                try
                {
                    produtos_compra_todos[RowIndex].PC_QTDE = float.Parse(dgv_produtos.Rows[RowIndex].Cells[ColumnIndex].Value.ToString());
                }
                catch (Exception) { }
            }
            else if (ColumnIndex == 9)
            {
                try
                {
                    produtos_compra_todos[RowIndex].PC_PRECO_COMPRA = float.Parse(dgv_produtos.Rows[RowIndex].Cells[ColumnIndex].Value.ToString());
                }
                catch (Exception) { }
            }
            dgv_produtos.UpdateCellValue(11, RowIndex);
            float subtotal = 0;

            foreach (Produtos_Compra produtos_compra in produtos_compra_todos)
            {
                subtotal += produtos_compra.PC_TOTAL;
            }
            tb_subtotal.Text = subtotal.ToString("0.00");

            Calcular_Total();
        }

        private void Calcular_Total()
        {
            float total = 0;

            total += float.Parse(tb_subtotal.Text);
            total += float.Parse(tb_out_desp.Text);
            total += float.Parse(tb_frete.Text);
            total += float.Parse(tb_acresc.Text);
            total -= float.Parse(tb_desc.Text);

            tb_total.Text = total.ToString("0.00");
        }

        public void Carregar_Cadastro(int COM_CODIGO)
        {
            Compra compra = new Compra(COM_CODIGO,0);

            if (compra.COM_CODIGO > 0)
            {
                tb_codigo.Text = compra.COM_CODIGO.ToString();
                try
                {
                    cb_fornecedor.SelectedValue = compra.COM_CLIENTE_FORNECEDOR;
                }
                catch (Exception)
                {
                    cb_fornecedor.SelectedIndex = 0;
                }
                tb_nf.Text = compra.COM_NF_FORMATADO;
                tb_data.Text = compra.COM_DATA.ToString("dd/MM/yyyy");
                
                if (compra.COM_TIPO_PAGTO == 0)
                {
                    rb_nao_gerar.Checked = true;
                    rb_avista.Checked = false;
                    rb_aprazo.Checked = false;
                }
                else if (compra.COM_TIPO_PAGTO == 0)
                {
                    rb_nao_gerar.Checked = false;
                    rb_avista.Checked = true;
                    rb_aprazo.Checked = false;
                }
                else
                {
                    rb_nao_gerar.Checked = false;
                    rb_avista.Checked = false;
                    rb_aprazo.Checked = true;
                }
                tb_out_desp.Text = compra.COM_OUT_DESPESAS.ToString("0.00");
                tb_frete.Text = compra.COM_FRETE.ToString("0.00");
                tb_acresc.Text = compra.COM_ACRESCIMO.ToString("0.00");
                tb_desc.Text = compra.COM_DESCONTO.ToString("0.00");
                
                Carregar_Grid(new Produtos_CompraCollection(COM_CODIGO));
                Ativar_Desativar(false);

                //Guardar produtos anteriores para baixa de estoque correta
                produtos_compra_todos_anterior = new Produtos_CompraCollection(COM_CODIGO);

                tb_codigo.Enabled = false;
                if (compra.COM_CANCELADO == 1)
                {
                    gb_compra.Text = Titulo_Grupo("Cadastro") + " - CANCELADO";
                    btn_produto.Enabled = false;
                    btn_gravar.Enabled = false;
                    btn_cancelar.Enabled = false;
                    dgv_produtos.Enabled = false;
                    btn_limpar.Focus();
                }
                else
                {
                    btn_cancelar.Enabled = true;
                    dgv_produtos.Enabled = true;
                    cb_fornecedor.Select();
                }
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_codigo.Text = string.Empty;
                tb_codigo.Select();
            }

            btn_imprimir.Enabled = true;
        }

        public void Limpar()
        {
            tb_codigo.Text = string.Empty;
            cb_fornecedor.SelectedIndex = 0;
            tb_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_nf.Text = "";
            rb_nao_gerar.Checked = false;
            rb_avista.Checked = false;
            rb_aprazo.Checked = true;
            tb_out_desp.Text = "0,00";
            tb_frete.Text = "0,00";
            tb_acresc.Text = "0,00";
            tb_desc.Text = "0,00";
            gb_compra.Text = Titulo_Grupo("Cadastro");
            Carregar_Grid(new Produtos_CompraCollection());
            produtos_compra_todos_anterior = new Produtos_CompraCollection();

            tb_codigo.Enabled = true;
            btn_produto.Enabled = true;
            btn_gravar.Enabled = true;
            btn_cancelar.Enabled = false;
            dgv_produtos.Enabled = true;

            btn_imprimir.Enabled = false;
        }

        public void Ativar_Desativar(bool true_false)
        {
            cb_fornecedor.Enabled = true_false;
            tb_nf.Enabled = true_false;
            tb_data.Enabled = true_false;
            rb_nao_gerar.Enabled = true_false;
            rb_avista.Enabled = true_false;
            rb_aprazo.Enabled = true_false;
            tb_out_desp.Enabled = true_false;
            tb_frete.Enabled = true_false;
            tb_acresc.Enabled = true_false;
            tb_desc.Enabled = true_false;
            btn_imprimir.Enabled = false;
        }

        private void Esconder_Colunas()
        {
            dgv_produtos.Columns["PC_COMPRA"].Visible = false;
            dgv_produtos.Columns["PC_QTDE"].Visible = false;
            dgv_produtos.Columns["PC_PRECO_COMPRA"].Visible = false;
            dgv_produtos.Columns["PC_TOTAL"].Visible = false;
            dgv_produtos.Columns["PC_PRODUTO"].Visible = false;
            dgv_produtos.Columns["PC_UNIDADE"].Visible = false;
            dgv_produtos.Columns["PC_QTDE"].Visible = false;
            dgv_produtos.Columns["PC_PRECO_COMPRA"].Visible = false;
            dgv_produtos.Columns["PRO_NOME"].Visible = false;
        }

        public void Gravar(bool Mensagem_Gravar)
        {
            Compra compra;
            Historico_Estoque_Preco historico;
            Produto produto;

            if (tb_codigo.Text == string.Empty)
            {
                compra = new Compra();
                compra.COM_OBS = "";
                compra.COM_DATA_CANCELADO = DateTime.Parse("01/01/1800");
            }
            else
            {
                compra = new Compra(int.Parse(tb_codigo.Text),0);
            }

            try
            {
                compra.COM_CLIENTE_FORNECEDOR = int.Parse(cb_fornecedor.SelectedValue.ToString());
            }
            catch (Exception)
            {
                compra.COM_CLIENTE_FORNECEDOR = 0;
            }
           
            // CÓDIGO DE COMPRA = 0
            compra.COM_LANCAMENTO = 0;
           
            try
            {
                compra.COM_NF = int.Parse(tb_nf.Text);
            }
            catch (Exception)
            {
                compra.COM_NF = 0;
            }
            try
            {
                compra.COM_DATA = DateTime.Parse(tb_data.Text);
            }
            catch (Exception)
            {
                compra.COM_DATA = DateTime.Now;
            }
            compra.COM_ALTERACAO = DateTime.Now;
            if (rb_nao_gerar.Checked)
            {
                compra.COM_TIPO_PAGTO = 0;
            }
            else if (rb_avista.Checked)
            {
                compra.COM_TIPO_PAGTO = 1;
            }
            else
            {
                compra.COM_TIPO_PAGTO = 2;
            }
            compra.COM_OUT_DESPESAS = float.Parse(tb_out_desp.Text);
            compra.COM_FRETE = float.Parse(tb_frete.Text);
            compra.COM_ACRESCIMO = float.Parse(tb_acresc.Text);
            compra.COM_DESCONTO = float.Parse(tb_desc.Text);
            compra.COM_TOTAL = float.Parse(tb_total.Text);
            compra.COM_TIPO_MOVIMENTO = 0;
            compra.Salvar();

            Log log = new Log();
            log.LOG_USUARIO = Global.FUN_CODIGO;
            log.LOG_DATA = DateTime.Now;
            log.LOG_TELA = this.Text;
            if (tb_codigo.Text == string.Empty)
            {
                log.LOG_DESCRICAO = "Cadastrou a compra de código: " + compra.COM_CODIGO.ToString() + " e fornecedor: " + cb_fornecedor.Text + ".";

                if (compra.COM_CLIENTE_FORNECEDOR > 0)
                {
                    Fornecedor fornecedor = new Fornecedor(compra.COM_CLIENTE_FORNECEDOR);
                    fornecedor.FOR_ULT_COMPRA = compra.COM_CODIGO;
                    fornecedor.Salvar();
                }
            }
            else
            {
                log.LOG_DESCRICAO = "Alterou a compra de código: " + compra.COM_CODIGO.ToString() + " e fornecedor: " + cb_fornecedor.Text + ".";
            }
            log.Save();

            produtos_compra_todos.Deletar(compra.COM_CODIGO);

            foreach (Produtos_Compra produtos_compra_anterior in produtos_compra_todos_anterior)
            {
                produto = new Produto(produtos_compra_anterior.PC_PRODUTO);
                produto.PRO_ESTOQUE -= produtos_compra_anterior.PC_QTDE;
                produto.Salvar();

                historico = new Historico_Estoque_Preco();
                historico.HEP_CODIGO = 0;
                historico.HEP_COMPRA = compra.COM_CODIGO;
                historico.HEP_DATA = DateTime.Now;
                historico.HEP_ESTOQUE_ANTERIOR = produto.PRO_ESTOQUE + produtos_compra_anterior.PC_QTDE;
                historico.HEP_ESTOQUE_ATUAL = produto.PRO_ESTOQUE;
                historico.HEP_PRECO_UNITARIO = produtos_compra_anterior.PC_PRECO_COMPRA;
                historico.HEP_PRECO_TOTAL = produtos_compra_anterior.PC_TOTAL;
                historico.HEP_PRODUTO = produtos_compra_anterior.PC_PRODUTO;
                historico.HEP_QTDE = produtos_compra_anterior.PC_QTDE;
                historico.HEP_USUARIO = Global.FUN_CODIGO;
                historico.Salvar();
            }
            foreach (Produtos_Compra produtos_compra in produtos_compra_todos)
            {
                produtos_compra.PC_COMPRA = compra.COM_CODIGO;
                produtos_compra.Salvar();

                produto = new Produto(produtos_compra.PC_PRODUTO);
                produto.PRO_ESTOQUE += produtos_compra.PC_QTDE;
                if (produto.PRO_ULT_COMPRA < compra.COM_CODIGO)
                {
                    produto.PRO_ULT_COMPRA = compra.COM_CODIGO;
                    produto.PRO_PRECO_COMPRA = produtos_compra.PC_PRECO_COMPRA;
                }
                produto.Salvar();

                historico = new Historico_Estoque_Preco();
                historico.HEP_CODIGO = 0;
                historico.HEP_COMPRA = compra.COM_CODIGO;
                historico.HEP_DATA = DateTime.Now;
                historico.HEP_ESTOQUE_ANTERIOR = produto.PRO_ESTOQUE - produtos_compra.PC_QTDE;
                historico.HEP_ESTOQUE_ATUAL = produto.PRO_ESTOQUE;
                historico.HEP_PRECO_UNITARIO = produtos_compra.PC_PRECO_COMPRA;
                historico.HEP_PRECO_TOTAL = produtos_compra.PC_TOTAL;
                historico.HEP_PRODUTO = produtos_compra.PC_PRODUTO;
                historico.HEP_QTDE = produtos_compra.PC_QTDE;
                historico.HEP_USUARIO = Global.FUN_CODIGO;
                historico.Salvar();
            }
            if (Configuracoes.Default.Mensagem_Gravar == true && Mensagem_Gravar == true)
            {
                if (tb_codigo.Text == string.Empty)
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Alteração efetuada com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Ativar_Desativar(false);

            tb_codigo.Text = compra.COM_CODIGO.ToString();
            tb_codigo.Enabled = false;
            btn_cancelar.Enabled = true;
            dgv_produtos.Enabled = true;

            cb_fornecedor.Focus();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (cb_fornecedor.SelectedIndex == 0 || cb_fornecedor.Items.Count == 0)
            {
                MessageBox.Show("Fornecedor obrigatório!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_fornecedor.Focus();
            }
            else if (tb_data.Text == "")
            {
                MessageBox.Show("Data obrigatória!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_data.Focus();
            }
            else if (dgv_produtos.Rows.Count == 0)
            {
                MessageBox.Show("Produto obrigatório!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_produto.Focus();
            }
            else if (float.Parse(tb_total.Text) == 0)
            {
                MessageBox.Show("Total precisa ser maior que zero!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_produto.Focus();
            }
            else
            {
                if (rb_aprazo.Checked && tb_codigo.Text == string.Empty)
                {
                    this.Enabled = false;

                    Frm_Gerar_Parcelas form = new Frm_Gerar_Parcelas(new Parcelas_PagarCollection(), 0, 1, float.Parse(tb_subtotal.Text) + float.Parse(tb_frete.Text) + float.Parse(tb_out_desp.Text), float.Parse(tb_acresc.Text), float.Parse(tb_desc.Text), DateTime.Parse(tb_data.Text), tb_nf.Text);
                    form.Show();
                }
                else
                {
                    Gravar(true);
                }
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
            Ativar_Desativar(true);

            cb_fornecedor.Focus();
        }

        private void tb_codigo_Leave(object sender, EventArgs e)
        {
            if (tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text));

                cb_fornecedor.Focus();
            }
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
                tb.Text = float.Parse(tb.Text).ToString("0.00");
            }
            catch (Exception)
            {
                tb.Text = "0,00";
            }
            Calcular_Total();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text));

                cb_fornecedor.Focus();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (tb_codigo.Text != "" && MessageBox.Show("Deseja realmente cancelar esta compra?", "Joincar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Contas_PagarCollection contas_pagar_todos = new Contas_PagarCollection(int.Parse(tb_codigo.Text), Contas_PagarLoadType.LoadByCompra, 2);

                bool possui_parc_paga = false;
                if (contas_pagar_todos.Count > 0)
                {
                    Parcelas_PagarCollection parcela_todos = new Parcelas_PagarCollection(contas_pagar_todos[0].CAP_CODIGO);

                    foreach (Parcelas_Pagar parcela in parcela_todos)
                    {
                        if (parcela.PCA_VALOR_PAGO > 0)
                        {
                            possui_parc_paga = true;
                            break;
                        }
                    }
                    if (possui_parc_paga == false)
                    {
                        parcela_todos.Deletar(contas_pagar_todos[0].CAP_CODIGO);
                        contas_pagar_todos[0].Deletar();
                    }
                }
                if (possui_parc_paga == false)
                {
                    Compra compra = new Compra(int.Parse(tb_codigo.Text),0);
                    Historico_Estoque_Preco historico;
                    Produto produto;

                    if (compra.COM_CODIGO > 0)
                    {
                        compra.COM_CANCELADO = 1;
                        compra.COM_ALTERACAO = DateTime.Now;
                        compra.COM_DATA_CANCELADO = DateTime.Now;
                        compra.Salvar();

                        Log log = new Log();
                        log.LOG_USUARIO = Global.FUN_CODIGO;
                        log.LOG_DATA = DateTime.Now;
                        log.LOG_TELA = this.Text;
                        log.LOG_DESCRICAO = "Cancelou a compra de código: " + compra.COM_CODIGO.ToString() + " e fornecedor: " + cb_fornecedor.Text + ".";
                        log.Save();

                        foreach (Produtos_Compra produtos_compra in produtos_compra_todos)
                        {
                            produto = new Produto(produtos_compra.PC_PRODUTO);
                            produto.PRO_ESTOQUE -= produtos_compra.PC_QTDE;
                            produto.Salvar();

                            historico = new Historico_Estoque_Preco();
                            historico.HEP_CODIGO = 0;
                            historico.HEP_COMPRA = compra.COM_CODIGO;
                            historico.HEP_DATA = DateTime.Now;
                            historico.HEP_ESTOQUE_ANTERIOR = produto.PRO_ESTOQUE + produtos_compra.PC_QTDE;
                            historico.HEP_ESTOQUE_ATUAL = produto.PRO_ESTOQUE;
                            historico.HEP_PRECO_UNITARIO = produtos_compra.PC_PRECO_COMPRA;
                            historico.HEP_PRECO_TOTAL = produtos_compra.PC_TOTAL;
                            historico.HEP_PRODUTO = produtos_compra.PC_PRODUTO;
                            historico.HEP_QTDE = produtos_compra.PC_QTDE;
                            historico.HEP_USUARIO = Global.FUN_CODIGO;
                            historico.Salvar();
                        }
                        Limpar();
                        Ativar_Desativar(true);

                        if (Configuracoes.Default.Mensagem_Gravar == true)
                        {
                            MessageBox.Show("Cancelamento efetuado com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        cb_fornecedor.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Impossível cancelar compra! É necessário estornar as parcelas antes.", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgv_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                lbl_linha.Text = e.RowIndex.ToString();
            }
        }

        private void dgv_produtos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && int.Parse(lbl_linha.Text) >= 0)
            {
                if (tb_codigo.Text != "")
                {
                    MessageBox.Show("Impossível excluir produto ao alterar uma compra!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Deseja realmente excluir este produto?", "Joincar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Produtos_CompraCollection produtos_compra_todos_temp = new Produtos_CompraCollection();
                    int PC_ITEM = 1;

                    foreach (Produtos_Compra produtos_compra in produtos_compra_todos)
                    {
                        if (produtos_compra.PC_ITEM != (int.Parse(lbl_linha.Text) + 1))
                        {
                            produtos_compra.PC_ITEM = PC_ITEM++;
                            produtos_compra_todos_temp.Add(produtos_compra);
                        }
                    }
                    Carregar_Grid(produtos_compra_todos_temp);
                }
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Frm_Proc_Compra form = new Frm_Proc_Compra(0); //adicionado 0 para buscar apenas compras
            form.Show();

            this.Hide();
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            if (tb_codigo.Text != "")
            {
                MessageBox.Show("Impossível adicionar produto ao alterar uma compra!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmProcProdutos form = new FrmProcProdutos(1);
                form.Show();

                this.Hide();
            }
        }

        private void dgv_produtos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 || e.ColumnIndex == 9)
            {
                Atualizar_Grid(e.RowIndex, e.ColumnIndex);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            int tipo_mov = 0;
            int tipo_lanc = 0;
            int cod_compra = int.Parse(tb_codigo.Text);
            Frm_Imp_CompVenda printOS = new Frm_Imp_CompVenda(cod_compra, tipo_mov, tipo_lanc, "Relatório de Compra");
            printOS.Show();
        }
    }
}