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
    public partial class FrmClientes : Frm_Master
    {
        public FrmClientes()
        {
            InitializeComponent();
            
            tb_UF.Enabled = false;

            this.Text = Titulo_Tela("Cadastro de Cliente");
            gb_cliente.Text = Titulo_Grupo("Cadastro");

            cb_status.SelectedIndex = 0;
            Carrega_Cidade();
            Busca_UF();
            tb_cadastro.Text = DateTime.Now.ToShortDateString();

            if (Global.CLI_CODIGO > 0)
            {
                Carregar_Cadastro(Global.CLI_CODIGO);
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
            CidadeCollection cidade_todos = new CidadeCollection(true);
            cb_cidade.DataSource = cidade_todos;
            cb_cidade.DisplayMember = "CID_NOME";
            cb_cidade.ValueMember = "CID_CODIGO";

            cb_cidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_cidade.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void Limpar()
        {
            tb_nome.Text = "";
            tb_logradouro.Text = "";
            tb_cep.Text = "";
            tb_obs.Text = "";
            tb_bairro.Text = "";
            tb_telefone.Text = "";
            tb_celular.Text = "";
            tb_cadastro.Text = "";
            tb_email.Text = "";
            tb_contato.Text = "";
            tb_cadastro.Text = DateTime.Now.ToShortDateString();
            cb_pessoa.SelectedIndex = 0;
            cb_cidade.SelectedIndex = 0;
            tb_UF.Text = "";
            tb_cpf_cnpj.Text = "";
            tb_ie_ci.Text = "";
            tb_fantasia.Text = "";
            tb_codigo.Text = "";

            tb_codigo.Enabled = true;
        }

        private void Carregar_Cadastro(int CLI_CODIGO)
        {
            Cliente cliente = new Cliente(CLI_CODIGO);

            if (cliente.CLI_CODIGO > 0)
            {
                tb_codigo.Text = cliente.CLI_CODIGO.ToString();
                tb_nome.Text = cliente.CLI_NOME;
                tb_logradouro.Text = cliente.CLI_LOGRADOURO;
                tb_cep.Text = cliente.CLI_CEP;
                tb_obs.Text = cliente.CLI_OBS;
                tb_bairro.Text = cliente.CLI_BAIRRO;
                tb_telefone.Text = cliente.CLI_FONE;
                tb_celular.Text = cliente.CLI_CELULAR;
                tb_contato.Text = cliente.CLI_CONTATO;
                tb_email.Text = cliente.CLI_EMAIL;
                tb_cadastro.Text = cliente.CLI_CADASTRO.ToShortDateString();
                tb_fantasia.Text = cliente.CLI_FANTASIA;
                tb_ie_ci.Text = cliente.CLI_INSC_ESTADUAL;
                tb_cpf_cnpj.Text = cliente.CLI_CPF_CNPJ;
                cb_pessoa.SelectedIndex = cliente.CLI_PESSOA;
                cb_cidade.SelectedValue = cliente.CLI_CIDADE_CID_CODIGO;

                tb_codigo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_codigo.Text = string.Empty;
            }
        }

        private void cb_pessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_pessoa.SelectedIndex == 1)
            {
                lbl_cnpj_cpf.Text = "C.N.P.J        :";
                                   
                lbl_ie_ci.Text    = "Inscr. Estadual:";
                tb_cpf_cnpj.Mask = "99,999,999/9999-99";
            }
            else
            {
                lbl_cnpj_cpf.Text = "CPF       :";
                lbl_ie_ci.Text    = "Cart.Ident:"; 
                tb_cpf_cnpj.Mask = "999,999,999-99";
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            FrmProcClientes form = new FrmProcClientes();

            form.Show();
            this.Hide();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmProcClientes form = new FrmProcClientes();

            form.Show();
            this.Hide();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == string.Empty)
            {
                MessageBox.Show("Descrição obrigatória!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nome.Focus();
            }
            //else
            //    if (tb_codigo.Text == string.Empty)
            //    {                                                                                                                        //0_CLI_CODIGO;   
            //        MessageBox.Show("Código obrigatório!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    //1_CLI_CIDADE;
            //        tb_nome.Focus();                                                                                                     //2_CLI_INATIVO;
            //    }                                                                                                                        //3_CLI_PESSOA;
                else                                                                                                                     //4_CLI_CEP;
                {                                                                                                                        //5_CLI_NOME;
                    Cliente cliente;                                                                                                     //6_CLI_FANTASIA;
                                                                                                                                         //7_CLI_BAIRRO;
                    if (tb_codigo.Text == string.Empty)                                                                                  //8_CLI_LOGRADOURO;
                    {                                                                                                                    //9_CLI_FONE;
                        cliente = new Cliente();
                        cliente.CLI_CODIGO = 0;                                                                                   //10_CLI_celular  
                    }                                                                                                                    //11 _CLI_email
                    else                                                                                                                 //12_CLI_CONTATO;
                    {                                                                                                                    //13_CLI_CPF_CNPJ;
                        cliente = new Cliente(int.Parse(tb_codigo.Text));
                        cliente.CLI_CODIGO = int.Parse(tb_codigo.Text);                                                             //14_CLI_INSC_ESTADUAL
                    }                                                                                                                    //15_CLI_OBS;
                                                                                                                                         //16_CLI_CADASTRO;    
                    cliente.CLI_NOME = tb_nome.Text;
                    cliente.CLI_CIDADE = new Cidade(int.Parse(cb_cidade.SelectedValue.ToString()));
                    cliente.CLI_INATIVO = cb_status.SelectedIndex;
                    cliente.CLI_LOGRADOURO = tb_logradouro.Text;
                    cliente.CLI_CEP = tb_cep.Text;
                    cliente.CLI_OBS = tb_obs.Text;
                    cliente.CLI_BAIRRO = tb_bairro.Text;
                    cliente.CLI_FONE = tb_telefone.Text;
                    cliente.CLI_CELULAR = tb_celular.Text;
                    cliente.CLI_CONTATO = tb_contato.Text;
                    cliente.CLI_CADASTRO = DateTime.Parse(tb_cadastro.Text);
                    cliente.CLI_PESSOA = cb_pessoa.SelectedIndex;
                    cliente.CLI_EMAIL = tb_email.Text;
                    cliente.CLI_CPF_CNPJ = tb_cpf_cnpj.Text;
                    cliente.CLI_INSC_ESTADUAL = tb_ie_ci.Text;
                    cliente.CLI_FANTASIA = tb_fantasia.Text;
                    cliente.Salvar();

                    Log log = new Log();
                    log.LOG_USUARIO = Global.FUN_CODIGO;
                    log.LOG_DATA = DateTime.Now;
                    log.LOG_TELA = this.Text;
                    if (tb_codigo.Text == string.Empty)
                    {
                        log.LOG_DESCRICAO = "Cadastrou o cliente de código: " + cliente.CLI_CODIGO.ToString() + " e nome: " + cliente.CLI_NOME + ".";
                    }
                    else
                    {
                        log.LOG_DESCRICAO = "Alterou o cliente de código: " + cliente.CLI_CODIGO.ToString() + " e nome: " + cliente.CLI_NOME + ".";
                    }
                    log.Save();

                    if (Configuracoes.Default.Mensagem_Gravar == true)
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

                    tb_codigo.Text = cliente.CLI_CODIGO.ToString();
                    tb_codigo.Enabled = false;

                    tb_nome.Focus();
                }
        }

        private void cb_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Busca_UF();
        }
    }
}
