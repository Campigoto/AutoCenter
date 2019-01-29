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
    public partial class FrmProcProdutos : Frm_Master
    {
        public ProdutoCollection produto_todos = new ProdutoCollection();
        int ORIGEM = 0;
        int ORDER = 1;

        public FrmProcProdutos(int ORIGEM_TEMP)
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Pesquisa de Produto");
            gb_produto.Text = Titulo_Grupo("Pesquisa");
            ORIGEM = ORIGEM_TEMP;

            if (ORIGEM_TEMP == 0)
            {
                dgv_Produtos.Columns["PRO_PRECO_VENDA_FORMATADO"].Visible = true;
                dgv_Produtos.Columns["PRO_ESTOQUE_FORMATADO"].Visible = true;
                dgv_Produtos.Columns["COM_DATA_FORMATADA"].Visible = true;
                dgv_Produtos.Columns["PRO_EST_ANTERIOR"].Visible = false;
                dgv_Produtos.Columns["PRO_EST_ATUAL"].Visible = false;
                btn_voltar.Text = "Voltar";
                btn_voltar.Visible = false;
                btn_cadastro.Visible = true;
            }
            if (ORIGEM_TEMP == 1 || ORIGEM_TEMP == 2 || ORIGEM_TEMP == 5)
            {
                dgv_Produtos.Columns["PRO_PRECO_VENDA_FORMATADO"].Visible = true;
                dgv_Produtos.Columns["PRO_ESTOQUE_FORMATADO"].Visible = true;
                dgv_Produtos.Columns["COM_DATA_FORMATADA"].Visible = true;
                dgv_Produtos.Columns["PRO_EST_ANTERIOR"].Visible = false;
                dgv_Produtos.Columns["PRO_EST_ATUAL"].Visible = false;
                btn_voltar.Text = "Voltar";
                btn_voltar.Visible = true;
                btn_cadastro.Visible = true;
            }
            else if (ORIGEM_TEMP == 3)
            {
                dgv_Produtos.Columns["PRO_PRECO_VENDA_FORMATADO"].Visible = false;
                dgv_Produtos.Columns["PRO_ESTOQUE_FORMATADO"].Visible = false;
                dgv_Produtos.Columns["COM_DATA_FORMATADA"].Visible = false;
                dgv_Produtos.Columns["PRO_EST_ANTERIOR"].Visible = true;
                dgv_Produtos.Columns["PRO_EST_ATUAL"].Visible = true;
                btn_voltar.Text = "Confirmar";
                btn_voltar.Visible = true;
                btn_cadastro.Visible = false;
            }
            else if (ORIGEM_TEMP == 4)
            {
                dgv_Produtos.Columns["PRO_PRECO_VENDA_FORMATADO"].Visible = true;
                dgv_Produtos.Columns["PRO_ESTOQUE_FORMATADO"].Visible = true;
                dgv_Produtos.Columns["COM_DATA_FORMATADA"].Visible = false;
                dgv_Produtos.Columns["PRO_EST_ANTERIOR"].Visible = false;
                dgv_Produtos.Columns["PRO_EST_ATUAL"].Visible = false;
                btn_voltar.Text = "Voltar";
                btn_voltar.Visible = true;
                btn_cadastro.Visible = true;
            }
            
            Global.PRO_CODIGO = 0;
            Global.PC_PRODUTO = 0;
            Global.HEP_PRODUTO = 0;

            cb_criterio.SelectedIndex = 1;

            Carregar_DGV();

            tb_igual.Select();
        }

        private void Carregar_DGV()
        {
            if (cb_criterio.SelectedIndex == 0 && tb_igual.Text != "")
            {
                try
                {
                    produto_todos = new ProdutoCollection(int.Parse(tb_igual.Text), ORDER);
                }
                catch (Exception)
                {
                    produto_todos = new ProdutoCollection(true, ORDER);
                }
            }
            else if (cb_criterio.SelectedIndex == 1 && tb_igual.Text != "")
            {
                produto_todos = new ProdutoCollection(ProdutoLoadType.LoadByNome, tb_igual.Text, ORDER);
            }
            else if (cb_criterio.SelectedIndex == 2 && tb_igual.Text != "")
            {
                produto_todos = new ProdutoCollection(ProdutoLoadType.LoadByFabr, tb_igual.Text, ORDER);
            }
            else
            {
                produto_todos = new ProdutoCollection(true, ORDER);
            }
            dgv_Produtos.AutoGenerateColumns = false;
            dgv_Produtos.DataSource = produto_todos;
        }

        private void tb_igual_TextChanged(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgv_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (ORIGEM == 0 )
                {
                    Global.PRO_CODIGO = int.Parse(dgv_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.Close();
                }
                else if (ORIGEM == 1 || ORIGEM == 4 || ORIGEM == 5)
                {
                    Global.PC_PRODUTO = int.Parse(dgv_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.Close();
                }
                else if (ORIGEM == 2 )
                {
                    Global.HEP_PRODUTO = int.Parse(dgv_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.Close();
                }
            }
            else
            {
                ORDER = e.ColumnIndex;
                Carregar_DGV();
            }
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            Global.PRO_CODIGO = -1;

            this.Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (btn_voltar.Text == "Voltar")
            {
                if (ORIGEM == 1 || ORIGEM == 5)
                {
                    Global.PC_PRODUTO = -1;
                }
                else if (ORIGEM == 2)
                {
                    Global.HEP_PRODUTO = -1;
                }
                this.Close();
            }
            else
            {
                int count = 0;
                foreach (Produto produto_foreach in produto_todos)
                {
                    if (produto_foreach.PRO_CODIGO > 0 && produto_foreach.PRO_ESTOQUE.ToString("0.000") != produto_foreach.PRO_EST_ATUAL)
                    {
                        count++;
                        Produto produto = new Produto(produto_foreach.PRO_CODIGO);
                        Historico_Estoque_Preco historico = new Historico_Estoque_Preco();
                        historico.HEP_CODIGO = 0;
                        historico.HEP_COMPRA = 0;
                        historico.HEP_DATA = DateTime.Now;
                        historico.HEP_ESTOQUE_ANTERIOR = produto.PRO_ESTOQUE;
                        historico.HEP_ESTOQUE_ATUAL = float.Parse(produto_foreach.PRO_EST_ATUAL);
                        historico.HEP_PRECO_UNITARIO = produto.PRO_PRECO_COMPRA;
                        historico.HEP_PRECO_TOTAL = produto.PRO_PRECO_COMPRA * float.Parse(produto_foreach.PRO_EST_ATUAL);
                        historico.HEP_PRODUTO = produto.PRO_CODIGO;
                        historico.HEP_QTDE = Math.Abs(produto.PRO_ESTOQUE - float.Parse(produto_foreach.PRO_EST_ATUAL));
                        historico.HEP_USUARIO = Global.FUN_CODIGO;
                        historico.Salvar();

                        produto.PRO_ESTOQUE = float.Parse(produto_foreach.PRO_EST_ATUAL);
                        produto.Salvar();
                    }
                }
                if (count > 0)
                {
                    if (Configuracoes.Default.Mensagem_Gravar == true)
                    {
                        MessageBox.Show(count.ToString() + " produtos foram atualizados com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Carregar_DGV();

                    tb_igual.Select();
                }
                else
                {
                    if (Configuracoes.Default.Mensagem_Gravar == true)
                    {
                        MessageBox.Show("Nenhum produto foi atualizado!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    btn_voltar.Select();
                }
            }
        }

        private void cb_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_criterio.SelectedIndex == 0)
            {
                tb_igual.KeyPress += Numero_KeyPress;
                tb_igual.MaxLength = 10;
            }
            else
            {
                tb_igual.KeyPress -= Numero_KeyPress;
                tb_igual.MaxLength = 60;
            }
            tb_igual.Text = "";
            tb_igual.Focus();
        }

        public void Atualizar_Grid(int RowIndex)
        {
            try
            {
                produto_todos[RowIndex].PRO_EST_ATUAL = dgv_Produtos.Rows[RowIndex].Cells[9].Value.ToString();
            }
            catch (Exception) { }

            dgv_Produtos.UpdateCellValue(9, RowIndex);
        }

        private void FrmProcProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.PRO_CODIGO == 0)
            {
                if (ORIGEM == 1 || ORIGEM == 5)
                {
                    foreach (Form form_aberto in Application.OpenForms)
                    {
                        if (form_aberto.Text.Contains("Cadastro de Compra") || form_aberto.Text.Contains("Cadastro de Venda"))
                        {
                            Frm_Venda form_venda = null;
                            Frm_Compra form_compra = null;
                            
                            if(ORIGEM == 1)
                                form_compra = (Frm_Compra)form_aberto;
                            else
                                form_venda = (Frm_Venda)form_aberto; 
                            
                            if (Global.PC_PRODUTO != 0)
                            {
                                if (Global.PC_PRODUTO > 0)
                                {
                                    Produto produto = new Produto(Global.PC_PRODUTO);
                                    Produtos_Compra produtos_compra = new Produtos_Compra();
                                    Global.PC_PRODUTO = 0;

                                    produtos_compra.PC_COMPRA = 0;
                                    produtos_compra.PC_ITEM = ORIGEM == 1 ? form_compra.produtos_compra_todos.Count + 1 : form_venda.produtos_venda_todos.Count + 1;
                                    produtos_compra.PC_PRODUTO = produto.PRO_CODIGO;
                                    produtos_compra.PRO_NOME = produto.PRO_NOME;
                                    produtos_compra.PC_UNIDADE = produto.PRO_UNIDADE;
                                    produtos_compra.PC_QTDE = 1;
                                    produtos_compra.PC_PRECO_COMPRA = ORIGEM == 1 ? produto.PRO_PRECO_COMPRA : produto.PRO_PRECO_VENDA;
                                    produtos_compra.PC_TOTAL = ORIGEM == 1 ? produto.PRO_PRECO_COMPRA : produto.PRO_PRECO_VENDA;
                                    if (ORIGEM == 1)
                                    {
                                        form_compra.produtos_compra_todos.Add(produtos_compra);
                                        form_compra.Carregar_Grid(form_compra.produtos_compra_todos);
                                    }
                                    else
                                    {
                                        form_venda.produtos_venda_todos.Add(produtos_compra);
                                        form_venda.Carregar_Grid(form_venda.produtos_venda_todos);
                                    }
                                    
                                }

                                if (ORIGEM == 1)
                                {
                                    form_compra.Enabled = true;
                                    form_compra.Show();
                                }
                                else
                                {
                                    form_venda.Enabled = true;
                                    form_venda.Show();
                                }
                            }
                            break;
                        }
                    }
                }
                else if (ORIGEM == 4)
                {
                    foreach (Form form_aberto in Application.OpenForms)
                    {
                        if (form_aberto.Text.Contains("Ordem de Serviço"))
                        {
                            Frm_OS form = (Frm_OS)form_aberto;

                            if (Global.PC_PRODUTO > 0)
                            {
                                Produto produto = new Produto(Global.PC_PRODUTO);
                                Produtos_Compra produtos_compra = new Produtos_Compra();
                                Global.PC_PRODUTO = 0;

                                DataGridView grid = (DataGridView)form.Controls["gb_geral"].Controls["dgv_produtos"];
                                grid.Rows.Add(produto.PRO_CODIGO, produto.PRO_NOME, produto.PRO_PRECO_VENDA_FORMATADO, "1", produto.PRO_PRECO_VENDA_FORMATADO);
                            }
                            form.Enabled = true;
                            form.Show();
                        }

                    }
                }
                else if (ORIGEM == 2 && Global.HEP_PRODUTO != 0)
                {
                    if (Global.HEP_PRODUTO == -1)
                    {
                        Global.HEP_PRODUTO = 0;
                    }
                    Frm_Atualizar_Estoque form = new Frm_Atualizar_Estoque();
                    form.Show();
                }
            }
            else
            {
                if (Global.PRO_CODIGO == -1)
                {
                    Global.PRO_CODIGO = 0;
                }
                if (ORIGEM != 0)
                {
                    FrmProdutos form = new FrmProdutos(ORIGEM);
                    form.Show();
                }
                else
                {
                    FrmProdutos form = new FrmProdutos(0);
                    form.Show();
                }
            }
        }

        private void dgv_Produtos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                Atualizar_Grid(e.RowIndex);
            }
        }
    }
}
 //Produto->Pr_dtcoe := wdata
 //         Produto->Pr_tbla  := (Produto->Pr_tbla*(WPorcentagem/100))
 //         WPr_vlr  := Produto->Pr_tbla*(Produto->Pr_idfb/100)
 //         Wpr_vlus := Wpr_vlr/Wvalor
 //         Wpr_vdus := (Wpr_vlus*(Produto->Pr_pcgn/100))+Wpr_vlus
 //         Wpr_vend := Wpr_vdus*Wvalor
 //         Mdesc    := Wpr_vend*(produto->Pr_abat/100)
 //         Wpr_liq  := Wpr_vend-Mdesc
 //         Wpr_lus  := Wpr_liq / Wvalor
 //         Produto->Pr_vlr  := Wpr_vlr
 //         Produto->Pr_vlus := Wpr_vlus
 //         Produto->Pr_vend := Wpr_vend
 //         Produto->Pr_vdus := Wpr_vdus

/**********************************************************
   *                                                        *
   *          REAJUSTE DE PRECOS DE CUSTO                   *
   *                                                        *
   **********************************************************
*/
// @ 07,04 Say "Grupo............                                                        "
//   @ 08,04 Say "Sub-Grupo........                                                        "
//   @ 09,04 Say "Produto..........                                                        "
//   @ 10,04 Say "Fabricante.......                                                        "
//   @ 11,04 Say "Estoque M¡nimo...                      Estoque Atual...                  "
//   @ 12,04 Say Replicate('Í',74)


//   @ 13,04 Say "Indexador........                                                        "
//   @ 14,04 Say "Data do Indexador                                                        "
//   @ 15,04 Say Replicate('Í',74)

//   @ 16,04 Say "Tabela...........                      Indice Fabrica..                  "
//   @ 17,04 Say "Desconto.........                      Margem de Ganho.                  "
//   @ 18,04 Say "Preco De Custo...                      Pr. Custo Index.                  "
//   @ 19,04 Say "Preco Bruto Index                      Preco Bruto R$..                  "
//   @ 20,04 Say "Preco Liquido R$.                      Preco Liq. Index                  "
//   @ 21,04 Say "Representante....                      Pre‡o de Entrada                  "
//Return nil


//Static function Calcula()
//Select Valores
//Set Order to 1
//If Valores->(DbSeek(Produto->Pr_cdmo + Dtos( Produto->Pr_dtCoe) ) )
//    WValor := Valores->Valor
//Else

//   If Seeklast(wpr_cdmo , 'valores' ,"Valores->Codigo")
//      Wvalor := Valores->Valor
//   Else
//      Alerta("Valor da Moeda Oficial NÆo Encontrados !")
//      Return nil
//   End
//End
//Select Produto
//WPr_Vlr   := Wpr_tbla * ( Wpr_idfb /100 )
//Wpr_vlus  := WPr_Vlr / Wvalor
//WPr_vdus  := (Wpr_vlus * ( WPr_pcgn / 100 ) ) +  WPr_vlus
//WPr_vend  := Wpr_vdus  * WValor
//WDesconto := Wpr_Vend  * ( WPr_Abat / 100 )
//WPR_liq   := WPr_vend - WDesconto
//Wliquido  := Wpr_Liq
//Resto     := (Round(Wliquido,2) - Int( WLiquido ) ) * 100
//Unidade   := Right( StrZero( Resto, 2 ) , 1 )
//Vunidade  := Val( Unidade )
//Sunidade  := 10 - Vunidade
//If WLiquido > 1 .And. WLiquido < 10
//      WLiquido := Int( Wliquido ) + ( ( Sunidade + Resto ) / 100 )
//Elseif Wliquido >= 10
//      If Resto > 50
//         Sunidade := 100 - Resto
//      Else
//         Sunidade := 50  - Resto
//      End
//      Wliquido   := Wliquido  + Sunidade / 100
//End

//Wpr_Liq := Wliquido
//Wpr_Liq_us := Wpr_liq / Wvalor

/*
 **********************************************************
   *                                                        *
   *          REAJUSTE DE PRECOS DE VENDA                   *
   *                                                        *
   **********************************************************
 *
 *  WPorcentagem     := 0               // Percentual a reajustar
   Wdata            := Ctod(space(8))  // data do indexador
   Wgr_codii        := Space(01)       // grupo inicial
   Wgr_codif        := Space(01)       //       final
   WSb_codii        := Space(02)       // Subgrupo inicial
   WSb_codif        := Space(02)       //          final
   WPr_codii        := '001'           // Produto inicial
   WPr_codif        := '999'           //         final
   WFo_codii        := Space(03)       // Fornecedor inicial
   WFo_codif        := Space(03)       //            final
   Wpr_cdmo         := Space(05)       // Codigo Do Indexador
   Wvalor           := 0
   WNomede          := WnomeAte    := Space(50)



    alimenta as variaveis com valores  do banco e dados !  


   Select Grupo
   Set Order To 1
   DbGotop()

   Wgr_codii := Grupo->Gr_codi
   DbGobottom()
   Wgr_codif := Grupo->Gr_codi

   Select SubGrupo
   Set Order To 1
   DbGotop()
   WSb_codii := SubGrupo->Sb_codi
   DbGobottom()
   WSb_codif := SubGrupo->Sb_codi

   Select Fornecedor
   Set Order To 1
   DbGotop()
   WFo_codii := Fornecedor->Fo_codi

   DbGobottom()
   WFo_codif := Fornecedor->Fo_codi

   Select Produto

   @ 07,06 Say "Percentual.........:                                                "
   @ 08,06 Say "Indexador..........:                                                "
   @ 09,06 Say "Data do Indexador..:                                                "
   @ 10,06 Say "Grupo Inicial......:                                                "
   @ 11,06 Say "Grupo Final........:                                                "
   @ 12,06 Say "SubGrupo Inicial...:                                                "
   @ 13,06 Say "SubGrupo Final.....:                                                "
   @ 14,06 Say "Produto Inical.....:                                                "
   @ 15,06 Say "Produto Final......:                                                "
   @ 16,06 Say "Fabricante Inicial.:                                                "
   @ 17,06 Say "Fabricante Final...:                                                "
   @ 18,06 Say "Considerar Nome De.:                                                "
   @ 19,06 Say "Considerar Nome At‚:                                                "

   @ 07,27 Get Wporcentagem  Picture '999.99'  Valid ! Empty(Wporcentagem)
   @ 08,27 Get Wpr_cdmo      Picture '99999' Valid Valinde(@Wpr_cdmo,08,35,.T.,.F.,20)
   @ 09,27 Get WData         Picture "@K"    Valid Valvlr(@Wpr_cdmo,@Wdata,09,35)
   @ 10,27 Get WGr_codii     Picture "9"     Valid valgru(@Wgr_codii,10,35,.T.,.F.)
   @ 11,27 Get WGr_codif     Picture "9"     Valid valgru(@Wgr_codif,11,35,.T.,.F.)
   @ 12,27 Get WSb_codii     Picture "99"    Valid valsgru(@Wsb_codii,12,35,.T.,.F.)
   @ 13,27 Get WSb_codif     Picture "99"    Valid valsgru(@Wsb_codif,13,35,.T.,.F.)
   @ 14,27 Get WPr_codii     Picture "999"   Valid !  empty(Wpr_codii)
   @ 15,27 Get WPr_codif     Picture "999"   Valid !  empty(Wpr_codif)
   @ 16,27 Get WFo_Codii     Picture "999"   Valid ValFor(@Wfo_codii,16,35,.T.,.F.)
   @ 17,27 Get WFo_Codif     Picture "999"   Valid ValFor(@Wfo_codif,17,35,.T.,.F.)
   ReadModal(Getlist) ; Getlist := {}
    If Lastkey() == K_ESC
      Exit
   End
   Select Produto
   Set SoftSeek on
   produto->( DbSeek( Wgr_codii + Wsb_codii + Wpr_Codii + Wfo_codii ) )
   Wnomede := Produto->pr_desc
   Set SoftSeek off
   Seeklast( Wgr_codif + Wsb_codif + Wpr_codif + Wfo_codif ,;
    'Produto' ,"Produto->Gr_Codi+Produto->Sb_Codi+Produto->Pr_codi+Produto->Fo_Codi")

   Wnomeate := Produto->pr_desc
   @ 18,27 Get Wnomede       Picture "@!"
   @ 19,27 Get Wnomeate      Picture "@!"

   ReadModal(Getlist) ; Getlist := {}
   SetCursor(0)
   Wnomede  := Alltrim( Wnomede  )
   WnomeAte := AllTrim( WnomeAte )
   tamanhode := Len(Wnomede)
   tamanhoate := Len(wnomeate)
   If Lastkey() == K_ESC
      Exit
   End

   Select Valores
   Set Order to 1
   If ! Dbseek(Wpr_cdmo + Dtos( Wdata ) )
      Alerta("Data Nao Encontrada " + Dtoc(Wdata) )
      Wdata   := Valores->Data
      Wvalor  := Valores->Valor
      Moeda   := Valores->Nome
      If Mensagem("Atualizar Com ? " + Moeda + ' ' +  WData + ' ' + ' ' + WValor + " " , 2 ) == 2
         Loop
      End
   End
   Wdata   := Valores->Data
   Wvalor  := Valores->Valor
   Moeda   := Valores->Nome
   Opcao :=  Mensagem("Confirma Os Dados Acima ?" , 2 )
   If Opcao == 1
      atualiza()
   Elseif opcao == 2
      Loop
   Else
      Exit
   End
End
Sc_restexp( Tela )
SetColor( Cor )
Return nil


*************Quarta, 19 de abril de 1995 …s 22:28 horas****************

Static Function Atualiza()
Local Vazio := IF( Empty(WnomeDe ) .And. Empty( WnomeAte ) , .T. , .F. )
Local lAjuste := .F.
Local quantos := 0
Local lin_tel := 18
Local Tela1 := SC_Exp(Row(),Col(),Row(),Col()+5,17,05,24,78,"D","[ Produtos Reajustados ]","C", Cores->Movto )
@ 24,10 Say "Esc Cancela"
Select Produto
Dbsetorder(01)
If ! ProDuto->(DbSeek( Wgr_codii +  WSb_codii + WPr_codii + WFo_Codii ) )
   If ! ProDuto->(DbSeek( Wgr_codii +  WSb_codii + WPr_codii ) )
      If ! ProDuto->(DbSeek( Wgr_codii +  WSb_codii ) )
           ProDuto->(DbSeek( Wgr_codii ))
      End
   End
End
While Produto->(!Eof()) .And. TeclouESC()
    If Produto->Gr_codi < Wgr_codii
       DbSkip()
       Loop
    Elseif ProDuto->Gr_Codi > Wgr_codif
       Exit
    Endif
    If Produto->Sb_codi < Wsb_codii
       DbSkip()
       Loop
    ElseIf Produto->Sb_codi > Wsb_codif
       Exit
    Endif
    If Produto->Pr_codi < Wpr_codii
       DbSkip()
       Loop
    ElseIF Produto->Pr_codi > Wpr_codif
       Exit
    Endif

    If Produto->Fo_codi < Wfo_codii
       DbSkip()
       Loop
    ElseIf Produto->Fo_codi > Wfo_Codif
       Exit
    Endif
    If Vazio == .T.        // se for Vazio  nao verifica a descricao
       lAjuste := .T.
    Else       // nao ‚ vazio
      * se estiver condito no registro o nome inicial ou final
       *  ajustar ‚ verdadeiro
       If Left(produto->pr_desc,Tamanhode) $ Wnomede .Or. ;
          Left( Produto->Pr_desc,Tamanhoate) $ WnomeAte
          lAjuste := .T.
       Else
          lAjuste := .F.
       End
    End
    If lAjuste
       If Lin_tel > 23
         Scroll(18,06,23,77,1)
         lin_tel = 23
       End
       @ Lin_tel,07 Say Produto->Gr_codi + '.'
       @ Lin_tel,09 Say Produto->Sb_codi + '.'
       @ Lin_tel,12 Say Produto->Pr_codi + '.'
       @ Lin_tel,16 Say Produto->Fo_codi
       @ Lin_tel,20 Say Produto->Pr_desc
       Lin_tel ++
       Select Produto

      If Rec_lock(5)
          Quantos ++
          Produto->Pr_dtcoe := wdata
          Produto->Pr_tbla  := (Produto->Pr_tbla*(WPorcentagem/100))
          WPr_vlr  := Produto->Pr_tbla*(Produto->Pr_idfb/100)
          Wpr_vlus := Wpr_vlr/Wvalor
          Wpr_vdus := (Wpr_vlus*(Produto->Pr_pcgn/100))+Wpr_vlus
          Wpr_vend := Wpr_vdus*Wvalor
          Mdesc    := Wpr_vend*(produto->Pr_abat/100)
          Wpr_liq  := Wpr_vend-Mdesc
          Wpr_lus  := Wpr_liq / Wvalor
          Produto->Pr_vlr  := Wpr_vlr
          Produto->Pr_vlus := Wpr_vlus
          Produto->Pr_vend := Wpr_vend
          Produto->Pr_vdus := Wpr_vdus
          Produto->(Dbunlock())
       End
    End
    Produto->(Dbskip())

Enddo
 


   MSC INFORMATICA LTDA

   SISTEMA PARA GERENCIAMENTO DE LOJA DE AUTO PECAS

   PROGRAMADORES EVANDRO CAMPIGOTTO / JORGE SANT ANNA

   MODULO        M_CONSUL.PRG

   **********************  FINALIDADE       ****************
   *                                                        *
   *   Consultar margems do produto  e afins                *
   *                                                        *
   **********************************************************

    Domingo, 30 de abril de 1995 …s 12:45 horas




#include "comando.ch"
#include "inkey.ch"

Function Cons_pro()
Local Tela ,  cursor , cor
Cor    := SetColor( Cores->Movto )
CurSor := SetCursor( 1 )
Tela := Sc_exp(Row(),Col(),Row(),Col(),04,05,21,70, 'S' ,;
      '[ Consulta de Produto ]' , "C", Cores->Movto )
@ 21,11 Say "[ + ] Avanca [ - ] Retrocede  ESC Retorna"
Select Produto
Produto->(Dbsetorder(1))
Produto->( DbGotop() )
While .t.
   Tel_cons()
   Private  Wgr_codi           := space(01)
   Private  Wsb_codi           := space(02)
   Private  Wfo_codi           := space(03)
   Private  Wpr_codi           := space(03)

   @ 05,21 Get WGr_codi  Picture "9"     Valid valgru(@Wgr_codi,05,25,.F.,.T.)
   @ 06,21 Get WSb_codi  Picture "99"    Valid valsgru(@Wsb_codi,06,25,.F.,.T.)
   @ 07,21 Get WPr_codi  Picture "999"
   @ 08,21 Get WFo_Codi  Picture "999"   Valid ValFor(@Wfo_codi,08,25,.F.,.T.) ;
              .And. Valpro(WGr_codi + WSb_codi + WPr_codi + WFo_Codi , 07 , 25 ,.T.,.F., 40)

   ReadModal(Getlist) ; Getlist := {}
   If Lastkey()=27
      Exit
   Endif
   select produto
 * 
   /* preenche as variaveis do sistema com as do .DBF 
   For I := 1 to Produto->(FCount())
         campo := fieldname(i)
         varia := "W" + Campo
         &Varia := &Campo
   Next
   @ 05,21 Get WGr_codi  Picture "9"
   @ 06,21 Get WSb_codi  Picture "99"
   @ 07,21 Get WPr_codi  Picture "999"
   @ 08,21 Get WFo_Codi  Picture "999"
   __KillRead() ; Getlist := {}
   Mostrar()

   Tecla = 0

   While Tecla != K_ESC
      Tecla := Inkey(0)
      Select Produto
      Set Order to 1
      Do Case
         Case Chr(tecla) == '+'
              Skip 1
              If Eof()
                 DbGotop()
              End
         Case Chr(Tecla) == '-'
              Skip - 1
              If Bof()
                DbGobottom()
              End
      Endcase
      For I := 1 to Produto->(FCount())
         campo := fieldname(i)
         varia := "W" + Campo
         &Varia := &Campo
      Next
      Wgr_codi := Produto->Gr_codi
      WSb_codi := Produto->Sb_Codi
      WPr_codi := Produto->Pr_Codi
      WFo_codi := Produto->Fo_Codi

      Select Grupo
      Set Order To 1
      IF Grupo->(DbSeek(Wgr_Codi))
            @ 05,21  Say Wgr_codi Picture "9"
            @ 05,25  Say Grupo->Gr_Nome    Picture "@X"
      End
      Select SubGrupo
      Set Order to 1
      If SubGrupo->(DbSeek(Wsb_Codi))
           @ 06,21  Say WSb_codi Picture "99"
           @ 06,25  Say SubGrupo->Sb_Nome Picture "@X"
      End
      Select Fornecedor
      Set Order to 1
      If Fornecedor->(DbSeek(Wfo_codi))
            @ 08,21  Say WFo_codi Picture "999"
            @ 08,25  Say Fornecedor->Fo_Nome Picture "@X"
      End
      Select Produto
      Set Order To 1

      If Produto->( DbSeek( Upper( Wgr_codi+Wsb_Codi+Wpr_codi+Wfo_codi ) ) )
         @ 07,21 Say Wpr_codi Picture '999'
         @ 07,25 Say Left( Wpr_desc,35 ) Picture "@!"
      End
      mostrar()
   End
Enddo
Sc_restExp( Tela )
SetColor( Cor )

Function Tel_Cons()

@ 05,06 SAY " Grupo.......:                                                 "
@ 06,06 SAY " Subgrupo....:                                                 "
@ 07,06 SAY " Codigo......:                                                 "
@ 08,06 SAY " Fabricante..:                                                 "
@ 09,06 Say "ÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ"
@ 10,06 SAY " Unidade.....:                  Indexador....:                 "
@ 11,06 SAY " Qte. Minima.:                  Data Atual...:                 "
@ 12,06 SAY " Qte. Disp...:                  Valor Moeda..:                 "
@ 13,06 SAY " Margem Ganho:                  Tab. Atl.R$..:                 "
@ 14,06 SAY " Desconto....:                  Ult. Entrada.:                 "
@ 15,06 SAY " Dt. Corre‡Æo:                  Quantidade...:                 "
@ 16,06 SAY " Valor R$....:                  Ult. Saida...:                 "
@ 17,06 SAY " Vlr. Tabela.:                  R$. Ult.Entr.:                 "
@ 18,06 SAY " Ind. Fabric.:                  Corrigido....:                 "
@ 19,06 SAY " Custo R$....:                  Custo Index..:                 "
@ 20,06 SAY " R$  Bruto...:                  R$  Liquido..:                 "



Static Function Mostrar()
   @ 10,22 Say WPr_unid Picture "Xxx"
   @ 10,62 Say Wpr_cdMO  Picture '99999'
   @ 11,26 Say WPr_esmi Picture "99,999"
   @ 12,26 Say WPr_estq Picture "99,999"
   @ 13,26 Say WPr_pcgn Picture "999.99"
   @ 14,26 Say WPr_abat Picture "999.99"
   @ 15,22 Say WPr_dtcoe Picture "@K"

   If Empty( Produto->Pr_cdmo )
      Wpr_Cdmo := Parametro->Indexador
   End

   select Valores
   Set Order to 1
   DbGotop()
   Dbseek( Wpr_cdmo + Dtos( Wpr_Dtcoe ) ) //  procura indexador
   Val_indeCoe := Valores->Valor
   Dat_indeCoe := Valores->Data

   SeekLast(Wpr_cdmo , "Valores" , "Valores->codigo" )
   Ult_Val_inde  := Valores->Valor             // Ultimo Valor deste Indexador
   Ult_dat_inde  := Valores->Data

   @ 11,57 Say Ult_Dat_inde  Picture "@K"
   @ 12,50 Say Ult_Val_inde  Picture "@e 99,999,999.999999"
   @ 16,19 Say Val_indeCoe   Picture '@e 99,999,999.99'

   @ 17,19 Say WPr_tbla Picture "@e 99,999,999.99"
   @ 18,26 Say WPr_idfb Picture "@e 999.99"
   @ 19,19 Say WPr_vlr  Picture "@e 99,999,999.99"
   @ 19,54 Say WPr_vlus Picture "@e 99,999,999.99"
   @ 20,19 Say WPr_vend Picture "@e 99,999,999.99"
   Mdesc = WPr_vend * ( WPr_abat / 100 )
   Mliqui = WPr_vend - Mdesc
   resto  = (round(Mliqui,2)- int(mliqui))*100
   unidade= right(strzero(resto,2),1)
   vunidade=val(unidade)
   sunidade=10-vunidade
   if Mliqui > 1 .and. Mliqui < 10
      mliqui=int(mliqui)+((sunidade+resto)/100)
   Elseif mliqui >= 10
      if resto > 50
         sunidade = 100 - resto
      else
         sunidade =  50 - resto
      end
      mliqui=mliqui+sunidade/100
   End

   @ 20,54 Say Mliqui    Picture "@e 99,999,999.99"
   If WPr_vlr # 0
      Mvl01 = ( WPr_vlus * Ult_val_inde )
      Mvl02 = (Mvl01 * WPr_pcgn /100 ) + Mvl01
      @ 13,54 SAy Mvl01 Pict "@e 99,999,999.99"
   Endif
   @ 14,57 Say Wpr_dtue Pict "@K"
   @ 16,57 Say Wpr_dtum Pict "@K"
   if empty(Wpr_Dtum)
      @ 16,58 Say 'Sem Saida'
   End
   @ 15,60 Say WQtultentr Pict '9999.99'
   @ 17,53 Say WPr_pre_en Pict '@e 999,999,999.99'
   select Valores
   Set Order to 2
   DbGotop()
   Valores->( DbSeek(Dtos( WPr_DtUe ) ) )
   Xdolar = Valores->Valor
   Corrigido := WPr_pre_en / Xdolar * Ult_val_inde
   @ 18,53 Say Corrigido Picture '@e 999,999,999.99'

*/

/*
/*
   MSC INFORMATICA LTDA

   SISTEMA PARA GERENCIAMENTO DE LOJA DE AUTO PECAS

   PROGRAMADORES EVANDRO CAMPIGOTTO / JORGE SANT ANNA

   MODULO        M_ENTRAS.PRG

   *******                  FINALIDADE       ****************
   *                                                        *
   *   DAR ENTRADA DE PRODUTOS NO  ARQUIVO DE ESTOQUE       *
   *                                                        *
   **********************************************************

    Quarta, 26 de abril de 1995 …s 20:08 horas

#include "comando.ch"
#include "inkey.ch"

Function PRO_ENTRA()
Local Cur,Cor,Tela
Cur        := SetCursor( 1 )
Cor        := Setcolor( Cores->Movto )

Tela := Sc_exp(Row(),Col(),Row(),Col(),04,04,21,78,'S','[ Entrada De Produtos ]' , ;
        'C', Cores->Movto )
Select Grupo
While .T.

   Tel_Entra()
   Private  Wgr_codi           := space(01)
   Private  Wsb_codi           := space(02)
   Private  Wfo_codi           := space(03)
   Private  Wpr_codi           := space(03)
   Private  Wdata              := Ctod(Space(08))
   Private  UltData            := Ctod(Space(08))
   Private  Wsaldo_atual       := 0
   Private  Wpr_unid           := 0
   Private  Wpr_estq           := 0
   Private  Wquant             := 0
   Private  Wcusto             := 0
   Private  Wvalor             := 0
   Private  Vult               := 0
   Private  Wtipo              := '1'
   Private  Wult_forne         := Space(05)

   @ 05,21 Get Wtipo     Picture "9"     Valid ValTipo(@WTipo, 05, 25 )
   @ 06,21 Get WGr_codi  Picture "9"   //Valid valgru(@Wgr_codi,06,25,.T.,.T.)
   @ 07,21 Get WSb_codi  Picture "99"  //Valid valsgru(@Wsb_codi,07,25,.T.,.T.)
   @ 08,21 Get WPr_codi  Picture "999"
   @ 09,21 Get WFo_Codi  Picture "999" //Valid ValFor(@Wfo_codi,09,25,.T.,.T.)               And. Valpro(WGr_codi + WSb_codi + WPr_codi + WFo_Codi , 08 , 25 , .T., .F.,40)
   ReadModal(Getlist) ; Getlist := {}
   If Lastkey()=27
      Exit
   Endif

   G := StrZero(Val(WGr_Codi),1)
   S := StrZero(val(WSB_CODI),2)
   @ 07,21 Get S Picture "99"
   P := StrZero(val(WPr_Codi),3)
   @ 08,21 Get P Picture "999"
   F := StrZero(val(WFo_Codi),3)
   @ 08,21 Get F Picture "999"
   __KillRead() ; Getlist := {}
   chave := g+s+p+f
   select produto
   produto->(dbsetorder(1))

   If ! ProDuto->( DbSeek( Chave ) )
       CadPro(.T.)
   End

   /* preenche as variaveis do sistema com as do .DBF 

   For I := 1 to Produto->(FCount())
       campo := fieldname(i)
       varia := "W" + Campo
       &Varia := &Campo
   Next

   @ 06,21 Get WGr_codi   Picture "9"
   @ 07,21 Get WSb_codi   Picture "99"
   @ 08,21 Get WPr_codi   Picture "999"
   @ 08,25 Get Wpr_Desc   Picture "@X"
   @ 09,21 Get WFo_Codi   Picture "999"

   __KillRead() ; Getlist := {}
   @ 10,21 Say Wpr_unid   Picture "@X"
   @ 10,60 Say Wpr_orig   Picture "@X"
   @ 15,66 Say Wpr_estq   Picture "9999"
   @ 17,21 Say Wpr_pre_en Picture "@e 999,999,999,999.99"
   @ 18,21 Say Wult_forne Picture '99999'
   Select Representa
   If Representa->( DbSeek( Wult_Forne  ) )
     @ 18,27 Say Representa->rp_nome
   End
   @ 11,21 Get WPr_cdmo          Picture "99999"        VAlid Valinde(@Wpr_cdmo,11,30,.T.,.F.)
   @ 12,21 Get WData             Picture "@K"           VAlid ValVlr(@Wpr_cdmo,@WData,12,58)
   @ 13,21 Get WQuant            Picture "9999"         Valid ! Empty(Wquant)
   @ 13,64 get Wvalor            Picture "9,999,999.99" Valid ! Empty(Wvalor)
   ReadModal(Getlist) ; Getlist := {}

   Msaldo_atua = Wquant + WPr_estq

   @ 15,66 say Msaldo_atual Picture "999,999" Color Cores->Alerta

   select Valores
   Set Order to 1
   SeekLast(Wpr_cdmo , "Valores" , "Valores->codigo")
   Vult    := Valores->Valor             // Ultimo Valor desta Indexador
   Ultdata := Valores->Data
   @ 16,23 Say UltData           Picture "@K"
   @ 16,58 Say Vult              Picture "999,999,999.999999"
   Valores->( Dbseek( Wpr_cdmo + Dtos(Wdata ) ) )
   Mvlus = Valores->Valor

   Mcusto = Wvalor/Mvlus     // custo pelo indexador

   select produto
   produto->(dbsetorder(1))
   @ 14,21 Say Mcusto Pict "9,999,999.99"

   Mvl02 = (Mcusto*Vult)                       // valor atual em dolar

   @ 14,64 Say Mvl02 Pict "9,999,999.99"

   Mvaria = ROUND((WPr_vend * (WPr_abat/100)),2)

   Mliq = WPr_vend - Mvaria
   resto  = (round(Mliq,2)- int(mliq))*100
   unidade= right(strzero(resto,2),1)
   vunidade=val(unidade)
   sunidade=10-vunidade
   if Mliq > 1 .and. Mliq < 10
      mliq=int(mliq)+((sunidade+resto)/100)
   Elseif mliq >= 10
      if resto > 50
         sunidade = 100 - resto
      else
         sunidade =  50 - resto
      end
      mliq=mliq+sunidade/100
   End
   @ 15,21 Say Mliq/MVL02 Picture '9,999,999.99'
   @ 18,21 Get Wult_forne Picture '99999' Valid Valrep(@Wult_Forne,18,27,.T.,.F.)
   @ 19,21 Get Wlocal     Picture '@X'    Valid Val_local(@WLocal,19,27,.T.,.F.)
   ReadModal(GetList) ; GetList := {}

   If Mensagem("Confirma Dados Acima " , 2 ) == 1
      Select Produto
      If NEtRegistro("Produto")
         Produto->Pr_estq    :=  Msaldo_atua
         Produto->PR_pre_en  :=  Wvalor
         Produto->pr_dtue    :=  Wdata
         Produto->Pr_CdMO    :=  Wpr_cdMo
         Produto->QTULTENTR  :=  WQUANT
         Produto->Ult_forne  :=  WUlt_forne
         Produto->Local      :=  Wlocal
         DBCommit()
         Produto->(DBunlock())
      Endif
   Endif
Enddo
Sc_restexp( Tela )
SetColor( Cor )
Return Nil




Static Function Tel_entra()
@ 05,06 Say "Tipo movimento:                                                       "
@ 06,06 Say "Grupo.........:                                                       "
@ 07,06 Say "Subgrupo......:                                                       "
@ 08,06 Say "Produto.......:                                                       "
@ 09,06 Say "Fabricante....:                                                       "
@ 10,06 Say "Unidade.......:                     Cod. Fabric.....:                 "
@ 11,06 Say "Indice .......:                                                       "
@ 12,06 Say "Dta do Indice.:                     Valor Indexador.:                 "
@ 13,06 Say "Quantidade....:                     Valor De Entrada:                 "
@ 14,06 Say "Custo Index...:                     Entrada Indexada:                 "
@ 15,06 Say "Porcent Lucro.:                     Saldo Em Estoque:                 "
@ 16,06 Say "Ult. Dt.Index.:                     Valor...........:                 "
@ 17,06 Say "Valor Ult. Ent:                                                       "
@ 18,06 Say "Representante.:                                                       "
@ 19,06 Say "Local.........:                                                       "
Return nil



Function ValTipo( qTipo, linha, coluna )
Local Cor := SetColor()
Retorno := .F.
Wnome   := " "
if Empty( qTipo ) .or. ! qTipo $ "1234"
  Telatp := Sc_exp(Row(),Col(),Row(),Col(),09,08,14,37,'S','[ Movimenta‡Æo do Estoque ]' , ;
  'C', Cores->Zoom )
  tipo := 1
  @ 10 ,10 Prompt " 1 Entrada Normal       "
  @ 11 ,10 Prompt " 2 Devolucao de Cliente "
  @ 12 ,10 Prompt " 3 Garantia de Entrada  "
  @ 13 ,10 Prompt " 4 Garantia de Saida    "
  Menu to tipo
  do Case
     Case Tipo == 1
          qTipo := "1"
          Wnome := "Entrada Normal"
          Retorno := .t.
     Case Tipo == 2
          qTipo := "2"
          WNome := "Devolucao de Cliente"
          Retorno := .T.
     Case Tipo == 3
          qTipo := "3"
          Wnome := "Garantia de Entrada"
          Retorno := .t.
     Case Tipo == 4
          qTipo := "4"
          WNome := "Garantia de Saida"
          Retorno := .T.
  End
  Sc_restexp( Telatp )
end

If ! Empty(qTipo) .And. Qtipo $ '1234'
  Retorno := .T.
End

If Retorno
    if qTipo = "1"
       Wnome := "Entrada Normal"
    Elseif qTipo = "2"
          WNome := "Devolucao de Cliente"
    Elseif qTipo = "3"
          Wnome := "Garantia de Entrada"
    Elseif  qTipo = "4"
          WNome := "Garantia de Saida"
    End
    @ linha,coluna say Wnome Picture "@!"
End
SetColor( Cor )
Return(Retorno)

*/