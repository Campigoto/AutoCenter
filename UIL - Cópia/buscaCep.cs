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
    public partial class buscaCep : Form
    {
        private string cidade;
        private string bairro;
        private string rua;
        private string formName;
        private string _filtro;

        public buscaCep()
        {
            InitializeComponent();
            Carrega_Cidade();
        }

        public buscaCep(string _cidade, string _bairro, string _rua, string _FrmName)
        {
            InitializeComponent();

            this.cidade = _cidade.ToString();
            this.bairro = _bairro.ToString();
            this.rua    = _rua.ToString();
            this.formName = _FrmName;

            Carrega_Cidade();
            if (this.cidade != "")
            {
                this.cb_cidade.SelectedIndex = cb_cidade.FindString(this.cidade,0);
                this._filtro = cb_cidade.SelectedValue.ToString();
                Carrega_Bairro(this._filtro);
                
                EventArgs e = new EventArgs();
                this.pesquisa_bairro(cb_bairro, e);

                this.cb_bairro.SelectedIndex = cb_bairro.FindString(this.bairro, 0);
                if (this.bairro != "")
                {
                    this._filtro = cb_bairro.SelectedValue.ToString();
                    Carrega_Rua(this._filtro);

                    if (this.rua != "")
                    {
                        this.Pesquisa_Rua(cb_rua, e);
                        this.cb_rua.SelectedIndex = cb_rua.FindString(this.rua, 0);
                    }
                }
            }

        }

        private void Carrega_Cidade()
        {
            CidadeCollection cidade_todos = new CidadeCollection(true, 1);
            this.cb_cidade.DataSource = cidade_todos;
            cb_cidade.DisplayMember = "CID_NOME";
            cb_cidade.ValueMember = "CID_CODIGO";

            cb_cidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_cidade.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Carrega_Bairro(string filtro)
        {
            CepCollection bairro = new CepCollection(CepLoadType.LoadByCodCid, filtro, 2);
            cb_bairro.DataSource = bairro;
            cb_bairro.DisplayMember = "BAIRRO";
            cb_bairro.ValueMember = "BAIRRO";

            cb_bairro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_bairro.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Carrega_Rua(string filtro)
        {
            CepCollection rua = new CepCollection(CepLoadType.LoadByBairro, filtro, 2);
            cb_rua.DataSource = rua;
            cb_rua.DisplayMember = "NOME_RUA";
            cb_rua.ValueMember = "NOME_RUA";

            cb_rua.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_rua.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void pesquisa_cep(object sender, EventArgs e)
        {
            string bairro = cb_bairro.SelectedValue.ToString();
            string cidade = cb_cidade.SelectedValue.ToString();
            string rua = cb_rua.SelectedValue.ToString();

            CepCollection cep = new CepCollection(CepLoadType.LoadCepByAll,cidade, bairro, rua, 3);
            cb_cep.DataSource = cep;
            cb_cep.DisplayMember = "CEP_LOCAL";
            cb_cep.ValueMember = "CEP_ID";

            cb_cep.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_cep.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void pesquisa_bairro(object sender, EventArgs e)
        {
            string filtro = cb_cidade.SelectedValue.ToString() != "" ? cb_cidade.SelectedValue.ToString() : "";
            Carrega_Bairro(filtro.Trim());
        }

        private void Pesquisa_Rua(object sender, EventArgs e)
        {
            string filtro = cb_bairro.SelectedValue.ToString() != "" ? cb_bairro.SelectedValue.ToString() : "";
            Carrega_Rua(filtro.Trim());
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            string gb;
            if (this.formName == "FrmClientes")
            {
                gb = "gb_cliente";
            }
            else
            {
                gb = "gb_fornecedor";
            }

            Application.OpenForms[formName].Controls[gb].Controls["cb_cidade"].Text = this.cb_cidade.Text;
            Application.OpenForms[formName].Controls[gb].Controls["tb_bairro"].Text = this.cb_bairro.Text;
            Application.OpenForms[formName].Controls[gb].Controls["tb_logradouro"].Text = this.cb_rua.Text;
            Application.OpenForms[formName].Controls[gb].Controls["tb_cep"].Text = this.cb_cep.Text;

            this.Close();

        }
    }
}
