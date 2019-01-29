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
    public partial class Frm_Master : Form
    {
        public Frm_Master()
        {
            InitializeComponent();

            Permitir(1, Global.CAD_CIDADE);
            Permitir(4, Global.CAD_PRODUTO);
            Permitir(7, Global.CAD_GRUPO);
            Permitir(10, Global.CAD_SUBGRUPO);
            Permitir(13, Global.CAD_HISTORICO);
            Permitir(16, Global.CAD_CLIENTE);
            Permitir(19, Global.CAD_FORNECEDOR);
            Permitir(22, Global.MOV_CONTAS_PAGAR);
            Permitir(25, Global.MOV_CHEQUE_PAGAR);
            Permitir(28, Global.MOV_PAGAMENTO);
            Permitir(29, Global.MOV_COMPRA);
            Permitir(31, Global.REL_PRODUTO);
            Permitir(32, Global.REL_CONTAS_PAGAR);
            Permitir(33, Global.REL_COMPRA);
            Permitir(34, Global.UTI_FUNCIONARIO);
            Permitir(37, Global.CAD_HIST_LANCAMENTO);
            Permitir(40, Global.REL_LOG);
        }

        public void Permitir(int OF_OPERACAO, bool true_false)
        {
            switch (OF_OPERACAO)
            {
                case 1:
                    Global.CAD_CIDADE = true_false;
                    btn_cad_cidade.Enabled = true_false;
                    break;

                case 4:
                    Global.CAD_PRODUTO = true_false;
                    btn_cad_produto.Enabled = true_false;
                    break;

                case 7:
                    Global.CAD_GRUPO = true_false;
                    btn_cad_grupo.Enabled = true_false;
                    break;

                case 10:
                    Global.CAD_SUBGRUPO = true_false;
                    btn_cad_subgrupo.Enabled = true_false;
                    break;

                case 13:
                    Global.CAD_HISTORICO = true_false;
                    //btn_cad_historico.Enabled = true_false;
                    break;

                case 16:
                    Global.CAD_CLIENTE = true_false;
                    btn_cad_cliente.Enabled = true_false;
                    break;

                case 19:
                    Global.CAD_FORNECEDOR = true_false;
                    btn_cad_fornecedor.Enabled = true_false;
                    break;

                case 22:
                    Global.MOV_CONTAS_PAGAR = true_false;
                    btn_mov_contas_pagar.Enabled = true_false;
                    break;

                case 25:
                    Global.MOV_CHEQUE_PAGAR = true_false;
                    btn_mov_cheque_pagar.Enabled = true_false;
                    break;

                case 28:
                    Global.MOV_PAGAMENTO = true_false;
                    btn_mov_pagto.Enabled = true_false;
                    break;

                case 29:
                    Global.MOV_COMPRA = true_false;
                    btn_mov_compra.Enabled = true_false;
                    break;

                case 31:
                    Global.REL_PRODUTO = true_false;
                    btn_rel_produto.Enabled = true_false;
                    break;

                case 32:
                    Global.REL_CONTAS_PAGAR = true_false;
                    btn_rel_contas_pagar.Enabled = true_false;
                    break;

                case 33:
                    Global.REL_COMPRA = true_false;
                    btn_rel_compra.Enabled = true_false;
                    break;

                case 34:
                    Global.UTI_FUNCIONARIO = true_false;
                    btn_uti_funcionario.Enabled = true_false;
                    break;

                case 37:
                    Global.CAD_HIST_LANCAMENTO = true_false;
                    btn_cad_hist_lanc.Enabled = true_false;
                    break;

                case 40:
                    Global.REL_LOG = true_false;
                    btn_rel_log.Enabled = true_false;
                    break;
            }
        }

        public string Titulo_Tela(string tela)
        {
            return "3Pratos - Tela: " + tela;
        }

        public string Titulo_Grupo(string tela)
        {
            string nome = tela + ", Usuário: " + Global.FUN_NOME;

            nome += ", Data/Hora: " + DateTime.Now.ToString("dd/MM/yyyy");

            nome += " " + DateTime.Now.ToString("HH:mm");

            return nome;
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_cad_cidade_Click(object sender, EventArgs e)
        {
            Frm_Cidade form = new Frm_Cidade();
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_cad_produto_Click(object sender, EventArgs e)
        {
            FrmProcProdutos form = new FrmProcProdutos(0);
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_cad_grupo_Click(object sender, EventArgs e)
        {
            FrmGrupos form = new FrmGrupos();
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_cad_subgrupo_Click(object sender, EventArgs e)
        {
            FrmSubGrupos form = new FrmSubGrupos();
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_cad_cliente_Click(object sender, EventArgs e)
        {
            FrmProcClientes form = new FrmProcClientes();
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_cad_fornecedor_Click(object sender, EventArgs e)
        {
            FrmProcFornecedores form = new FrmProcFornecedores();
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_mov_contas_pagar_Click(object sender, EventArgs e)
        {
            Frm_Contas_Pagar form = new Frm_Contas_Pagar(0);
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_mov_cheque_pagar_Click(object sender, EventArgs e)
        {
            Frm_Cheques_Pagar form = new Frm_Cheques_Pagar(0);
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_mov_pagto_Click(object sender, EventArgs e)
        {
            Frm_Pagto_Pagar form = new Frm_Pagto_Pagar();
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_mov_compra_Click(object sender, EventArgs e)
        {
            Frm_Compra form = new Frm_Compra(0);
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_rel_contas_pagar_Click(object sender, EventArgs e)
        {
            Frm_Rel_Contas_Pagar form = new Frm_Rel_Contas_Pagar();
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_rel_produto_Click(object sender, EventArgs e)
     
        {
           
        }

        private void btn_rel_compra_Click(object sender, EventArgs e)
        {

        }

        private void btn_uti_funcionario_Click(object sender, EventArgs e)
        {
            Frm_Funcionario form = new Frm_Funcionario();
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cad_hist_lanc_Click(object sender, EventArgs e)
        {
            FrmHistorico_Lancamento form = new FrmHistorico_Lancamento();
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void produtoXFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Rel_ProdutoXFornecedor form = new Frm_Rel_ProdutoXFornecedor();
            //form.Show();

            //if (this.Text.Contains("Inicio"))
            //{
            //    this.Hide();
            //}
            //else
            //{
            //    this.Hide();
            //    this.Close();
            //}
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Rel_Produtos form = new Frm_Rel_Produtos();
            //form.Show();

            //if (this.Text.Contains("Inicio"))
            //{
            //    this.Hide();
            //}
            //else
            //{
            //    this.Hide();
            //    this.Close();
            //}
        }

        private void grupoProdutoXFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Rel_GrupoProdtoXFornecedor form = new Frm_Rel_GrupoProdtoXFornecedor();
            //form.Show();

            //if (this.Text.Contains("Inicio"))
            //{
            //    this.Hide();
            //}
            //else
            //{
            //    this.Hide();
            //    this.Close();
            //}
        }

        private void btn_rel_log_Click(object sender, EventArgs e)
        {
            Frm_Rel_Log form = new Frm_Rel_Log();
            form.Show();

            if (this.Text.Contains("Inicio"))
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }
    }
}