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
        int ORIGEM = 0;

        public FrmProdutos(int ORIGEM_TEMP)
        {
            InitializeComponent();
            
            cb_status.SelectedIndex = 0;
            this.Text = Titulo_Tela("Cadastro de Produto");
            gb_produto.Text = Titulo_Grupo("Cadastro");
            ORIGEM = ORIGEM_TEMP;
            Global.PC_PRODUTO = 0;

            GrupoProdutoCollection grupo_todos = new GrupoProdutoCollection(true);
            cb_grupo.DataSource = grupo_todos;
            cb_grupo.DisplayMember = "GRP_NOME";
            cb_grupo.ValueMember = "GRP_CODIGO";

            cb_unidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_unidade.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (Global.PRO_CODIGO > 0)
            {
                Carregar_Cadastro(Global.PRO_CODIGO);
            }
            else 
            {
                Limpar();
            }
            tb_nome.Select();
        }

        public double WPr_Vlr = 0;
        public double WPr_vend = 0;
        public double WPR_liq = 0;
        public double mDesc = 0;
        public double WPr_Abat = 0;
        public double WPr_perc_ganho = 0;

        //Arredondamento
        public double Wliquido  = 0;
        public double Unidade   = 0; 
        public double Vunidade  = 0; 
        public double Sunidade  = 0; 

        private void Carregar_Cadastro(int PRO_CODIGO)
        {
            Produto produto = new Produto(PRO_CODIGO);
            
            if (produto.PRO_CODIGO > 0)
            {

                WPr_perc_ganho = produto.PRO_PERCENTUAL_GANHO;
                WPr_Vlr = produto.PRO_PRECO_COMPRA;
                WPr_vend = (WPr_Vlr * (1 + ( WPr_perc_ganho / 100)));
                WPr_Abat = produto.PRO_PERCENTUAL_ABATE;
                mDesc = WPr_vend * (WPr_Abat / 100);
                WPR_liq = WPr_vend - mDesc;

                tb_codigo.Text = produto.PRO_CODIGO.ToString();
                tb_nome.Text = produto.PRO_NOME.ToUpper();
                tb_estoqueatual.Text = produto.PRO_ESTOQUE.ToString("0.00");
                tb_estoqueminimo.Text = produto.PRO_EST_MINIMO.ToString("0.00");
                tb_obs.Text = produto.PRO_OBS.ToUpper();
                tb_precocompra.Text = produto.PRO_PRECO_COMPRA.ToString("0.00");
                tb_codfabricante.Text = produto.PRO_CODIGO_ORIGINAL1.ToUpper();
                tb_Liquido.Text = WPR_liq.ToString("0.00");
                tb_Bruto.Text = WPr_vend.ToString("0.00"); 
                tb_MargemGanho.Text = produto.PRO_PERCENTUAL_GANHO.ToString("0.00");
                tb_Desconto.Text = produto.PRO_PERCENTUAL_ABATE.ToString("0.00");
                tb_local.Text = produto.PRO_DESCRICAO_LOCAL;

                
                

                /*
                 *  PRO_PRECO_VENDA      ;
                    PRO_PRECO_VALOR      ;
                    PRO_PERCENTUAL_GANHO      ;
                    PRO_PERCENTUAL_IND_FABRICA;
                    PRO_PRECO_TABELA     ;
                    PRO_PERCENTUAL_ABATE      ;
                    PRO_CODIGO_ORIGINAL1      ;
                    PRO_CODIGO_ORIGINAL    ;
                    PRO_QTDADE_ULT_ENTR    ;
                    PRO_DESCRICAO_LOCAL    ;
                    PRO_ULTIMO_FORNECEDOR  ;
                 * 
                 * 
                 * Arredondamento
                     Wliquido  := Wpr_Liq
                 *   Resto     := (Round(Wliquido,2) - Int( WLiquido ) ) * 100
                     Unidade   := Right( StrZero( Resto, 2 ) , 1 )
                     Vunidade  := Val( Unidade )
                     Sunidade  := 10 - Vunidade
                     If WLiquido > 1 .And. WLiquido < 10
                           WLiquido := Int( Wliquido ) + ( ( Sunidade + Resto ) / 100 )
                     Elseif Wliquido >= 10
                           If Resto > 50
                              Sunidade := 100 - Resto
                           Else
                              Sunidade := 50  - Resto
                           End
                           Wliquido   := Wliquido  + Sunidade / 100
                     End

                     Wpr_Liq := Wliquido

                 * 
                 */


                try
                {
                    cb_unidade.Text = produto.PRO_UNIDADE;
                }
                catch (Exception)
                {
                    cb_unidade.SelectedIndex = 0;
                }
                try
                {
                    cb_grupo.SelectedValue = produto.PRO_GRUPO_GRP_CODIGO;
                }
                catch (Exception)
                {
                    cb_grupo.SelectedIndex = 0;
                }
                try
                {
                    cb_subgrupo.SelectedValue = produto.PRO_SUBGRUPO_SGP_CODIGO;
                }
                catch (Exception)
                {
                    if (cb_subgrupo.Items.Count > 0)
                    {
                        cb_subgrupo.SelectedIndex = 0;
                    }
                    else
                    {
                        cb_subgrupo.Text = "";
                    }
                }
                if (produto.PRO_ULT_COMPRA > 0)
                {
                    Compra compra = new Compra(produto.PRO_ULT_COMPRA,0);

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

        private void Carrega_SubGrupo()
        {
            SubGrupo_ProdutosCollection subgrupo_todos;

            try
            {
                subgrupo_todos = new SubGrupo_ProdutosCollection(SubGrupo_ProdutoLoadType.LoadBySubGrupo_LoadByGrupo, int.Parse(cb_grupo.SelectedValue.ToString()));
            }
            catch
            {
                subgrupo_todos = new SubGrupo_ProdutosCollection(SubGrupo_ProdutoLoadType.LoadBySubGrupo_LoadByGrupo, 0);
            }
            cb_subgrupo.DataSource    = subgrupo_todos;
            cb_subgrupo.DisplayMember = "SGP_NOME";
            cb_subgrupo.ValueMember   = "SGP_CODIGO";
            if (subgrupo_todos.Count > 0)
            {
                cb_subgrupo.SelectedIndex = 0;
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
            Carrega_SubGrupo();
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
               Produto produto;

                if (tb_codigo.Text == string.Empty)
                {
                    produto = new Produto();
                }
                else
                {
                    produto = new Produto(int.Parse(tb_codigo.Text));
                }

                produto.PRO_NOME = tb_nome.Text.ToUpper();
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
                produto.PRO_REFERENCIA = tb_codfabricante.Text.ToUpper();
                produto.PRO_UNIDADE = cb_unidade.Text.ToUpper();
                produto.PRO_OBS = tb_obs.Text.ToUpper();
                produto.PRO_PRECO_COMPRA = tb_precocompra.Text == "" ? 0 : float.Parse(tb_precocompra.Text);
                produto.PRO_ESTOQUE = tb_estoqueatual.Text == "" ? 0 : float.Parse(tb_estoqueatual.Text);
                produto.PRO_EST_MINIMO = tb_estoqueminimo.Text == "" ? 0 : float.Parse(tb_estoqueminimo.Text);
                produto.PRO_REFERENCIA = tb_codfabricante.Text;
                produto.PRO_PERCENTUAL_IND_FABRICA   = 100;
                produto.PRO_PERCENTUAL_GANHO = tb_MargemGanho.Text == "" ? 0 : float.Parse(tb_MargemGanho.Text);
                produto.PRO_PERCENTUAL_ABATE = tb_Desconto.Text == "" ? 0 : float.Parse(tb_Desconto.Text);
                produto.PRO_DESCRICAO_LOCAL = tb_local.Text;
                produto.PRO_CODIGO_ORIGINAL = "";
                produto.PRO_CODIGO_ORIGINAL1 = tb_codfabricante.Text;
                produto.PRO_PRECO_VENDA = tb_Bruto.Text == "" ? 0 : float.Parse(tb_Bruto.Text);
                produto.PRO_PRECO_VALOR = tb_Liquido.Text == "" ? 0 : float.Parse(tb_Liquido.Text);
                
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
                            MessageBox.Show("Cadastro efetuado com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Alteração efetuada com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    tb_codigo.Text = produto.PRO_CODIGO.ToString();
                    tb_codigo.Enabled = false;

                    tb_nome.Focus();
                }
                else
                {
                    Global.PC_PRODUTO = produto.PRO_CODIGO;

                    FrmProcProdutos form = new FrmProcProdutos(ORIGEM);
                    form.Show();
                    this.Hide();
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
            tb_codfabricante.Text = "";
            tb_ulltimacompra.Text = "";
            cb_unidade.SelectedIndex = 0;
            cb_grupo.SelectedIndex = 0;
            cb_subgrupo.SelectedIndex = 0;
            Carrega_SubGrupo();
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
                        break;
                    }
                }
            }
        }

        private void Calcula_Preco(string valor, string campo)
        {
            if (campo == "preco_compra") WPr_Vlr = double.Parse(valor);
            if (campo == "perc_ganho") WPr_perc_ganho = double.Parse(valor);
            WPr_vend = (WPr_Vlr * (1 + (WPr_perc_ganho / 100)));

            if (campo == "desconto")
            {
                mDesc = double.Parse(valor);
                mDesc = (WPr_vend * mDesc) / 100;
                WPR_liq = WPr_vend - mDesc;
            }
            else
            {
                mDesc = WPr_vend * (WPr_Abat / 100);
                WPR_liq = WPr_vend - mDesc;
            }

            WPr_vend = Arredondar(WPr_vend);
            WPR_liq = Arredondar(WPR_liq);
            tb_Bruto.Text = WPr_vend.ToString("0.00");
            tb_Liquido.Text = WPR_liq.ToString("0.00");

        }

        public double Arredondar(double rounded)
        {
            double Resto = 0;

            Resto = (Math.Round(rounded, 2) - (Math.Truncate(rounded))) * 100;
            string unidAux = Math.Round(Resto, 0).ToString();
            double unidade = double.Parse(unidAux.Substring(unidAux.Length - 1, 1));

            if (rounded > 0 && rounded < 10)
                rounded = Math.Round(rounded, 1);
            else if (rounded >= 10)
            {
                if (Math.Round(Resto, 0) > 50)
                    rounded = Math.Truncate(rounded) + 1;
                else
                    rounded = Math.Truncate(rounded) + 0.5;
            }

            return rounded;
        }
        // liq 18,33
        // ganho 150
        // desc 20
        //
                     /* Arredondamento
                     Wliquido  := Wpr_Liq    25
                 *   Resto     := (Round(Wliquido,2) - Int( WLiquido ) ) * 100
                     Unidade   := Right( StrZero( Resto, 2 ) , 1 )
                     Vunidade  := Val( Unidade )
                     Sunidade  := 10 - Vunidade
                     If WLiquido > 1 .And. WLiquido < 10
                           WLiquido := Int( Wliquido ) + ( ( Sunidade + Resto ) / 100 )
                     Elseif Wliquido >= 10
                           If Resto > 50
                              Sunidade := 100 - Resto
                           Else
                              Sunidade := 50  - Resto
                           End
                           Wliquido   := Wliquido  + Sunidade / 100
                     End

                     Wpr_Liq := Wliquido

                 * 
                 */

        private void tb_precocompra_TextChanged(object sender, EventArgs e)
        {
            if (tb_precocompra.Text != "")
            {
                tb_precocompra.Text = Global.formatString(tb_precocompra.Text);
                tb_precocompra.SelectionStart = tb_precocompra.Text.Length + 1;
                Calcula_Preco(tb_precocompra.Text, "preco_compra");
            }
        }

        private void tb_MargemGanho_TextChanged(object sender, EventArgs e)
        {
            if (tb_MargemGanho.Text != "")
            {
                tb_MargemGanho.Text = Global.formatString(tb_MargemGanho.Text);
                tb_MargemGanho.SelectionStart = tb_MargemGanho.Text.Length + 1;
                Calcula_Preco(tb_MargemGanho.Text, "perc_ganho");
            }
        }

        private void tb_Desconto_TextChanged(object sender, EventArgs e)
        {
            if (tb_Desconto.Text != "")
            {
                tb_Desconto.Text = Global.formatString(tb_Desconto.Text);
                tb_Desconto.SelectionStart = tb_Desconto.Text.Length + 1;
                Calcula_Preco(tb_Desconto.Text, "desconto");
            }
        }
    }
}

