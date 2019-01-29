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
    public partial class FrmFornecedores : Frm_Master
    {
        public FrmFornecedores()
        {
            InitializeComponent();
            
            tb_UF.Enabled = false;
            tb_ulltimacompra.Enabled = false;

            this.Text = Titulo_Tela("Cadastro de Fornecedor");
            gb_fornecedor.Text = Titulo_Grupo("Cadastro");

            tb_cadastro.Text = DateTime.Now.ToShortDateString();
          
            cb_status.SelectedIndex = 0;
            Carrega_Cidade();
            Busca_UF();

            if (Global.FOR_CODIGO > 0)
            {
                Carregar_Cadastro(Global.FOR_CODIGO);
            }
            tb_nome.Select();
        }

        private void Busca_UF() 
        {
            try
            {
                Cidade buscaUF = new Cidade(int.Parse(cb_cidade.SelectedValue.ToString()));
                tb_UF.Text = buscaUF.CID_UF;
            }
            catch { tb_UF.Text = ""; }
        }

        private void Carrega_Cidade()
        {
            CidadeCollection cidade_todos = new CidadeCollection(true, 1);
            cb_cidade.DataSource = cidade_todos;
            cb_cidade.DisplayMember = "CID_NOME";
            cb_cidade.ValueMember = "CID_ID";
            cb_cidade.Select();

            cb_cidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_cidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_cidade.Focus();

        }

        private void Carregar_Cadastro(int FOR_CODIGO)
        {
            Fornecedor fornecedor = new Fornecedor(FOR_CODIGO);

            if (fornecedor.FOR_CODIGO > 0)
            {
                tb_codigo.Text = fornecedor.FOR_CODIGO.ToString();
                tb_nome.Text = fornecedor.FOR_NOME.ToUpper();
                tb_logradouro.Text = fornecedor.FOR_LOGRADOURO.ToUpper();
                tb_cep.Text = fornecedor.FOR_CEP;
                tb_obs.Text = fornecedor.FOR_OBS.ToUpper();
                tb_bairro.Text = fornecedor.FOR_BAIRRO.ToUpper();
                tb_telefone.Text = fornecedor.FOR_FONE;
                tb_celular.Text = fornecedor.FOR_CELULAR;
                tb_contato.Text = fornecedor.FOR_CONTATO.ToUpper();
                tb_email.Text = fornecedor.FOR_EMAIL;
                tb_cadastro.Text = fornecedor.FOR_CADASTRO.ToShortDateString();
                cb_pessoa.SelectedIndex = fornecedor.FOR_PESSOA;
                tb_ie_ci.Text = fornecedor.FOR_INSC_ESTADUAL;
                tb_cgc_cpf.Text = fornecedor.FOR_CPF_CNPJ;
                cb_cidade.SelectedValue = fornecedor.FOR_CIDADE_CID_CODIGO;

                if (fornecedor.FOR_ULT_COMPRA > 0)
                {
                    Compra compra = new Compra(fornecedor.FOR_ULT_COMPRA,0);

                    if (compra.COM_CODIGO > 0)
                    {
                        tb_ulltimacompra.Text = compra.COM_DATA.ToString("dd/MM/yyyy");
                    }
                }

                tb_codigo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_codigo.Text = string.Empty;
            }
        }

        private void tb_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text));

                tb_nome.Focus();
            }
        }

        private void tb_codigo_Leave(object sender, EventArgs e)
        {
            if (tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text));

                tb_nome.Focus();
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == string.Empty)
            {
                MessageBox.Show("Descrição obrigatória!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nome.Focus();
            }
            else
               
                {
                    Fornecedor fornecedor;

                    if (tb_codigo.Text == string.Empty)
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.FOR_ULT_COMPRA = 0;
                    }
                    else
                    {
                        fornecedor = new Fornecedor(int.Parse(tb_codigo.Text));
                        fornecedor.FOR_CODIGO = int.Parse(tb_codigo.Text);
                    }

                    fornecedor.FOR_NOME = tb_nome.Text.ToUpper();
                    fornecedor.FOR_CIDADE = new Cidade(int.Parse(cb_cidade.SelectedValue.ToString()));
                    fornecedor.FOR_INATIVO = cb_status.SelectedIndex;
                    fornecedor.FOR_LOGRADOURO = tb_logradouro.Text.ToUpper();
                    fornecedor.FOR_CEP = tb_cep.Text;
                    fornecedor.FOR_OBS = tb_obs.Text.ToUpper();
                    fornecedor.FOR_BAIRRO = tb_bairro.Text.ToUpper();
                    fornecedor.FOR_FONE = tb_telefone.Text;
                    fornecedor.FOR_CELULAR = tb_celular.Text;
                    fornecedor.FOR_CONTATO = tb_contato.Text.ToUpper();
                    fornecedor.FOR_CADASTRO = DateTime.Parse(tb_cadastro.Text);
                    fornecedor.FOR_PESSOA = cb_pessoa.SelectedIndex;
                    fornecedor.FOR_EMAIL = tb_email.Text;
                    fornecedor.FOR_INSC_ESTADUAL = tb_ie_ci.Text;
                    fornecedor.FOR_CPF_CNPJ      = tb_cgc_cpf.Text;
                    fornecedor.Salvar();

                    Log log = new Log();
                    log.LOG_USUARIO = Global.FUN_CODIGO;
                    log.LOG_DATA = DateTime.Now;
                    log.LOG_TELA = this.Text;
                    if (tb_codigo.Text == string.Empty)
                    {
                        log.LOG_DESCRICAO = "Cadastrou o fornecedor de código: " + fornecedor.FOR_CODIGO.ToString() + " e nome: " + fornecedor.FOR_NOME + ".";
                    }
                    else
                    {
                        log.LOG_DESCRICAO = "Alterou o fornecedor de código: " + fornecedor.FOR_CODIGO.ToString() + " e nome: " + fornecedor.FOR_NOME + ".";
                    }
                    log.Save();

                    if (Configuracoes.Default.Mensagem_Gravar == true)
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

                    tb_codigo.Text = fornecedor.FOR_CODIGO.ToString();
                    tb_codigo.Enabled = false;

                    tb_nome.Focus();
                }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            FrmProcFornecedores form = new FrmProcFornecedores();

            form.Show();
            this.Hide();
        }

        private void cb_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Busca_UF();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmProcFornecedores form = new FrmProcFornecedores();

            form.Show();
            this.Hide();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar() 
        {
           tb_nome.Text            = "";
           tb_logradouro.Text      = "";
           tb_cep.Text             = "";
           tb_obs.Text             = "";
           tb_bairro.Text          = "";
           tb_telefone.Text        = "";
           tb_ulltimacompra.Text   = "";
           tb_celular.Text         = "";
           tb_cadastro.Text        = "";
           tb_email.Text           = "";
           tb_cadastro.Text        = DateTime.Now.ToShortDateString();
           tb_cadastro.Text        = "";
           tb_ie_ci.Text           = "";
           tb_ie_ci.Text           = "";
           tb_cgc_cpf.Text         = "";
           tb_codigo.Text          = "";
           cb_pessoa.SelectedIndex = 0;
           cb_cidade.SelectedIndex = 0;
           tb_UF.Text = "";

           tb_codigo.Enabled = true;
        }

        private void cb_pessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_pessoa.SelectedIndex == 1)
            {
                lbl_cnpj_cpf.Text = "C.N.P.J        :";

                lbl_ie_ci.Text    = "Inscr. Estadual:";
                tb_cgc_cpf.Mask = "99,999,999/9999-99";
            }
            else
            {
                lbl_cnpj_cpf.Text = "CPF       :";
                lbl_ie_ci.Text    = "Cart.Ident:";
                tb_cgc_cpf.Mask = "999,999,999-99";
            }
        }

        private void Carregar_DGV()
        {

        }

        private void buscar_cep(object sender, MouseEventArgs e)
        {
            string cidade = cb_cidade.Text;
            string bairro = tb_bairro.Text;
            string rua = tb_logradouro.Text;

            buscaCep cep = new buscaCep(cidade, bairro, rua, "FrmFornecedores");
            cep.Show();
        }
    }
}

       

