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
    public partial class Frm_Contas_Pagar : Frm_Master
    {
        public Parcelas_PagarCollection parcela_todos = new Parcelas_PagarCollection();
        public Cheques_PagarCollection cheque_pagar_todos = new Cheques_PagarCollection();

        public Frm_Contas_Pagar(int CAP_CODIGO)
        {
            InitializeComponent();

            FornecedorCollection fornecedor_todos_temp = new FornecedorCollection(true);
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
            cb_lancamento.DataSource = lancamento_todos;

            this.Text = Titulo_Tela("Cadastro do Contas a Pagar");
            gb_contas_pagar.Text = Titulo_Grupo("Cadastro");

            Limpar();

            dgv_parcelas.AutoGenerateColumns = false;

            DataTable dt_tipo = new DataTable("PCA_TIPO");
            dt_tipo.Columns.Add("PCA_TIPO", typeof(int));
            dt_tipo.Columns.Add("PCA_TIPO_NOME", typeof(string));
            dt_tipo.Rows.Add(0, "");
            dt_tipo.Rows.Add(1, "Dinheiro");
            dt_tipo.Rows.Add(2, "Crediario");
            dt_tipo.Rows.Add(3, "Cheque");
            dt_tipo.Rows.Add(4, "Boleto");
            dt_tipo.Rows.Add(5, "Financeira");

            DataGridViewComboBoxColumn cbl_tipo = (DataGridViewComboBoxColumn)dgv_parcelas.Columns[dgv_parcelas.Columns["Tipo"].Index];
            cbl_tipo.DataSource = dt_tipo;
            cbl_tipo.DataPropertyName = "PCA_TIPO";
            cbl_tipo.DisplayMember = "PCA_TIPO_NOME";
            cbl_tipo.HeaderText = "Tipo";
            cbl_tipo.ValueMember = "PCA_TIPO";

            if (CAP_CODIGO > 0)
            {
                Carregar_Cadastro(CAP_CODIGO);
            }
            else
            {
                Carregar_Grid(parcela_todos);
            }

            cb_fornecedor.Select();
        }

        public void Carregar_Grid(Parcelas_PagarCollection parcela_todos_temp)
        {
            parcela_todos = new Parcelas_PagarCollection();
            float total_geral = 0;
            float total_pago = 0;

            foreach (Parcelas_Pagar parcela in parcela_todos_temp)
            {
                if (parcela.PCA_VALOR_PAGO > 0)
                {
                    total_geral += parcela.PCA_VALOR_PAGO;
                    total_pago += parcela.PCA_VALOR_PAGO;
                }
                else
                {
                    total_geral += parcela.PCA_VALOR;
                }
                parcela_todos.Add(parcela);
            }

            dgv_parcelas.DataSource = parcela_todos;

            foreach (DataGridViewRow row in dgv_parcelas.Rows)
            {
                if (parcela_todos[row.Index].PCA_VALOR_PAGO > 0)
                {
                    row.ReadOnly = true;
                }
                else
                {
                    row.ReadOnly = false;
                }
            }

            tb_total_geral.Text = total_geral.ToString("0.00");
            tb_total_pago.Text = total_pago.ToString("0.00");

            Esconder_Colunas();
        }

        private void Carregar_Cadastro(int CAP_CODIGO)
        {
            Contas_Pagar contas_pagar = new Contas_Pagar(CAP_CODIGO);

            if (contas_pagar.CAP_CODIGO > 0)
            {
                tb_codigo.Text = contas_pagar.CAP_CODIGO.ToString();
                try
                {
                    cb_fornecedor.SelectedValue = contas_pagar.CAP_FORNECEDOR;
                }
                catch (Exception)
                {
                    cb_fornecedor.SelectedIndex = 0;
                }
                tb_compra.Text = contas_pagar.CAP_COMPRA_FORMATADO;
                try
                {
                    cb_lancamento.SelectedValue = contas_pagar.CAP_LANCAMENTO;
                }
                catch (Exception)
                {
                    cb_lancamento.SelectedIndex = 0;
                }
                Carregar_Grid(new Parcelas_PagarCollection(CAP_CODIGO));
                cheque_pagar_todos = new Cheques_PagarCollection(CAP_CODIGO, Cheques_PagarLoadType.LoadByCarne);

                tb_codigo.Enabled = false;
                btn_excluir.Enabled = true;
                btn_cheque.Enabled = false;
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_codigo.Text = string.Empty;
            }
        }

        public void Limpar()
        {
            tb_codigo.Text = string.Empty;
            cb_fornecedor.SelectedIndex = 0;
            cb_lancamento.SelectedIndex = 0;
            tb_compra.Text = "";
            tb_total_geral.Text = "0,00";
            tb_total_pago.Text = "0,00";

            Carregar_Grid(new Parcelas_PagarCollection());
            cheque_pagar_todos = new Cheques_PagarCollection();

            tb_codigo.Enabled = true;
            btn_excluir.Enabled = false;
            btn_cheque.Enabled = false;
        }

        private void Esconder_Colunas()
        {
            dgv_parcelas.Columns["PCA_CARNE"].Visible = false;
            dgv_parcelas.Columns["PCA_TIPO"].Visible = false;
            dgv_parcelas.Columns["PCA_TIPO_NOME"].Visible = false;
            dgv_parcelas.Columns["PCA_VALOR"].Visible = false;
            dgv_parcelas.Columns["PCA_VALOR_PAGO"].Visible = false;
            dgv_parcelas.Columns["PCA_DATA_PAGTO"].Visible = false;
            dgv_parcelas.Columns["PCA_VENC"].Visible = false;
            dgv_parcelas.Columns["FOR_NOME"].Visible = false;
            dgv_parcelas.Columns["PCA_ITEM_NOVA_PARC"].Visible = false;
        }

        public void Construir(int CAP_COMPRA)
        {
            Compra compra = new Compra(CAP_COMPRA);
            try
            {
                cb_fornecedor.SelectedValue = compra.COM_FORNECEDOR;
            }
            catch (Exception)
            {
                cb_fornecedor.SelectedIndex = 0;
            }
            tb_compra.Text = compra.COM_CODIGO.ToString();
            try
            {
                cb_lancamento.SelectedValue = compra.COM_LANCAMENTO;
            }
            catch (Exception)
            {
                cb_lancamento.SelectedIndex = 0;
            }
            Gravar(false);
        }

        public void Gravar(bool Mensagem_Gravar)
        {
            Contas_Pagar contas_pagar;

            if (tb_codigo.Text == string.Empty)
            {
                contas_pagar = new Contas_Pagar();
                contas_pagar.CAP_OBS = "";
                contas_pagar.CAP_CADASTRO = DateTime.Now;

                if (tb_compra.Text != "")
                {
                    contas_pagar.CAP_COMPRA = int.Parse(tb_compra.Text);
                }
                else
                {
                    contas_pagar.CAP_COMPRA = 0;
                }
            }
            else
            {
                contas_pagar = new Contas_Pagar(int.Parse(tb_codigo.Text));
            }

            try
            {
                contas_pagar.CAP_FORNECEDOR = int.Parse(cb_fornecedor.SelectedValue.ToString());
            }
            catch (Exception)
            {
                contas_pagar.CAP_FORNECEDOR = 0;
            }
            try
            {
                contas_pagar.CAP_LANCAMENTO = int.Parse(cb_lancamento.SelectedValue.ToString());
            }
            catch (Exception)
            {
                contas_pagar.CAP_LANCAMENTO = 0;
            }
            contas_pagar.CAP_TOTAL = float.Parse(tb_total_geral.Text);
            contas_pagar.Salvar();

            Log log = new Log();
            log.LOG_USUARIO = Global.FUN_CODIGO;
            log.LOG_DATA = DateTime.Now;
            log.LOG_TELA = this.Text;
            if (tb_codigo.Text == string.Empty)
            {
                log.LOG_DESCRICAO = "Cadastrou o contas a pagar de código: " + contas_pagar.CAP_CODIGO.ToString() + " e fornecedor: " + cb_fornecedor.Text + ".";
            }
            else
            {
                log.LOG_DESCRICAO = "Alterou o contas a pagar de código: " + contas_pagar.CAP_CODIGO.ToString() + " e fornecedor: " + cb_fornecedor.Text + ".";
            }
            log.Save();

            parcela_todos.Deletar(contas_pagar.CAP_CODIGO);
            cheque_pagar_todos.Deletar(contas_pagar.CAP_CODIGO);

            foreach (DataGridViewRow row in dgv_parcelas.Rows)
            {
                parcela_todos[row.Index].PCA_CARNE = contas_pagar.CAP_CODIGO;
                parcela_todos[row.Index].PCA_NUM_DOC = row.Cells["PCA_NUM_DOC"].Value.ToString();
                try
                {
                    parcela_todos[row.Index].PCA_VALOR = float.Parse(row.Cells["PCA_VALOR_FORMATADO"].Value.ToString());
                }
                catch (Exception)
                {
                    parcela_todos[row.Index].PCA_VALOR = 0;
                }
                try
                {
                    parcela_todos[row.Index].PCA_VENC = DateTime.Parse(row.Cells["PCA_VENC_FORMATADO"].Value.ToString());
                }
                catch (Exception)
                {
                    parcela_todos[row.Index].PCA_VENC = DateTime.Today;
                }
                parcela_todos[row.Index].PCA_OBS = row.Cells["PCA_OBS"].Value.ToString();
                parcela_todos[row.Index].Salvar();

                if (parcela_todos[row.Index].PCA_TIPO == 3)
                {
                    foreach (Cheques_Pagar cheque_pagar in cheque_pagar_todos)
                    {
                        if (parcela_todos[row.Index].PCA_ITEM == cheque_pagar.CHP_ITEM)
                        {
                            cheque_pagar.CHP_CARNE = contas_pagar.CAP_CODIGO;
                            cheque_pagar.CHP_NUM_DOC = parcela_todos[row.Index].PCA_NUM_DOC;
                            cheque_pagar.CHP_VALOR = parcela_todos[row.Index].PCA_VALOR;
                            cheque_pagar.CHP_VENC = parcela_todos[row.Index].PCA_VENC;
                            cheque_pagar.CHP_OBS = parcela_todos[row.Index].PCA_OBS;
                            cheque_pagar.Salvar();
                            break;
                        }
                    }
                }
            }

            if (Configuracoes.Default.Mensagem_Gravar == true && Mensagem_Gravar == true)
            {
                if (tb_codigo.Text == string.Empty)
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Alteração efetuada com sucesso!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            tb_codigo.Text = contas_pagar.CAP_CODIGO.ToString();
            tb_codigo.Enabled = false;
            btn_excluir.Enabled = true;

            cb_fornecedor.Focus();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (cb_fornecedor.SelectedIndex == 0 || cb_fornecedor.Items.Count == 0)
            {
                MessageBox.Show("Fornecedor obrigatório!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_fornecedor.Focus();
            }
            else if (cb_lancamento.SelectedIndex == 0 || cb_lancamento.Items.Count == 0)
            {
                MessageBox.Show("Lançamento obrigatório!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_lancamento.Focus();
            }
            else if (float.Parse(tb_total_geral.Text) == 0)
            {
                MessageBox.Show("Total Geral precisa ser maior que zero!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_gerar.Focus();
            }
            else
            {
                Gravar(true);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();

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

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text));

                cb_fornecedor.Focus();
            }
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            Frm_Gerar_Parcelas form;
            if (tb_codigo.Text != "")
	        {
                form = new Frm_Gerar_Parcelas(parcela_todos, int.Parse(tb_codigo.Text), 0, 0, DateTime.Now);
	        }
            else
	        {
                form = new Frm_Gerar_Parcelas(new Parcelas_PagarCollection(), 0, 0, 0, DateTime.Now);
	        }
            form.Show();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (tb_compra.Text == "")
            {
                if (tb_codigo.Text != "" && MessageBox.Show("Deseja realmente excluir este contas a pagar?", "3Pratos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contas_Pagar contas_pagar = new Contas_Pagar(int.Parse(tb_codigo.Text));

                    if (contas_pagar.CAP_CODIGO > 0)
                    {
                        parcela_todos.Deletar(contas_pagar.CAP_CODIGO);
                        contas_pagar.Deletar();

                        Log log = new Log();
                        log.LOG_USUARIO = Global.FUN_CODIGO;
                        log.LOG_DATA = DateTime.Now;
                        log.LOG_TELA = this.Text;
                        log.LOG_DESCRICAO = "Excluiu o contas a pagar de código: " + contas_pagar.CAP_CODIGO.ToString() + " e fornecedor: " + cb_fornecedor.Text + ".";
                        log.Save();

                        Limpar();

                        if (Configuracoes.Default.Mensagem_Gravar == true)
                        {
                            MessageBox.Show("Exclusão efetuada com sucesso!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        cb_fornecedor.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Exclusão permitida apenas com o cancelamento da compra!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_parcelas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                ComboBox cb = (ComboBox)e.Control;

                cb.SelectedIndexChanged += new EventHandler(cb_SelectedIndexChanged);
            }
            catch (Exception) { }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(lbl_linha.Text) >= 0)
                {
                    Parcelas_Pagar parcela = parcela_todos[int.Parse(lbl_linha.Text)];
                    ComboBox cb = (ComboBox)sender;

                    if (parcela.PCA_ITEM > 0)
                    {
                        parcela.PCA_TIPO = int.Parse(cb.SelectedValue.ToString());
                        parcela_todos[int.Parse(lbl_linha.Text)] = parcela;
                        btn_cheque.Enabled = (parcela.PCA_TIPO == 3);
                    }
                }
            }
            catch (Exception) { }
        }

        private void dgv_parcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lbl_linha.Text = e.RowIndex.ToString();

                if (int.Parse(lbl_linha.Text) >= 0)
                {
                    btn_cheque.Enabled = (parcela_todos[int.Parse(lbl_linha.Text)].PCA_TIPO == 3);
                }
            }
        }

        private void btn_cheque_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbl_linha.Text) >= 0)
            {
                this.Enabled = false;
                bool encontrou = false;
                foreach (Cheques_Pagar cheque_pagar_foreach in cheque_pagar_todos)
                {
                    if (cheque_pagar_foreach.CHP_ITEM == (int.Parse(lbl_linha.Text) + 1))
                    {
                        cheque_pagar_foreach.CHP_NUM_DOC = parcela_todos[int.Parse(lbl_linha.Text)].PCA_NUM_DOC;
                        cheque_pagar_foreach.CHP_VALOR = parcela_todos[int.Parse(lbl_linha.Text)].PCA_VALOR;
                        cheque_pagar_foreach.CHP_VENC = parcela_todos[int.Parse(lbl_linha.Text)].PCA_VENC;
                        cheque_pagar_foreach.CHP_OBS = parcela_todos[int.Parse(lbl_linha.Text)].PCA_OBS;
                        encontrou = true;
                        break;
                    }
                }
                if (encontrou == false)
                {
                    Cheques_Pagar cheque_pagar = new Cheques_Pagar();
                    cheque_pagar.CHP_CODIGO = 0;
                    cheque_pagar.CHP_ITEM = (int.Parse(lbl_linha.Text) + 1);
                    cheque_pagar.CHP_CARNE = 0;
                    cheque_pagar.CHP_CONTA = "";
                    cheque_pagar.CHP_BANCO = "";
                    cheque_pagar.CHP_AGENCIA = "";
                    cheque_pagar.CHP_EMISSAO = DateTime.Today;
                    cheque_pagar.CHP_EFETIVACAO = parcela_todos[int.Parse(lbl_linha.Text)].PCA_VENC;
                    cheque_pagar.CHP_NUM_DOC = parcela_todos[int.Parse(lbl_linha.Text)].PCA_NUM_DOC;
                    cheque_pagar.CHP_VALOR = parcela_todos[int.Parse(lbl_linha.Text)].PCA_VALOR;
                    cheque_pagar.CHP_VENC = parcela_todos[int.Parse(lbl_linha.Text)].PCA_VENC;
                    cheque_pagar.CHP_OBS = parcela_todos[int.Parse(lbl_linha.Text)].PCA_OBS;
                    cheque_pagar_todos.Add(cheque_pagar);
                }

                Frm_Gerar_Cheques form = new Frm_Gerar_Cheques(cheque_pagar_todos, (int.Parse(lbl_linha.Text) + 1));
                form.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma parcela cheque antes!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_parcelas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && int.Parse(lbl_linha.Text) >= 0)
            {
                if (parcela_todos[int.Parse(lbl_linha.Text)].PCA_VALOR_PAGO > 0)
                {
                    MessageBox.Show("Impossível excluir parcela já paga! É necessário estorná-la antes.", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (parcela_todos[int.Parse(lbl_linha.Text)].PCA_ITEM_NOVA_PARC > 0)
                {
                    MessageBox.Show("Impossível excluir parcela parcial! É necessário excluir a parcela " + parcela_todos[int.Parse(lbl_linha.Text)].PCA_ITEM_NOVA_PARC.ToString() + " antes.", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Deseja realmente excluir esta parcela?", "3Pratos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Parcelas_PagarCollection parcela_todos_temp = new Parcelas_PagarCollection();
                    Cheques_PagarCollection cheque_pagar_todos_temp = new Cheques_PagarCollection();
                    int PCA_ITEM = 1;

                    foreach (Cheques_Pagar cheque_pagar in cheque_pagar_todos)
                    {
                        cheque_pagar_todos_temp.Add(cheque_pagar);
                    }
                    cheque_pagar_todos.Clear();

                    foreach (Parcelas_Pagar parcela in parcela_todos)
                    {
                        if (parcela.PCA_ITEM != (int.Parse(lbl_linha.Text) + 1))
                        {
                            parcela.PCA_ITEM = PCA_ITEM++;
                            if (parcela.PCA_ITEM_NOVA_PARC == (int.Parse(lbl_linha.Text) + 1))
                            {
                                parcela.PCA_ITEM_NOVA_PARC = 0;
                            }
                            parcela_todos_temp.Add(parcela);

                            if (parcela.PCA_TIPO == 3)
                            {
                                foreach (Cheques_Pagar cheque_pagar in cheque_pagar_todos_temp)
                                {
                                    if (parcela.PCA_ITEM == cheque_pagar.CHP_ITEM)
                                    {
                                        cheque_pagar_todos.Add(cheque_pagar);
                                    }
                                }
                            }
                        }
                    }
                    Carregar_Grid(parcela_todos_temp);
                }
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Frm_Proc_Contas_Pagar form = new Frm_Proc_Contas_Pagar();
            form.Show();

            this.Hide();
        }
    }
}