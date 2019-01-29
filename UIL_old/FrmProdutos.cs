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
    public partial class FrmProdutos : Frm_Master
    {
        int grupoatual = 0;
        int ORIGEM = 0;

        public FrmProdutos(int ORIGEM_TEMP)
        {
            InitializeComponent();
            
            cb_status.SelectedIndex = 0;
            this.Text = Titulo_Tela("Cadastro de Produto");
            gb_produto.Text = Titulo_Grupo("Cadastro");
            ORIGEM = ORIGEM_TEMP;
            Global.PC_PRODUTO = 0;

            if (Global.PRO_CODIGO > 0)
            {
                Carregar_Cadastro(Global.PRO_CODIGO);
            }
            else 
            {
                Limpar();
            }
            Carrega_Grupo();
            tb_nome.Select();
        }

        private void Carrega_Grupo()
        {
            GrupoProdutoCollection grupo_todos = new GrupoProdutoCollection(true);
            cb_grupo.DataSource    = grupo_todos;
            cb_grupo.DisplayMember = "GRP_NOME";
            cb_grupo.ValueMember   = "GRP_CODIGO";
            Carrega_SubGrupo(grupoatual);
        }

        private void Carregar_Cadastro(int PRO_CODIGO)
        {
            Produto produto = new Produto(PRO_CODIGO);

            if (produto.PRO_CODIGO > 0)
            {
                tb_codigo.Text = produto.PRO_CODIGO.ToString();
                tb_nome.Text = produto.PRO_NOME;
                tb_estoqueatual.Text = produto.PRO_ESTOQUE.ToString("0.000");
                tb_estoqueminimo.Text = produto.PRO_EST_MINIMO.ToString("0.000");
                tb_obs.Text = produto.PRO_OBS;
                tb_precocompra.Text = produto.PRO_PRECO_COMPRA.ToString("0.00");
                tb_referencia.Text = produto.PRO_REFERENCIA;
                tb_unidade.Text = produto.PRO_UNIDADE;

                Carrega_Grupo();
                cb_grupo.SelectedValue = produto.PRO_GRUPO_GRP_CODIGO;
                Carrega_SubGrupo(produto.PRO_GRUPO_GRP_CODIGO);
                grupoatual = produto.PRO_GRUPO_GRP_CODIGO;

                if (produto.PRO_ULT_COMPRA > 0)
                {
                    Compra compra = new Compra(produto.PRO_ULT_COMPRA);

                    if (compra.COM_CODIGO > 0)
                    {
                        tb_ulltimacompra.Text = compra.COM_DATA.ToString("dd/MM/yyyy");
                    }
                }

                tb_codigo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_codigo.Text = string.Empty;
            }
        }

        private void Carrega_SubGrupo(int Grupo)
        {
            SubGrupo_ProdutosCollection subgrupo_todos = new SubGrupo_ProdutosCollection(SubGrupo_ProdutoLoadType.LoadBySubGrupo_LoadByGrupo, Grupo);
            cb_subgrupo.DataSource    = subgrupo_todos;
            cb_subgrupo.DisplayMember = "SGP_NOME";
            cb_subgrupo.ValueMember   = "SGP_CODIGO";
            if (cb_subgrupo.Items.Count == 0) 
            {
                cb_subgrupo.Text = "";
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            FrmProcProdutos form = new FrmProcProdutos(ORIGEM);
            form.Show();

            this.Hide();
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

        private void cb_grupo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Carrega_SubGrupo(int.Parse(cb_grupo.SelectedValue.ToString()));
            }
            catch {
                Carrega_SubGrupo(0);
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == string.Empty)
            {
                MessageBox.Show("Descrição obrigatória!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nome.Focus();
            }
            else
            {
               Produto produto;

                if (tb_codigo.Text == string.Empty)
                {
                    produto = new Produto();
                }
                else
                {
                    produto = new Produto(int.Parse(tb_codigo.Text));
                }

                produto.PRO_NOME = tb_nome.Text;
                try
                {
                    produto.PRO_GRUPO = new GrupoProduto(int.Parse(cb_grupo.SelectedValue.ToString()));
                }
                catch (Exception)
                {
                    produto.PRO_GRUPO = new GrupoProduto();
                }
                produto.PRO_INATIVO = cb_status.SelectedIndex;
                produto.PRO_ULT_COMPRA = 0;
                produto.PRO_REFERENCIA = tb_referencia.Text;
                produto.PRO_UNIDADE = tb_unidade.Text;
                produto.PRO_OBS = tb_obs.Text;
                produto.PRO_PRECO_COMPRA = float.Parse(tb_precocompra.Text);
                produto.PRO_ESTOQUE = float.Parse(tb_estoqueatual.Text);
                produto.PRO_EST_MINIMO = float.Parse(tb_estoqueminimo.Text);
                try
                {
                    produto.PRO_SUBGRUPO = new SubGrupo_Produtos(int.Parse(cb_subgrupo.SelectedValue.ToString()), int.Parse(cb_grupo.SelectedValue.ToString()));   
                }
                catch (Exception)
                {
                    produto.PRO_SUBGRUPO = new SubGrupo_Produtos();
                }
                produto.Salvar();

                Log log = new Log();
                log.LOG_USUARIO = Global.FUN_CODIGO;
                log.LOG_DATA = DateTime.Now;
                log.LOG_TELA = this.Text;
                if (tb_codigo.Text == string.Empty)
                {
                    log.LOG_DESCRICAO = "Cadastrou o produto de código: " + produto.PRO_CODIGO.ToString() + " e nome: " + produto.PRO_NOME + ".";
                }
                else
                {
                    log.LOG_DESCRICAO = "Alterou o produto de código: " + produto.PRO_CODIGO.ToString() + " e nome: " + produto.PRO_NOME + ".";
                }
                log.Save();

                if (ORIGEM == 0)
                {
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

                    tb_codigo.Text = produto.PRO_CODIGO.ToString();
                    tb_codigo.Enabled = false;

                    tb_nome.Focus();
                }
                else
                {
                    Global.PC_PRODUTO = produto.PRO_CODIGO;

                    this.Hide();
                    this.Close();
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmProcProdutos form = new FrmProcProdutos(0);

            form.Show();
            this.Hide();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            tb_codigo.Text = "";
            tb_nome.Text = "";
            tb_estoqueatual.Text = "0,000";
            tb_estoqueminimo.Text = "0,000";
            tb_obs.Text = "";
            tb_precocompra.Text = "0,00";
            tb_referencia.Text = "";
            tb_ulltimacompra.Text = "";
            tb_unidade.Text = "";
            cb_grupo.Text = "";
            cb_subgrupo.Text = "";
            cb_status.Text = "";
            tb_codigo.Enabled = true;
        }

        protected string FormataString(string mascara, string valor)
        {   ////Formatando CPF
            //Response.write(FormataString(“###.###.###-##”, “09289209309”));
            ////Formatando Data
            //Response.write(FormataString(“##/##/####”, “12092010”));
            ////Formata CEP
            //Response.write(FormataString(“##.###-###”, “70000000”));
            ////Formata valor
            //Response.write(FormataString(“##,##”, “2309”));

            string novoValor = string.Empty;
            int posicao = 0;

            for (int i = 0; mascara.Length > i; i++)
            {
                if (mascara[i] == '#')
                {
                    if (valor.Length > posicao)
                    {
                        novoValor = novoValor + valor[posicao];
                        posicao++;
                    }
                    else
                        break;
                }
                else
                {
                    if (valor.Length > posicao)
                        novoValor = novoValor + mascara[i];
                    else
                        break;
                }
            }
            return novoValor;
        }

        private void FrmProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ORIGEM == 1)
            {
                foreach (Form form_aberto in Application.OpenForms)
                {
                    if (form_aberto.Text.Contains("Cadastro de Compra"))
                    {
                        Frm_Compra form = (Frm_Compra)form_aberto;
                        Produto produto = new Produto(Global.PC_PRODUTO);

                        if (Global.PC_PRODUTO > 0)
                        {
                            Produtos_Compra produtos_compra = new Produtos_Compra();

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
    }

}

