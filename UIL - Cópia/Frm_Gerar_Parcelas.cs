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
    public partial class Frm_Gerar_Parcelas : Form
    {
        public Parcelas_PagarCollection parcela_todos = new Parcelas_PagarCollection();
        public int PCA_CARNE = 0;
        public int ORIGEM = 0;
        public float CAP_TOTAL = 0;
        public float PCA_ACRESCIMO = 0;
        public float PCA_DESCONTO = 0;
        public DateTime PCA_VENC = DateTime.Now;

        public Frm_Gerar_Parcelas(Parcelas_PagarCollection parcela_todos_temp, int PCA_CARNE_TEMP, int ORIGEM_TEMP, float CAP_TOTAL_TEMP, float PCA_ACRESCIMO_TEMP, float PCA_DESCONTO_TEMP, DateTime PCA_VENC_TEMP, string COM_NF)
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Gerar Parcelas");

            parcela_todos = new Parcelas_PagarCollection();
            PCA_CARNE = PCA_CARNE_TEMP;
            ORIGEM = ORIGEM_TEMP;
            CAP_TOTAL = CAP_TOTAL_TEMP;
            PCA_ACRESCIMO = PCA_ACRESCIMO_TEMP;
            PCA_DESCONTO = PCA_DESCONTO_TEMP;
            PCA_VENC = PCA_VENC_TEMP;
            tb_nf.Text = COM_NF;

            Limpar();

            foreach (Parcelas_Pagar parcela in parcela_todos_temp)
            {
                parcela_todos.Add(parcela);
            }
            if (CAP_TOTAL > 0)
            {
                tb_valor.Enabled = false;
                tb_desc.Enabled = false;
                tb_acresc.Enabled = false;
            }
            else
            {
                tb_valor.Enabled = true;
                tb_desc.Enabled = true;
                tb_acresc.Enabled = true;
            }
            tb_nf.Select();
        }

        private void Limpar()
        {
            tb_valor.Text = CAP_TOTAL.ToString("0.00");
            tb_desc.Text = PCA_DESCONTO.ToString("0.00");
            tb_acresc.Text = PCA_ACRESCIMO.ToString("0.00");
            cb_tipo.SelectedIndex = 0;
            cb_intervalo.SelectedIndex = 0;
            tb_venc_1parc.Text = PCA_VENC.ToString("dd/MM/yyyy");
            tb_parcelas.Text = "1";
            tb_qtde.Text = "1";
        }

        public string Titulo_Tela(string tela)
        {
            return "Joincar - Tela: " + tela;
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            if (tb_valor.Text == "")
            {
                tb_valor.Text = "0,00";
            }
            if (tb_parcelas.Text == "")
            {
                tb_parcelas.Text = "1";
            }
            if (tb_qtde.Text == "")
            {
                tb_qtde.Text = "1";
            }
            if (float.Parse(tb_valor.Text) == 0)
            {
                MessageBox.Show("Valor precisa ser maior que zero!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_valor.Focus();
            }
            else
            {
                float valor_total = float.Parse(tb_valor.Text);
                float valor_gerado = 0;
                float acresc_total = float.Parse(tb_acresc.Text);
                float acresc_gerado = 0;
                float desc_total = float.Parse(tb_desc.Text);
                float desc_gerado = 0;
                DateTime vencimento = DateTime.Parse(tb_venc_1parc.Text);
                Parcelas_Pagar parcela;

                for (int i = 1; i <= int.Parse(tb_parcelas.Text); i++)
                {
                    parcela = new Parcelas_Pagar();
                    parcela.PCA_CARNE = 0;
                    parcela.PCA_ITEM = parcela_todos.Count + 1;
                    parcela.PCA_ITEM_NOVA_PARC = 0;
                    parcela.PCA_DATA_PAGTO = DateTime.Parse("01/01/1800");
                    if (tb_nf.Text.Length > 0)
                    {
                        parcela.PCA_NUM_DOC = tb_nf.Text + "-" + parcela.PCA_ITEM.ToString();
                    }
                    else
                    {
                        parcela.PCA_NUM_DOC = "";
                    }
                    parcela.PCA_OBS = tb_obs.Text;
                    parcela.PCA_TIPO = cb_tipo.SelectedIndex;

                    if (i == int.Parse(tb_parcelas.Text))
                    {
                        parcela.PCA_VALOR = valor_total - valor_gerado;
                        parcela.PCA_DESCONTO = desc_total - desc_gerado;
                        parcela.PCA_ACRESCIMO = acresc_total - acresc_gerado;
                    }
                    else
                    {
                        parcela.PCA_VALOR = valor_total / int.Parse(tb_parcelas.Text);
                        parcela.PCA_DESCONTO = desc_total / int.Parse(tb_parcelas.Text);
                        parcela.PCA_ACRESCIMO = acresc_total / int.Parse(tb_parcelas.Text);
                    }
                    valor_gerado += parcela.PCA_VALOR;
                    desc_gerado += parcela.PCA_DESCONTO;
                    acresc_gerado += parcela.PCA_ACRESCIMO;

                    parcela.PCA_VALOR_PAGO = 0;
                    parcela.PCA_VENC = vencimento;
                    if (cb_intervalo.SelectedIndex == 0)
                    {
                        vencimento = vencimento.AddMonths(int.Parse(tb_qtde.Text));
                    }
                    else
                    {
                        vencimento = vencimento.AddDays(int.Parse(tb_qtde.Text));
                    }
                    parcela_todos.Add(parcela);
                }
                //Se for compra, concretiza-la
                if (ORIGEM == 1)
                {
                    ORIGEM = 2;
                }
                this.Close();
            }
        }

        private void Frm_Gerar_Parcelas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ORIGEM == 0)
            {
                foreach (Form form_aberto in Application.OpenForms)
                {
                    if (form_aberto.Text.Contains("Cadastro do Contas a Pagar"))
                    {
                        Frm_Contas_Pagar form = (Frm_Contas_Pagar)form_aberto;

                        form.Enabled = true;
                        if (parcela_todos.Count > 0)
                        {
                            form.btn_cheque.Enabled = false;
                            if (PCA_CARNE == 0)
                            {
                                form.cheque_pagar_todos = new Cheques_PagarCollection();
                            }
                            form.Carregar_Grid(parcela_todos);
                        }
                    }
                }
            }
            else
            {
                foreach (Form form_aberto in Application.OpenForms)
                {
                    if (form_aberto.Text.Contains("Cadastro de Compra"))
                    {
                        Frm_Compra form = (Frm_Compra)form_aberto;

                        form.Enabled = true;
                        if (ORIGEM == 2)
                        {
                            form.Gravar(false);
                            Frm_Contas_Pagar form_abrir = new Frm_Contas_Pagar(0);
                            form_abrir.Enabled = true;
                            if (parcela_todos.Count > 0)
                            {
                                form_abrir.btn_cheque.Enabled = false;
                                if (PCA_CARNE == 0)
                                {
                                    form_abrir.cheque_pagar_todos = new Cheques_PagarCollection();
                                }
                                form_abrir.Carregar_Grid(parcela_todos);
                                form_abrir.Construir(int.Parse(form.tb_codigo.Text));
                            }
                            //A Joincar solicitou que ao gravar a compra mantesse na tela da compra
                            //form.Hide();
                            //form_abrir.Show();
                            form_abrir.Close();
                        }
                        break;
                    }
                }
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }
    }
}