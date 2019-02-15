using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Detalhes_OS
    {
        #region Fields
            private int _DET_OS_ID;
            private int _DET_PRODUTO;
            private int _DET_QTD;
            private int _DET_CLIENTE;
            private double _DET_VALOR_UNIT;
            private double _DET_VALOR_TOTAL;
            private double _DET_DESCONTO;
            private string _DET_PLACA;
            private DateTime _DET_DATA_ENTRADA;
            private DateTime _DET_DATA_ENTREGA;
            private string _DET_OBS;
            private int _DET_STATUS;
            private long _DET_KM_ATUAL;
            private string _OBSERVACAO;

            private StringBuilder _sb;
            private SqlConnection con = new SqlConnection(Connection.ConnectionString);
            private SqlCommand cmd;
        #endregion

        #region Properties

            public int DET_OS_ID
        {
            get { return _DET_OS_ID; }
            set { _DET_OS_ID = value; }
        }
            public int DET_PRODUTO
        {
            get { return _DET_PRODUTO; }
            set { _DET_PRODUTO = value; }
        }
            public int DET_QTD
        {
            get { return _DET_QTD; }
            set { _DET_QTD = value; }
        }
            public int DET_CLIENTE
            {
                get { return _DET_CLIENTE; }
                set { _DET_CLIENTE = value; }
            }
            public double DET_VALOR_UNIT
        {
            get { return _DET_VALOR_UNIT; }
            set { _DET_VALOR_UNIT = value; }
        }
            public double DET_VALOR_TOTAL
        {
            get { return _DET_VALOR_TOTAL; }
            set { _DET_VALOR_TOTAL = value; }
        }
            public double DET_DESCONTO
            {
                   get { return _DET_DESCONTO; }
                   set { _DET_DESCONTO = value; }
            }
            public string DET_PLACA
            {
                get { return _DET_PLACA; }
                set { _DET_PLACA = value; }
            }

            public DateTime DET_DATA_ENTRADA
            {
                get { return _DET_DATA_ENTRADA; }
                set { _DET_DATA_ENTRADA = value; }
            }
            public DateTime DET_DATA_ENTREGA
            {
                get { return _DET_DATA_ENTREGA; }
                set { _DET_DATA_ENTREGA = value; }
            }
            public string DET_OBS
            {
                get { return _DET_OBS; }
                set { _DET_OBS = value; }
            }
            public int DET_STATUS
            {
                get { return _DET_STATUS; }
                set { _DET_STATUS = value; }
            }

            public long DET_KM_ATUAL
            {
                get { return _DET_KM_ATUAL; }
                set { _DET_KM_ATUAL = value; }
            }

            public string OBSERVACAO
            {
                get { return _OBSERVACAO; }
                set { _OBSERVACAO = value; }
            }

        #endregion

        #region Constructors
            public Detalhes_OS() { }

            public Detalhes_OS(int det_os_id,
                               int det_produto,
                               int det_qtd,
                               double det_valor_unit,
                               double det_valor_total,
                               double det_desconto,
                               int det_cliente,
                               string det_placa,
                               DateTime det_data_entrada,
                               DateTime det_data_entrega,
                               string obs,
                               int status,
                               long km_atual,
                               string observacao) 
                              {
                                  this._DET_OS_ID = det_os_id;
                                  this._DET_PRODUTO = det_produto;
                                  this._DET_QTD = det_qtd;
                                  this._DET_VALOR_UNIT = det_valor_unit;
                                  this._DET_VALOR_TOTAL = det_valor_total;
                                  this._DET_DESCONTO = det_desconto;
                                  this._DET_CLIENTE = det_cliente;
                                  this._DET_PLACA = det_placa;
                                  this._DET_DATA_ENTRADA = det_data_entrada;
                                  this._DET_DATA_ENTREGA = det_data_entrega;
                                  this._DET_OBS = obs;
                                  this._DET_STATUS = status;
                                  this._DET_KM_ATUAL = km_atual;
                                  this._OBSERVACAO = observacao;
                              }

        #endregion

        #region Methods
        
            public void save()
            {
                try
                {
                    this._sb = new StringBuilder();
                    this._sb.Append(" INSERT INTO DETALHE_OS (DET_OS_ID, DET_PRODUTO, DET_QTD, DET_VALOR_UNIT, DET_VALOR_TOTAL, DET_DESCONTO, OBSERVACAO) ");
                    this._sb.Append(" VALUES (@DET_OS_ID, @DET_PRODUTO, @DET_QTD, @DET_VALOR_UNIT, @DET_VALOR_TOTAL, @DET_DESCONTO, @OBSERVACAO) ");
                    this.cmd = new SqlCommand(this._sb.ToString(), this.con);

                    // OS_ID
                    this.cmd.Parameters.Add("@DET_OS_ID",SqlDbType.Int);
                    this.cmd.Parameters[0].Value = this._DET_OS_ID;

                    // DET_PRODUTO
                    this.cmd.Parameters.Add("@DET_PRODUTO", SqlDbType.Int);
                    this.cmd.Parameters[1].Value = this._DET_PRODUTO;

                    // DET_QTD
                    this.cmd.Parameters.Add("@DET_QTD", SqlDbType.Int);
                    this.cmd.Parameters[2].Value = this._DET_QTD;

                    // DET_VALOR_UNIT
                    this.cmd.Parameters.Add("@DET_VALOR_UNIT", SqlDbType.Float);
                    this.cmd.Parameters[3].Value = this._DET_VALOR_UNIT;

                    // DET_VALOR_TOTAL
                    this.cmd.Parameters.Add("@DET_VALOR_TOTAL", SqlDbType.Float);
                    this.cmd.Parameters[4].Value = this._DET_VALOR_TOTAL;

                    //DET_DESCONTO
                    this.cmd.Parameters.Add("@DET_DESCONTO", SqlDbType.Float);
                    this.cmd.Parameters[5].Value = this._DET_DESCONTO;

                    this.cmd.Parameters.Add("@OBSERVACAO", SqlDbType.Text);
                    this.cmd.Parameters[6].Value = this._OBSERVACAO;

                    this.con.Open();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (this.con.State == System.Data.ConnectionState.Open) this.con.Close();
                }
            }
            public void delete()
            {
                this._sb = new StringBuilder();
                this._sb.Append(" DELETE DETALHE_OS WHERE DET_OS_ID = " + Global.NUM_OS);
                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.con.Open();
                cmd.ExecuteNonQuery();

                if (this.con.State == System.Data.ConnectionState.Open) this.con.Close();
            }

            public int BaixaEstoque(string query)
            {
                int executou = 0;
                try
                {
                    this._sb = new StringBuilder();
                    this._sb.Append(query);

                    SqlCommand cmd = new SqlCommand(this._sb.ToString(), this.con);

                    this.con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    executou = int.Parse(reader["Aviso"].ToString());

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (this.con.State == ConnectionState.Open) this.con.Close();
                }
                return executou;
            }
        #endregion
    }
}
