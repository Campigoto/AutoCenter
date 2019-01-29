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
    public partial class Frm_OS : Frm_Master
    {

        private int SelectedRow = 0;

        public Frm_OS()
        {
            InitializeComponent();
            this.Text = Titulo_Tela("Ordem de Serviço");
            gb_geral.Text = Titulo_Grupo("Ordem de Serviço");
            tb_data_entrada.Text = (DateTime.Today).ToString();

            CarregarClientes();
            CarregarCarros();
            rb_aguarda.Checked = true;
            Global.NUM_OS = 0;

            print_button.Enabled = false;
        }

        #region Methods

        private void CarregarClientes()
        {
            ClienteCollection cliCol = new ClienteCollection();
            ClienteCollection clientes = new ClienteCollection(true, 1);
            Cliente cli = new Cliente();

            cli.CLI_NOME = "Escolha um Cliente";
            cliCol.Add(cli);
            cliCol.AddRange(clientes);

            cb_cliente.DataSource = cliCol;
            cb_cliente.DisplayMember = "CLI_NOME";
            cb_cliente.ValueMember = "CLI_CODIGO";

            cb_cliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void CarregarCarros()
        {
            CarroCollection carCol = new CarroCollection();
            CarroCollection carros = new CarroCollection(true, 1);
            Carro car = new Carro();

            car.CAR_PLACA = "Escolha um carro";
            carCol.Add(car);
            carCol.AddRange(carros);

            cb_carro.DataSource = carCol;
            cb_carro.DisplayMember = "CAR_PLACA";
            cb_carro.ValueMember = "CAR_PLACA";

            cb_carro.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_carro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void valor_final()
        {
            double desc = tb_desconto.Text == "" ? 0 : double.Parse(tb_desconto.Text);
            double valor = tb_valor.Text == "" ? 0 : double.Parse(tb_valor.Text);

            tb_total.Text = (valor - desc).ToString("0.00");
        }

        private void calculateTotal()
        {
            double valorTotal = 0;
            int rowcount = dgv_produtos.RowCount;
            for (int i = 0; i < rowcount; i++)
            {
                string valorString = dgv_produtos["total", i].Value.ToString();
                valorTotal += double.Parse(valorString);
            }
            tb_valor.Text = valorTotal.ToString("0.00");
            valor_final();
        }

        private double calculateTotalProduto(double unit, int qtd)
        {
            return unit * qtd;
        }

        private void showMessage(string msg)
        {
            MessageBox.Show(msg, "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Events

        private void dgv_produtos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int qtd;
                if (!int.TryParse(dgv_produtos["Qtd", e.RowIndex].Value.ToString(), out qtd))
                {
                    showMessage("Caracter Inválido para esta operação!");
                    dgv_produtos["Qtd", e.RowIndex].Value = 1;
                    return;
                }

                double valor;
                if(!double.TryParse(dgv_produtos["PRO_PRECO_VENDA_FORMATADO", e.RowIndex].Value.ToString(), out valor))
                {
                    showMessage("Caracter Inválido para esta operação!");
                    dgv_produtos["PRO_PRECO_VENDA_FORMATADO", e.RowIndex].Value = 0;
                    return;
                }
                dgv_produtos["total", e.RowIndex].Value = calculateTotalProduto(valor, qtd).ToString("0.00");
                calculateTotal();
            }
        }

        private void tb_adicionar_Click(object sender, EventArgs e)
        {
            FrmProcProdutos produtos = new FrmProcProdutos(4);
            produtos.Show();
        }

        private void tb_desconto_TextChanged(object sender, EventArgs e)
        {
            if (tb_desconto.Text != "")
            {
                tb_desconto.Text = Global.formatString(tb_desconto.Text);
                tb_desconto.SelectionStart = tb_desconto.Text.Length + 1;
                valor_final();
            }
        }

        private void dgv_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectedRow = e.RowIndex;
        }

        private void tb_remover_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_produtos.Rows.RemoveAt(SelectedRow);
            }
            catch
            {
                showMessage("Falha ao excluir a linha!");
            }
        }

        private void dgv_produtos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            print_button.Enabled = false;
            double valor = double.Parse(dgv_produtos["PRO_PRECO_VENDA_FORMATADO", e.RowIndex].Value.ToString());
            valor = Math.Round(valor, 2);
            dgv_produtos["PRO_PRECO_VENDA_FORMATADO", e.RowIndex].Value = valor.ToString("0.00");
            calculateTotal();

        }

        private void dgv_produtos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            print_button.Enabled = false;
            calculateTotal();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Fechar_Form();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            if (Global.NUM_OS != 0)
            {
                DialogResult answer = MessageBox.Show("Deseja atualizar esta Ordem de Serviço?", "Joincar", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    //Mantem o Global.NUM_OS com o valor que está
                }
                else if (answer == DialogResult.No)
                {
                    //Seta Global.NUM_OS para 0 ( cria nova OS )
                    Global.NUM_OS = 0;
                }
                else
                {
                    //Cancela operação
                    return;
                }
            }

            int statusCheck = (rb_aguarda.Checked) ? 0 : (rb_aprovado.Checked) ? 1 : (rb_cancelada.Checked) ? 2 : -1;

            if (cb_cliente.SelectedValue.ToString().Contains("BO.Cliente") || cb_cliente.SelectedValue.ToString() == "0")
            {
                showMessage("Campo Cliente é obrigatório!");
                cb_cliente.Focus();
                return;
            }
            else if (cb_carro.SelectedValue.ToString().Contains("BO.Carro"))
            {
                showMessage("Campo Carro é obrigatório!");
                cb_carro.Focus();
                return;
            }
            else if (statusCheck == -1)
            {
                showMessage("Campo Status da OS é obrigatório!");
                return;
            }
            else if (dgv_produtos.RowCount <= 0)
            {
                showMessage("Deve ter pelo menos 1 item adicionado!");
                return;
            }

            try
            {
                Ordem_Servico os = new Ordem_Servico();
                os.OS_CLIENTE = int.Parse(cb_cliente.SelectedValue.ToString());
                os.OS_PLACA = cb_carro.SelectedValue.ToString();
                os.OS_STATUS = statusCheck;
                os.OS_DATA_ENTRADA = DateTime.Parse(tb_data_entrada.Text);
                os.OS_DATA_ENTREGA = tb_data_entrega.Text.Trim() != "/  /" ? DateTime.Parse(tb_data_entrega.Text) : DateTime.Parse("01/01/1900");
                os.OS_OBS = tb_obs.Text;
                os.OS_VALOR_TOTAL = double.Parse(tb_total.Text);
                os.salvar();

                Historico_OS historico = new Historico_OS();
                historico.HIST_ID_OS = os.OS_ID;
                historico.HIST_CLIENTE = int.Parse(cb_cliente.SelectedValue.ToString());
                historico.HIST_PLACA = cb_carro.SelectedValue.ToString();

                historico.Salvar();


                Detalhes_OS detail = new Detalhes_OS();
                if (Global.NUM_OS != 0)
                {
                    detail.delete();
                }
                for (int i = 0; i < dgv_produtos.RowCount; i++)
                {
                    detail.DET_OS_ID = os.OS_ID;
                    detail.DET_PRODUTO = int.Parse(dgv_produtos["PRO_CODIGO", i].Value.ToString());
                    detail.DET_QTD = int.Parse(dgv_produtos["Qtd", i].Value.ToString());
                    detail.DET_VALOR_TOTAL = double.Parse(tb_total.Text);
                    detail.DET_VALOR_UNIT = double.Parse(dgv_produtos["PRO_PRECO_VENDA_FORMATADO", i].Value.ToString());
                    detail.DET_DESCONTO = tb_desconto.Text == "" ? 0 : double.Parse(tb_desconto.Text);
                    detail.save();
                }

                MessageBox.Show("Cadastro efetuado com sucesso!", "Joincar", MessageBoxButtons.OK);

                DialogResult print = MessageBox.Show("Deseja imprimir esta Ordem de Serviço?", "Joincar", MessageBoxButtons.YesNo);
                if (print == DialogResult.Yes)
                {
                    Frm_Imp_OS printOS = new Frm_Imp_OS(Global.NUM_OS);
                    printOS.Show();
                }
                print_button.Enabled = false;

                //Depois de salvar, volta tudo ao padrão
                cb_cliente.SelectedIndex = 0;
                cb_carro.SelectedIndex = 0;
                rb_aguarda.Checked = true;
                rb_aprovado.Checked = false;
                rb_cancelada.Checked = false;
                tb_data_entrada.Text = DateTime.Today.ToString();
                tb_data_entrega.Text = "";
                tb_obs.Text = "";
                tb_desconto.Text = "";

                dgv_historico.DataSource = null;
                dgv_produtos.DataSource = null;
                dgv_produtos.Rows.Clear();
                dgv_historico.Rows.Clear();

            }
            catch
            {
                showMessage("Falha ao salvar Ordem de Serviço");
            }
        }

        private void cb_carro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cb_carro.SelectedValue.ToString().Contains("BO.Carro") || cb_carro.SelectedValue.ToString().Contains("Escolha um carro")))
            {
                string placa = cb_carro.SelectedValue == null ? "" : cb_carro.SelectedValue.ToString();
                Historico_OS_Collection historico = new Historico_OS_Collection(placa, LoadHistOs.LoadByPlaca);
                dgv_historico.AutoGenerateColumns = false;
                dgv_historico.DataSource = historico;
            }

            Global.NUM_OS = 0;
        }

        private void dgv_historico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_produtos.Rows.Clear();
            int ID_OS = int.Parse(dgv_historico["ID_OS", e.RowIndex].Value.ToString());
            Global.NUM_OS = ID_OS;

            Detalhes_OS_Collection detailCol = new Detalhes_OS_Collection(ID_OS);

            foreach (Detalhes_OS det in detailCol)
            {
                cb_cliente.SelectedValue = det.DET_CLIENTE;
                cb_carro.SelectedValue = det.DET_PLACA;
                tb_desconto.Text = det.DET_DESCONTO.ToString("0.00");
                tb_obs.Text = det.DET_OBS;
                tb_data_entrada.Text = det.DET_DATA_ENTRADA.ToString();
                tb_data_entrega.Text = det.DET_DATA_ENTREGA != new DateTime(1900, 01, 01) ? det.DET_DATA_ENTREGA.ToString() : "";

                switch (det.DET_STATUS)
                {
                    case -1:
                        rb_cancelada.Checked = true;
                        break;
                    case 0:
                        rb_aguarda.Checked = true;
                        break;
                    default:
                        rb_aprovado.Checked = true;
                        break;
                }


                Produto prod = new Produto(det.DET_PRODUTO);
                dgv_produtos.Rows.Add(prod.PRO_CODIGO, prod.PRO_NOME, det.DET_VALOR_UNIT, det.DET_QTD, (det.DET_VALOR_UNIT * det.DET_QTD));

                print_button.Enabled = true;

            }
        }

        private void add_cliente_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            Global.NUM_OS = 1;
            clientes.Show();
        }

        private void add_carro_Click(object sender, EventArgs e)
        {
            Frm_Carro carros = new Frm_Carro();
            Global.NUM_OS = 1;
            carros.Show();
        }

        private void dgv_produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView cell = (DataGridView)sender;

            if (e.RowIndex > -1 && cell.Columns[e.ColumnIndex].Name == "Qtd")
            {
                FormataValorGridView format = new FormataValorGridView(dgv_produtos, "Qtd", this.Name, e.RowIndex);
                format.ShowDialog();
            }
        }
        #endregion

        private void print_button_Click(object sender, EventArgs e)
        {
            if (Global.NUM_OS != 0)
            {
                Frm_Imp_OS printOS = new Frm_Imp_OS(Global.NUM_OS);
                printOS.Show();
            }
            else
            {
                showMessage("Problema com o número da OS!");
            }
        }



    }
}
/*{
                button2.Enabled = true;
                if (MessageBox.Show("Confirma Impressão ?", "Pergunta !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Posicione o Papel e Pressione OK !", "Informa !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ImprimeTexto imp = new ImprimeTexto();

                    imp.Inicio("LPT1");

                    for (int i = 0; i < boletosDataGridView.RowCount - 1; i++)
                    {
                        int socioId = Convert.ToInt32(boletosDataGridView[1, i].EditedFormattedValue.ToString());
                        string emissao = boletosDataGridView[2, i].EditedFormattedValue.ToString();
                        string vencimento = boletosDataGridView[3, i].EditedFormattedValue.ToString();
                        string valor = boletosDataGridView[4, i].EditedFormattedValue.ToString();
                        string socioNome = this.dbLyraDataSet.Socios.FindByIDSOCIO(socioId).NOME;
                        string socioEndereco = this.dbLyraDataSet.Socios.FindByIDSOCIO(socioId).ENDERECO;
                        string socioBairro = this.dbLyraDataSet.Socios.FindByIDSOCIO(socioId).BAIRRO;
                        string socioCep = this.dbLyraDataSet.Socios.FindByIDSOCIO(socioId).CEP;
                        string socioCidade = this.dbLyraDataSet.Socios.FindByIDSOCIO(socioId).CIDADE;
                        string socioEstado = this.dbLyraDataSet.Socios.FindByIDSOCIO(socioId).UF;
                        string mesReferencia = DateTime.Parse(boletosDataGridView[3, i].EditedFormattedValue.ToString()).Month.ToString() + "/" + DateTime.Parse(boletosDataGridView[3, i].EditedFormattedValue.ToString()).Year.ToString();

                        imp.Pula(2);
                        imp.ImpCol(60, vencimento);
                        imp.Pula(5);
                        imp.ImpCol(60, valor);
                        imp.Pula(3);
                        imp.ImpLF("Ref. Mensalidade : " + mesReferencia);
                        imp.ImpLF("Pagamento ate 12/" + mesReferencia + " c/ 5% de desconto");
                        imp.ImpLF("Apos vencimento 5% de multa ao mes ");
                        imp.ImpLF("mais 1% de juros de mora");
                        imp.ImpLF("Apos vencimento : Lyra ou Bradesco ");
                        imp.Pula(1);
                        imp.ImpLF(socioNome);
                        imp.ImpLF(socioEndereco + " - " + socioBairro);
                        imp.ImpLF(FormataString("##.###-####", socioCep) + " - " + socioCidade + " - " + socioEstado);
                        imp.Pula(5);


                    }
                    imp.Fim();
                    MessageBox.Show("Fim da Impressão", "Informa !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
        //            ImprimeTexto imp = new ImprimeTexto();

        //            imp.Inicio("LPT1");

        //            imp.ImpLF("Carlos dos Santos - MVP C#");
        //            imp.ImpLF("CDS Informática Ltda.");
        //            imp.ImpLF("-------------------------------------");
        //            imp.ImpLF("Componente de impressao em modo texto");
        //            for (int i = 0; i < 5; i++)
        //            {
        //                imp.ImpLF("Linha impressa " + i.ToString());
        //            }
        //            imp.ImpLF(imp.NegritoOn + "Negrito ligado" + imp.NegritoOff);
        //            imp.ImpLF(imp.Expandido + "Expandido" + imp.Normal);
        //            imp.ImpLF(imp.Comprimido + "Comprimido" + imp.Normal);
        //            imp.Pula(2);
        //            imp.ImpCol(10, "Coluna 10");
        //            imp.ImpCol(40, "Coluna 40");
        //            imp.Pula(2);
        //            imp.Imp((char)27 + "0");
        //            imp.ImpLF("8 linha ppp");
        //            imp.ImpLF("8 linha ppp");
        //            imp.ImpLF("8 linha ppp");
        //            imp.Imp((char)27 + "2");
        //            imp.ImpLF("6 linha ppp");
        //            imp.ImpLF("6 linha ppp");
        //            imp.ImpLF("6 linha ppp");
        //            imp.Pula(2);
        //            imp.Fim(); 
        //        }
        //    }
        //}

 * 
 * Emissão de controle de vendas/orçamento *joincar
 * 
 * ************************

Function Balmec(Qual)
Local Retorno := .F.
If Qual $ "Bb" .oR. Qual $"Mm"

   Retorno := .T.

Else
   if Mensagem("Cliente de Mecanica ? "  , 2 ) == 1
      qual := "M"
   Else
      qual := "B"
   End
   Retorno := .T.

End

Return Retorno

Static Function Dados()
Local Tela := Sc_Exp(row(),col(),row(),col(),10,04,19,75,'D', '[ Informe os Dados do Cliente     ]' , "C" , Cores->Fundo )
Local Tela2
Public cCliente   := Space(05)
Public cTipoVenda := Space(01)
Public cOrc_venda := Space(01)
Public Confirma   := "N"
cNome      := Space(40)
cDesconto  := "S"
pDesconto  := 0
nVal_Entr  := 0
dDt_vencto := Ctod(Space(08))
SetCursor(1)
@ 11,06 Say "           Cliente:"
@ 12,06 Say "          Endere‡o:"
@ 13,06 Say "              Fone:"
@ 14,06 Say "A [V]ista  [P]razo:"
@ 15,06 Say "   Desconto Normal:"
@ 16,06 Say " Valor da  Entrada:"
@ 17,06 Say "Data do Vencimento:"
@ 18,06 Say "Ok Para Imprimir ?:"

@ 11,27 Get cCliente   Picture "99999" Valid F_val_Bal(@cCliente,11,33,.T.,.F.)
Read
If LastKey() == K_ESC
   SetCursor( 0 ) ;  Sc_restExp( Tela ) ;  Return .F.
End
cNome     := Balcao->Cl_nomem
cEndereco := Balcao->cl_enderm
cFone     := Balcao->cl_tel1m
cMec_Bal  := Balcao->Tipo

@ 12,27 Say cEndereco  Picture "@!"
@ 13,27 Say cFone Picture "@r (9999)999-9999"

If ! Empty( Balcao->Cl_situa )
     Alerta("Cliente Esta Bloqueado " + Balcao->CL_Situa )
     Sc_restExp( Tela )
     Return .F.
End
If cCliente == "99999"
   cTipoVenda := 'V'
   @ 11,33 Get CNome Picture "@!"
   @ 12,27 Get cEndereco Picture "@!"
   @ 13,27 Get cFone Picture "@r (9999)999-9999"
   Read
   @ 14,27 get cTipoVenda Picture "!"
   Clear Gets
End

If tipo == 2 .AND. CCLIENTE # '99999'
   if Cmec_Bal   == "M"
      cDesconto  := 'N'
      cTipoVenda := 'P'
   End
   @ 14,27 get cTipoVenda Picture "!" Valid cTipoVenda $ "VvPp"
   Read
End
@ 15,27 Get cDesconto  Picture "!"    Valid cDesconto $ 'SsNn'
@ 15,30 Get pDesconto  Picture "999.99%" When cDesconto $ 'nN'
@ 16,27 Get nVal_Entr  Picture "@e 999,999.99"  When cTipoVenda $ "pP"
@ 17,27 Get dDt_Vencto Picture "@D"             When cTipoVenda $ "Pp"  Valid dDt_vencto >= Parametro->Data

@ 18,27 Get Confirma   Picture "!"  Valid Confirma $ "SsNn"
ReadModal(Getlist) ; Getlist := {}
If Confirma == "N"
   Sc_restExp( Tela )
   Return .f.
End

If LastKey() == K_ESC
   SetCursor( Cur )
   Sc_restExp( Tela )
   SetColor( Cor )
   Return Nil
End
While .T.
   If ! Password(2)
       Loop
   End
   Exit
End
Set Printer to Lpt1
Comprime  := Impressora->Lcomp
Do While .T.
   If ! PPrinter()
      Loop
   End
   Set Printer On
   Set Device  To Printer
   setprc(00,00)
   Mtotalb = 0
   Mt_Liq := 0
   vValCompra := 0
   Totg   = 0
   L      = 0
   Linha  = 0
   p      = 1
   @ prow(),pcol() Say &Comprime
   Select Vendas
   Go Top
   While Vendas->(!Eof())
      If Linha = 0
         Topu999()
         Linha = 7
         L     = 7
         p++
      Endif
      @ Linha  ,01 Say Vendas->Gr_codi + '.'
      @ Linha  ,03 Say Vendas->Sb_codi + '.'
      @ Linha  ,06 Say Vendas->pr_Codi + '.'
      @ Linha  ,10 Say Vendas->Fo_Codi
      @ Linha  ,14 Say Left(Vendas->Pr_Desc,35)
      @ Linha  ,50 Say Vendas->Quant Pict '999'
      @ Linha  ,55 Say Vendas->Bruto * vendas->Quant    Pict '@E 999,999.99'
      Linha +=1
      Mtotalb := Mtotalb + Vendas->Bruto * vendas->Quant
      Mt_liq  := Mt_liq  + Vendas->Liquido * Vendas->Quant

      If Tipo == 2 // .And. CCliente # '99999'
         Select Baixa
         NetAppend("Baixa")
         Baixa->cliente  :=  cCliente
         Baixa->nome     :=  cNome
         Baixa->gr_codi  :=  Vendas->gr_codi
         Baixa->sb_codi  :=  Vendas->sb_codi
         Baixa->fo_codi  :=  Vendas->fo_codi
         Baixa->pr_codi  :=  Vendas->Pr_Codi
         Baixa->quant    :=  Vendas->quant
         Baixa->liquido  :=  Vendas->liquido
         Baixa->bruto    :=  Vendas->bruto
         Baixa->pr_Desc  :=  Vendas->Pr_Desc
         If pDesconto # 0
            Baixa->encarg   :=  pDesconto
         End
         Baixa->mec_bal   := cMec_Bal
         Baixa->dt_saida  := parametro->Data
         DbCommit()
         DbUnlock()
         Select Produto
         Set Order to 1
         If Produto->(DbSeek( Vendas->Gr_Codi+Vendas->Sb_Codi+Vendas->Pr_Codi+Vendas->Fo_Codi) )
            If NetRegistro("Produto")
               Produto->pr_estq := Produto->Pr_estq - Vendas->Quant
               DbCommit()
               DbUnlock()
            End
         End

      End
      Select Vendas
      skip
   End               // fim do arquivo
   Linha +=4
   @ Linha,00 Say Repl("-",70)
   linha ++
   @ Linha,38 Say "Total        R$"
   @ Linha,55 Say MtotalB Picture "@E 9,999,999.99"
   Linha ++
   @ Linha,00 Say Replicate("-",70)
   Linha ++
   if cDesconto $ "nN"
      if pDesconto > 0
         Desconto := Mtotalb * pDesconto  / 100
      Else
         Desconto := ( Mtotalb * pDesconto  / 100 ) * ( - 1 )
      End
   Else
      Desconto := Mtotalb - Mt_Liq
   End
   If Tipo == 1   // orcamento
      @ Linha,00 Say "A Vista Desconto R$"
      @ Linha,20 Say Desconto Picture "@E 9,999,999.99"
      @ Linha,34 Say "A Pagar C/ Desc. R$"
      @ Linha,55 Say Mtotalb - Desconto Picture "@E 9,999,999.99"
      Linha ++
      @ Linha,00 Say Replicate("=",70)
      Linha ++
      @ linha,00 Say "Este orcamento esta sujeito a altera‡ao nos pre‡os sem previo aviso"
      Linha ++
   End
   If Tipo == 2  .And.  cMec_Bal == "B"  // venda
      If nVal_entr == 0
         If pDesconto < 0
            @ Linha,00 Say "        Encargos R$"
            @ Linha,20 Say Desconto Picture "@E 9,999,999.99"
            @ Linha,34 Say "A Pagar C/ Enc.  R$"
            @ Linha,55 Say Mtotalb + Desconto Picture "@E 9,999,999.99"
            vValCompra :=  Mtotalb + Desconto
         Else
            @ Linha,00 Say "        Desconto R$"
            @ Linha,20 Say Desconto Picture "@E 9,999,999.99"
            @ Linha,34 Say "A Pagar C/ Desc. R$"
            @ Linha,55 Say Mtotalb - Desconto Picture "@E 9,999,999.99"
            vValCompra :=  Mtotalb - Desconto
         End
         Linha ++
         @ Linha,00 Say Replicate("=",70)
      Else
         If pDesconto  < 0
            @ LINHA,00 Say "Entrada "
            @ Linha,10 Say nVal_Entr Picture "@e 9,999.99"
            @ linha,20 Say "Encargos "
            @ Linha,29 Say ( Mtotalb * pDesconto  / 100 ) * ( - 1 )   Picture "@E 9,999.99"
            @ Linha,40 Say "A Pagar R$"
            @ Linha,55 Say  Mtotalb + ( ( Mtotalb * pDesconto  / 100 ) * ( - 1 ) ) - nVal_Entr Picture "@E 9,999,999.99"
            vValCompra :=   Mtotalb + ( ( Mtotalb * pDesconto  / 100 ) * ( - 1 ) )
            Linha ++
         Else
            @ LINHA,00 Say "Entrada "
            @ Linha,10 Say nVal_Entr Picture "@e 9,999.99"
            @ Linha,20 Say "Desconto R$"
            @ Linha,29 Say  Desconto  Picture "@e 9,999.99"
            @ Linha,40 Say "A Pagar R$"
            @ Linha,55 Say ( Mtotalb - Desconto ) -  nVal_Entr Picture "@E 9,999,999.99"
            vValCompra :=   Mtotalb  - Desconto
            Linha ++
         End
      End
   ElseIf Tipo == 2
      If  cmec_Bal == "M" .Or. cTipoVenda == "Pp"
         If pDesconto  < 0
            @ LINHA,00 Say "Entrada "
            @ Linha,10 Say nVal_Entr Picture "@e 9,999.99"
            @ linha,20 Say "Encargos "
            @ Linha,29 Say ( Mtotalb * pDesconto  / 100 ) * ( - 1 )   Picture "@E 9,999.99"
            @ Linha,40 Say "A Pagar R$"
            @ Linha,55 Say  Mtotalb + ( ( Mtotalb * pDesconto  / 100 ) * ( - 1 ) ) - nVal_Entr Picture "@E 9,999,999.99"
            vValCompra :=   Mtotalb + ( ( Mtotalb * pDesconto  / 100 ) * ( - 1 ) )
            Linha ++
         Else
            @ LINHA,00 Say "Entrada "
            @ Linha,10 Say nVal_Entr Picture "@e 9,999.99"
            @ Linha,20 Say "Desconto R$"
            @ Linha,29 Say  Desconto  Picture "@e 9,999.99"
            @ Linha,40 Say "A Pagar R$"
            @ Linha,55 Say ( Mtotalb - Desconto ) -  nVal_Entr Picture "@E 9,999,999.99"
            vValCompra :=   Mtotalb  - Desconto
            Linha ++
         End
      End
      @ Linha,00 Say Replicate("=",70)
      Linha ++
      Select Vendas
   End
   If cTipoVenda $ "Pp"
      Select MovCli
      If NetAppend("MovCli")
         MovCli->Cod_cli   := cCliente
         MovCli->nome      := cNome
         MovCli->cod_nf    := StrZero(mContr,6)
         MovCli->dt_compra := Parametro->Data
         MovCli->val_comp  := vValCompra
         MovCli->dt_vencto := dDt_vencto
         MovCli->val_entr  := nVAl_entr
         mOvCli->val_parc  := vValCompra -  nVal_entr
         movcli->obs       := cDesconto + strzero( pDesconto )
         DbCommit()
         DbUnlock()
      End
   End
   If cTipovenda $ "Pp"
      @ linha + 1 , 01 Say "Vencimento "
      @ linha + 1 , 15 Say dDt_Vencto Picture "@D"
      @ linha + 1 , 40 Say Replicate("_",30)
      @ linha + 2 , 50 Say "ASSINATURA"
      Linha += 2
   End
   @ linha + 1 ,00 say CHR(27) + Chr(52)
   @ linha + 1, 01 Say "MSC INFORMATICA  - (047) 422-4122 "
   linha += 3
   For i := 1 to 05
     @ linha , 01 Say ""
     Linha ++
   Next
   @ Linha,00   Say Parametro->Nome_loja   Picture "@!"
   @ LINHA+1,00 SAY Parametro->Endereco    Picture "@!"
   @ LINHA+1,Pcol() +2 SAY Parametro->bairro      Picture "@!"
   @ LINHA+2,00 SAY Parametro->cidade      Picture "@!"
   @ linha+2,Pcol() + 2 Say Parametro->uf  Picture "@!"
   @ linha+2,Pcol() + 2 Say Parametro->cep Picture "@r 99.999.999"
   @ linha+3,00 Say "Fone "
   @ Linha+3,Pcol()+2 Say Parametro->fone Picture "@R (9999)999-9999"
   @ linha+3,Pcol() + 2 Say "Fax "
   @ linha+3,pcol()+2 Say Parametro->fax  Picture "@R (9999)999-9999"
   @ linha+5, pcol() Say CHR(27) + CHR(53)
   linha += 06
   @ linha , 00 say ""
   Set Printer Off
   Set Devi To Scre
   Exit
Enddo
Return .t.

******************
Function Topu999()
Local Comprime := Impressora->Lcomp
@ 00,00 Say &Comprime
@ 00,00 Say Repl("=",70)
If tipo == 1
   @ 01,00 Say "  Pg. " + Str(p,1) + " Ct. "+Strzero(Orcamento->Controle,6)+"         Orcamento            Emissao: "+Dtoc(Date())
Else
   @ 01,00 Say "  Pg. " + Str(p,1) + " Ct. "+Strzero(Vendas->Controle,6)+" * * * Orcamento * * * Emissao: "+Dtoc(Date()) +" " + time()
End
@ 02,00 Say "  Cliente : " +  cNome
@ 02,45 say Senhas->codigo + ' - ' + Senhas->nome
@ 03,00 Say "  End."
@ 03,07 Say cEndereco
@ 03,50 Say "Fone"
@ 03,55 Say cFone
@ 04,00 Say Repl("-",70)
@ 05,00 Say "Codigo        Descricao do Produto                Qte     Valor"
@ 06,00 Say Repl("-",70)

Return Nil
 * 
*/