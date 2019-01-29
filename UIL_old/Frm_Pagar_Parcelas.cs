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
    public partial class Frm_Pagar_Parcelas : Form
    {
        public Parcelas_Pagar parcela = new Parcelas_Pagar();
        public Cheques_Pagar cheque_pagar = new Cheques_Pagar();

        public Frm_Pagar_Parcelas(int PCA_CARNE, int PCA_ITEM)
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Pagar Parcelas");
            Limpar();

            parcela = new Parcelas_Pagar(PCA_CARNE, PCA_ITEM);
            cheque_pagar = new Cheques_Pagar(PCA_CARNE, PCA_ITEM);

            Carregar_Cadastro();

            rb_completa.Select();
        }

        private string Titulo_Tela(string tela)
        {
            return "3Pratos - Tela: " + tela;
        }

        private void Carregar_Cadastro()
        {
            Parcelas_PagarCollection parcela_todos = new Parcelas_PagarCollection(parcela.PCA_CARNE);
            tb_valor.Text = parcela.PCA_VALOR.ToString("0.00");
            tb_venc_nova_parc.Text = parcela_todos[parcela_todos.Count - 1].PCA_VENC.AddMonths(1).ToString("dd/MM/yyyy");
            tb_obs.Text = parcela.PCA_OBS;

            Calcular_Multa();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (tb_valor.Text == "")
            {
                tb_valor.Text = "0,00";
            }
            if (float.Parse(tb_valor.Text) == 0)
            {
                MessageBox.Show("Valor precisa ser maior que zero!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_valor.Focus();
            }
            else if (rb_completa.Checked && float.Parse(tb_valor.Text) < parcela.PCA_VALOR)
            {
                MessageBox.Show("Valor pago precisa ser maior/igual que o valor total, em caso de pagamento completo!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_valor.Focus();
            }
            else if (rb_nova_parc.Checked && float.Parse(tb_valor.Text) == parcela.PCA_VALOR)
            {
                MessageBox.Show("Valor pago precisa ser menor que o valor total, em caso de pagamento com nova parcela!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_valor.Focus();
            }
            else
            {
                Contas_Pagar contas_pagar = new Contas_Pagar(parcela.PCA_CARNE);
                Fornecedor fornecedor = new Fornecedor(contas_pagar.CAP_FORNECEDOR);

                if (rb_nova_parc.Checked)
                {
                    Parcelas_PagarCollection parcela_todos = new Parcelas_PagarCollection(parcela.PCA_CARNE);
                    Parcelas_Pagar parcela_nova = new Parcelas_Pagar();

                    if (tb_valor_nova_parc.Text == "")
                    {
                        tb_valor_nova_parc.Text = "0,00";
                    }
                    parcela_nova.PCA_CARNE = parcela.PCA_CARNE;
                    parcela_nova.PCA_ITEM = parcela_todos.Count + 1;
                    parcela_nova.PCA_DATA_PAGTO = DateTime.Parse("01/01/1800");
                    parcela_nova.PCA_NUM_DOC = "";
                    parcela_nova.PCA_OBS = "Parcela gerada apartir do pagto parcial da parcela " + parcela.PCA_ITEM.ToString();
                    parcela_nova.PCA_TIPO = cb_tipo_nova_parc.SelectedIndex;
                    parcela_nova.PCA_VALOR = float.Parse(tb_valor_nova_parc.Text);
                    parcela_nova.PCA_VALOR_PAGO = 0;
                    parcela_nova.PCA_VENC = DateTime.Parse(tb_venc_nova_parc.Text);
                    parcela_nova.Salvar();

                    contas_pagar.CAP_TOTAL += float.Parse(tb_valor_nova_parc.Text);
                    parcela.PCA_ITEM_NOVA_PARC = parcela_nova.PCA_ITEM;
                }
                contas_pagar.CAP_TOTAL -= parcela.PCA_VALOR;
                contas_pagar.CAP_TOTAL += float.Parse(tb_valor.Text);
                contas_pagar.Salvar();

                parcela.PCA_VALOR_PAGO = float.Parse(tb_valor.Text);
                parcela.PCA_DATA_PAGTO = DateTime.Now;
                parcela.PCA_OBS = tb_obs.Text;
                parcela.Deletar();
                parcela.Salvar();

                if (cheque_pagar.CHP_CODIGO > 0 && parcela.PCA_TIPO == 3)
                {
                    cheque_pagar.CHP_VALOR = float.Parse(tb_valor.Text);
                    cheque_pagar.CHP_OBS = tb_obs.Text;
                    cheque_pagar.Salvar();
                }
                Log log = new Log();
                log.LOG_USUARIO = Global.FUN_CODIGO;
                log.LOG_DATA = DateTime.Now;
                log.LOG_TELA = this.Text;
                if (rb_completa.Checked)
                {
                    log.LOG_DESCRICAO = "Baixou o pagamento completo da parcela: " + parcela.PCA_ITEM.ToString() + " e carnê: " + parcela.PCA_CARNE.ToString() + " no valor: " + parcela.PCA_VALOR_PAGO_FORMATADO + " do fornecedor: " + fornecedor.FOR_NOME + ".";
                }
                else
                {
                    log.LOG_DESCRICAO = "Baixou o pagamento parcial da parcela: " + parcela.PCA_ITEM.ToString() + " e carnê: " + parcela.PCA_CARNE.ToString() + " no valor: " + parcela.PCA_VALOR_PAGO_FORMATADO + " do fornecedor: " + fornecedor.FOR_NOME + ".";
                }
                log.Save();

                this.Close();
            }
        }

        private void Frm_Pagar_Parcelas_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form_aberto in Application.OpenForms)
            {
                if (form_aberto.Text.Contains("Pagamento das Parcelas a Pagar"))
                {
                    Frm_Pagto_Pagar form = (Frm_Pagto_Pagar)form_aberto;

                    form.Enabled = true;
                    form.Carregar_DGV();
                }
            }
        }

        private void Limpar()
        {
            rb_completa.Checked = false;
            rb_nova_parc.Checked = false;
            tb_valor_nova_parc.Enabled = false;
            cb_tipo_nova_parc.Enabled = false;
            tb_venc_nova_parc.Enabled = false;
            tb_valor.Text = "0,00";
            tb_multa.Text = "0,00";
            tb_valor_nova_parc.Text = "0,00";
            cb_tipo_nova_parc.SelectedIndex = 0;
            tb_venc_nova_parc.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_obs.Text = "";
        }

        private void Calcular_Multa()
        {
            float multa = float.Parse(tb_valor.Text) - parcela.PCA_VALOR;
            float valor_nova_parc = parcela.PCA_VALOR - float.Parse(tb_valor.Text);

            if (multa > 0)
            {
                tb_multa.Text = multa.ToString("0.00");
            }
            else
            {
                tb_multa.Text = "0,00";
            }
            if (rb_nova_parc.Checked)
            {
                tb_valor_nova_parc.Text = valor_nova_parc.ToString("0.00");
            }
            else
            {
                tb_valor_nova_parc.Text = "0,00";
            }
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != ",";
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
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_completa.Checked)
            {
                tb_valor_nova_parc.Enabled = false;
                cb_tipo_nova_parc.Enabled = false;
                tb_venc_nova_parc.Enabled = false;
            }
            else
            {
                tb_valor_nova_parc.Enabled = true;
                cb_tipo_nova_parc.Enabled = true;
                tb_venc_nova_parc.Enabled = true;
            }
        }

        private void tb_valor_Leave(object sender, EventArgs e)
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
            Calcular_Multa();
        }
    }
}