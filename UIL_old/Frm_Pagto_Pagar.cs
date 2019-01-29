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
    public partial class Frm_Pagto_Pagar : Frm_Master
    {
        public Frm_Pagto_Pagar()
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

            this.Text = Titulo_Tela("Pagamento das Parcelas a Pagar");
            gb_proc_contas_pagar.Text = Titulo_Grupo("Pagamento");

            dvg_parcelas.AutoGenerateColumns = false;

            cb_tipo.SelectedIndex = 1;
            tb_inicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_final.Text = DateTime.Now.ToString("dd/MM/yyyy");

            Carregar_DGV();

            cb_tipo.Select();
        }

        private void Esconder_Colunas()
        {
            dvg_parcelas.Columns["PCA_TIPO"].Visible = false;
            dvg_parcelas.Columns["PCA_VALOR"].Visible = false;
            dvg_parcelas.Columns["PCA_VALOR_PAGO"].Visible = false;
            dvg_parcelas.Columns["PCA_DATA_PAGTO"].Visible = false;
            dvg_parcelas.Columns["PCA_VENC"].Visible = false;
            dvg_parcelas.Columns["PCA_ITEM_NOVA_PARC"].Visible = false;
            if (cb_fornecedor.SelectedIndex > 0)
            {
                dvg_parcelas.Columns["FOR_NOME"].Visible = false;
            }
            else
            {
                dvg_parcelas.Columns["FOR_NOME"].Visible = true;
            }
            if (cb_tipo.SelectedIndex == 0)
            {
                dvg_parcelas.Columns["PCA_VALOR_FORMATADO"].Visible = false;
                dvg_parcelas.Columns["PCA_VENC_FORMATADO"].Visible = false;
            }
            else
	        {
                dvg_parcelas.Columns["PCA_VALOR_FORMATADO"].Visible = true;
                dvg_parcelas.Columns["PCA_VENC_FORMATADO"].Visible = true;
	        }
            if (cb_tipo.SelectedIndex == 1)
            {
                dvg_parcelas.Columns["PCA_VALOR_PAGO_FORMATADO"].Visible = false;
                dvg_parcelas.Columns["PCA_DATA_PAGTO_FORMATADO"].Visible = false;
            }
            else
            {
                dvg_parcelas.Columns["PCA_VALOR_PAGO_FORMATADO"].Visible = true;
                dvg_parcelas.Columns["PCA_DATA_PAGTO_FORMATADO"].Visible = true;
            }
        }

        public void Carregar_DGV()
        {
            DateTime data_inicial = DateTime.Parse("01/01/1800");
            DateTime data_final = DateTime.Parse("01/01/1800");

            try
            {
                data_inicial = DateTime.Parse(tb_inicio.Text);
            }
            catch (Exception)
            {
                try
                {
                    data_inicial = DateTime.Parse(tb_final.Text);
                }
                catch (Exception)
                {
                    data_inicial = DateTime.Parse("01/01/1800");
                }
            }
            try
            {
                data_final = DateTime.Parse(tb_final.Text);
            }
            catch (Exception)
            {
                try
                {
                    data_final = DateTime.Parse(tb_inicio.Text);
                }
                catch (Exception)
                {
                    data_final = DateTime.Parse("01/01/1800");
                }
            }

            Parcelas_PagarCollection parcelas_pagar_todos = new Parcelas_PagarCollection(cb_tipo.SelectedIndex, data_inicial, data_final, int.Parse(cb_fornecedor.SelectedValue.ToString()));

            dvg_parcelas.DataSource = parcelas_pagar_todos;

            Esconder_Colunas();
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dvg_parcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lbl_linha.Text = e.RowIndex.ToString();

                int PCA_CARNE = int.Parse(dvg_parcelas.Rows[e.RowIndex].Cells[0].Value.ToString());
                int PCA_ITEM = int.Parse(dvg_parcelas.Rows[e.RowIndex].Cells[1].Value.ToString());
                Parcelas_Pagar parcela = new Parcelas_Pagar(PCA_CARNE, PCA_ITEM);

                if (parcela.PCA_VALOR_PAGO > 0)
                {
                    if (parcela.PCA_ITEM_NOVA_PARC > 0)
                    {
                        MessageBox.Show("Impossível estornar parcela parcial! É necessário excluir parcela " + parcela.PCA_ITEM_NOVA_PARC.ToString() + " antes.", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (MessageBox.Show("Deseja realmente estornar esta parcela?", "3Pratos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Contas_Pagar contas_pagar = new Contas_Pagar(parcela.PCA_CARNE);
                        contas_pagar.CAP_TOTAL -= parcela.PCA_VALOR_PAGO;
                        contas_pagar.CAP_TOTAL += parcela.PCA_VALOR;
                        contas_pagar.Salvar();

                        parcela.PCA_VALOR_PAGO = 0;
                        parcela.PCA_DATA_PAGTO = DateTime.Parse("01/01/1800");
                        parcela.Deletar();
                        parcela.Salvar();

                        Fornecedor fornecedor = new Fornecedor(contas_pagar.CAP_FORNECEDOR);
                        Log log = new Log();
                        log.LOG_USUARIO = Global.FUN_CODIGO;
                        log.LOG_DATA = DateTime.Now;
                        log.LOG_TELA = this.Text;
                        log.LOG_DESCRICAO = "Estornou o pagamento da parcela: " + parcela.PCA_ITEM.ToString() + " e carnê: " + parcela.PCA_CARNE.ToString() + " no valor: " + parcela.PCA_VALOR_PAGO_FORMATADO + " do fornecedor: " + fornecedor.FOR_NOME + ".";
                        log.Save();

                        Carregar_DGV();

                        if (Configuracoes.Default.Mensagem_Gravar == true)
                        {
                            MessageBox.Show("Estorno efetuado com sucesso!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    this.Enabled = false;

                    Frm_Pagar_Parcelas form = new Frm_Pagar_Parcelas(PCA_CARNE, PCA_ITEM);
                    form.Show();
                }
            }
        }

        private void tb_inicio_Leave(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void tb_final_Leave(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void cb_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar_DGV();
        }
    }
}