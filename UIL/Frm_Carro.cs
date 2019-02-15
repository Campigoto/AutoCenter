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
    public partial class Frm_Carro : Frm_Master
    {
        int ORDER = 1;
        public Frm_Carro()
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Cadastro de Cidade");
            gb_carro.Text = Titulo_Grupo("Cadastro");

            Global.CAR_ID = 0;

            Carregar_Carros();            
        }

        private void Carregar_Carros()
        {
            CarroCollection carros = new CarroCollection(true, ORDER);
            dgv_carro.DataSource = carros;
        }

        private void btn_carro_gravar(object sender, EventArgs e)
        {
            Carro car = new Carro(tb_placa.Text);

            if (this.tb_placa.Text.Trim() == "-") { MessageBox.Show("Campo Placa é obrigatório" , "Joincar", MessageBoxButtons.OK); this.tb_placa.Focus();  return; }
            if (this.tb_marca.Text.Trim() == "")  { MessageBox.Show("Campo Marca é obrigatório" , "Joincar", MessageBoxButtons.OK); this.tb_marca.Focus();  return; }
            if (this.tb_modelo.Text.Trim() == "") { MessageBox.Show("Campo Modelo é obrigatório", "Joincar", MessageBoxButtons.OK); this.tb_modelo.Focus(); return; }
            if (this.tb_cor.Text.Trim() == "")    { MessageBox.Show("Campo Cor é obrigatório"   , "Joincar", MessageBoxButtons.OK); this.tb_cor.Focus();    return; }
            if (this.tb_ano.Text.Trim() == "")    { MessageBox.Show("Campo Ano é obrigatório"   , "Joincar", MessageBoxButtons.OK); this.tb_ano.Focus();    return; }

            car.CAR_PLACA = this.tb_placa.Text.ToUpper();
            car.CAR_MODELO = this.tb_modelo.Text;
            car.CAR_MARCA = this.tb_marca.Text;
            car.CAR_COR = this.tb_cor.Text;
            car.CAR_ANO = this.tb_ano.Text == "" ? 0 : int.Parse(this.tb_ano.Text.ToString());
            car.CAR_KM_ULTIMA_TROCA_OLEO = this.tb_km_ultima_troca.Text == "" ? 0 : long.Parse(this.tb_km_ultima_troca.Text);
            car.CAR_KM_CADA_TROCA_OLEO = this.tb_cada_troca.Text == "" ? 0 : long.Parse(this.tb_cada_troca.Text);
            car.CAR_KM_ULTIMA_TROCA_CORREIA = this.tb_ultima_troca_correia.Text == "" ? 0 : long.Parse(this.tb_ultima_troca_correia.Text);
            car.CAR_KM_CADA_TROCA_CORREIA = this.tb_cada_troca_correia.Text == "" ? 0 : long.Parse(this.tb_cada_troca_correia.Text);
            car.Salvar();

            Carregar_Carros();


            Log log = new Log();
            log.LOG_USUARIO = Global.FUN_CODIGO;
            log.LOG_DATA = DateTime.Now;
            log.LOG_TELA = this.Text;

            if (tb_placa.Text == string.Empty)
            {
                log.LOG_DESCRICAO = "Cadastrou o carro de placa: " + tb_placa.Text + ", marca: " + tb_marca.Text + ".";
            }
            else
            {
                log.LOG_DESCRICAO = "Alterou o carro de placa: " + tb_placa.Text + ", marca: " + tb_marca.Text + ".";
            }
            log.Save();

            if (Configuracoes.Default.Mensagem_Gravar == true)
            {
                if (Global.CAR_ID == 0)
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Alteração efetuada com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (Global.NUM_OS == 1)
            {
                CarroCollection carCol = new CarroCollection();
                CarroCollection carros = new CarroCollection(true, 1);
                ComboBox dropdown_carro = (ComboBox)Application.OpenForms["Frm_OS"].Controls["gb_geral"].Controls["cb_carro"];
                Carro novoCarro = new Carro();

                novoCarro.CAR_PLACA = "Escolha um carro";
                carCol.Add(car);
                carCol.AddRange(carros);

                dropdown_carro.DataSource = carCol;
                dropdown_carro.DisplayMember = "CAR_PLACA";
                dropdown_carro.ValueMember = "CAR_PLACA";

                dropdown_carro.AutoCompleteSource = AutoCompleteSource.ListItems;
                dropdown_carro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                dropdown_carro.SelectedValue = car.CAR_PLACA;
                Global.NUM_OS = 0;
                this.Close();
            }
            limpar();
        }

        private void btn_limpar_click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_carro_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Global.CAR_ID = int.Parse(dgv_carro.Rows[e.RowIndex].Cells["CAR_ID"].Value.ToString());
                this.tb_placa.Text = dgv_carro.Rows[e.RowIndex].Cells["Placa"].Value.ToString();
                this.tb_modelo.Text = dgv_carro.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
                this.tb_ano.Text = dgv_carro.Rows[e.RowIndex].Cells["Ano"].Value.ToString();
                this.tb_cor.Text = dgv_carro.Rows[e.RowIndex].Cells["Cor"].Value.ToString();
                this.tb_marca.Text = dgv_carro.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
                this.tb_km_ultima_troca.Text = dgv_carro.Rows[e.RowIndex].Cells["ultima_troca"].Value.ToString();
                this.tb_cada_troca.Text = dgv_carro.Rows[e.RowIndex].Cells["cada_troca"].Value.ToString();
            }
            else
            {
                ORDER = e.ColumnIndex;
                Carregar_Carros();
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            Carro car = new Carro();
            car.Deletar(tb_placa.Text);

            Carregar_Carros();


            Log log = new Log();
            log.LOG_USUARIO = Global.FUN_CODIGO;
            log.LOG_DATA = DateTime.Now;
            log.LOG_TELA = this.Text;

            log.LOG_DESCRICAO = "Excluiu o carro de placa: " + tb_placa.Text + ", marca: " + tb_marca.Text + ".";
            log.Save();

            if (Configuracoes.Default.Mensagem_Gravar == true)
            {
                MessageBox.Show("Exclusão efetuado com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpar()
        {
            this.tb_placa.Text = "";
            this.tb_modelo.Text = "";
            this.tb_marca.Text = "";
            this.tb_cor.Text = "";
            this.tb_ano.Text = "";
            this.tb_cada_troca.Text = "";
            this.tb_km_ultima_troca.Text = "";
            this.tb_cada_troca_correia.Text = "";
            this.tb_ultima_troca_correia.Text = "";

            Global.CAR_ID = 0;
        }

        private void tb_placa_TextChanged(object sender, EventArgs e)
        {
            string placa = this.tb_placa.Text;
            if (placa == "")
                return;

            Carro car = new Carro();
            car.CAR_PLACA = placa;
            car.Carregar();

            this.tb_placa.Text = car.CAR_PLACA;
            this.tb_modelo.Text = car.CAR_MODELO;
            this.tb_marca.Text = car.CAR_MARCA;
            this.tb_cor.Text = car.CAR_COR;
            this.tb_ano.Text = car.CAR_ANO.ToString();
            this.tb_km_ultima_troca.Text = car.CAR_KM_ULTIMA_TROCA_OLEO.ToString();
            this.tb_cada_troca.Text = car.CAR_KM_CADA_TROCA_OLEO.ToString();
            this.tb_cada_troca_correia.Text = car.CAR_KM_CADA_TROCA_CORREIA.ToString(); ;
            this.tb_ultima_troca_correia.Text = car.CAR_KM_ULTIMA_TROCA_CORREIA.ToString(); ;
        }
    }
}
