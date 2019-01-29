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
    public partial class Frm_Gerar_Cheques : Form
    {
        public Cheques_PagarCollection cheque_pagar_todos = new Cheques_PagarCollection();
        public int CHP_ITEM = 0;

        public Frm_Gerar_Cheques(Cheques_PagarCollection cheque_pagar_todos_temp, int CHP_ITEM_TEMP)
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Gerar Cheques");
            Limpar();

            cheque_pagar_todos = new Cheques_PagarCollection();
            CHP_ITEM = CHP_ITEM_TEMP;
            foreach (Cheques_Pagar cheque_pagar in cheque_pagar_todos_temp)
            {
                cheque_pagar_todos.Add(cheque_pagar);
            }

            Carregar_Cadastro();

            tb_conta.Select();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_gerar_Click(object sender, EventArgs e)
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
            else
            {
                foreach (Cheques_Pagar cheque_pagar in cheque_pagar_todos)
                {
                    if (cheque_pagar.CHP_ITEM == CHP_ITEM)
                    {
                        cheque_pagar.CHP_CONTA = tb_conta.Text;
                        cheque_pagar.CHP_BANCO = tb_banco.Text;
                        cheque_pagar.CHP_AGENCIA = tb_agencia.Text;
                        cheque_pagar.CHP_NUM_DOC = tb_num_doc.Text;
                        try
                        {
                            cheque_pagar.CHP_VALOR = float.Parse(tb_valor.Text);
                        }
                        catch (Exception)
                        {
                            cheque_pagar.CHP_VALOR = 0;
                        }
                        try
                        {
                            cheque_pagar.CHP_EMISSAO = DateTime.Parse(tb_emissao.Text);
                        }
                        catch (Exception)
                        {
                            cheque_pagar.CHP_EMISSAO = DateTime.Today;
                        }
                        try
                        {
                            cheque_pagar.CHP_VENC = DateTime.Parse(tb_venc.Text);
                        }
                        catch (Exception)
                        {
                            cheque_pagar.CHP_VENC = DateTime.Today;
                        }
                        try
                        {
                            cheque_pagar.CHP_EFETIVACAO = DateTime.Parse(tb_efetivacao.Text);
                        }
                        catch (Exception)
                        {
                            cheque_pagar.CHP_EFETIVACAO = DateTime.Today;
                        }
                        cheque_pagar.CHP_OBS = tb_obs.Text;
                        break;
                    }
                }
                this.Close();
            }
        }

        private void Frm_Gerar_Cheques_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form_aberto in Application.OpenForms)
            {
                if (form_aberto.Text.Contains("Cadastro do Contas a Pagar"))
                {
                    Frm_Contas_Pagar form = (Frm_Contas_Pagar)form_aberto;

                    form.Enabled = true;
                    form.cheque_pagar_todos = new Cheques_PagarCollection();
                    foreach (Cheques_Pagar cheque_pagar in cheque_pagar_todos)
                    {
                        form.cheque_pagar_todos.Add(cheque_pagar);

                        if (cheque_pagar.CHP_ITEM == CHP_ITEM)
                        {
                            //Para encontrar o item correto na lista de cheque é preciso usar um loop e ir comparando
                            //Já nas parcelas a lista segue a ordem precisamente, então dá pra buscá-la diretamente
                            form.parcela_todos[CHP_ITEM - 1].PCA_NUM_DOC = cheque_pagar.CHP_NUM_DOC;
                            form.parcela_todos[CHP_ITEM - 1].PCA_VALOR = cheque_pagar.CHP_VALOR;
                            form.parcela_todos[CHP_ITEM - 1].PCA_VENC = cheque_pagar.CHP_VENC;
                            form.parcela_todos[CHP_ITEM - 1].PCA_OBS = cheque_pagar.CHP_OBS;
                        }
                    }
                    form.btn_cheque.Enabled = false;
                    form.Carregar_Grid(form.parcela_todos);
                }
            }
        }

        public string Titulo_Tela(string tela)
        {
            return "3Pratos - Tela: " + tela;
        }

        private void Carregar_Cadastro()
        {
            foreach (Cheques_Pagar cheque_pagar in cheque_pagar_todos)
            {
                if (cheque_pagar.CHP_ITEM == CHP_ITEM)
                {
                    tb_conta.Text = cheque_pagar.CHP_CONTA;
                    tb_banco.Text = cheque_pagar.CHP_BANCO;
                    tb_agencia.Text = cheque_pagar.CHP_AGENCIA;
                    tb_num_doc.Text = cheque_pagar.CHP_NUM_DOC;
                    tb_valor.Text = cheque_pagar.CHP_VALOR.ToString("0.00");
                    tb_emissao.Text = cheque_pagar.CHP_EMISSAO.ToString("dd/MM/yyyy");
                    tb_venc.Text = cheque_pagar.CHP_VENC.ToString("dd/MM/yyyy");
                    tb_efetivacao.Text = cheque_pagar.CHP_EFETIVACAO.ToString("dd/MM/yyyy");
                    tb_obs.Text = cheque_pagar.CHP_OBS;
                    break;
                }
            }
        }

        public void Limpar()
        {
            tb_conta.Text = "";
            tb_banco.Text = "";
            tb_agencia.Text = "";
            tb_num_doc.Text = "";
            tb_valor.Text = "0,00";
            tb_emissao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_venc.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_efetivacao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_obs.Text = "";
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
    }
}