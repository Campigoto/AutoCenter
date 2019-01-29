using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Ordem_Servico
    {
        #region Fields
            private int _OS_ID;
            private int _OS_CLIENTE;
            private string _OS_PLACA;
            private DateTime _OS_DATA_ENTRADA;
            private DateTime _OS_DATA_ENTREGA;
            private double _OS_VALOR_TOTAL;
            private string _OS_OBS;
            private int _OS_STATUS;

            private StringBuilder _sb;
            private SqlConnection con = new SqlConnection(Connection.ConnectionString);
            private SqlCommand cmd;
        #endregion

        #region Properties
            public int OS_ID
            {
                get { return _OS_ID; }
                set { _OS_ID = value; }
            }
            public int OS_CLIENTE
            {
                get { return _OS_CLIENTE; }
                set { _OS_CLIENTE = value; }
            }
            public string OS_PLACA
            {
                get { return _OS_PLACA; }
                set { _OS_PLACA = value; }
            }
            public DateTime OS_DATA_ENTRADA
            {
                get { return _OS_DATA_ENTRADA; }
                set { _OS_DATA_ENTRADA = value; }
            }
            public DateTime OS_DATA_ENTREGA
            {
                get { return _OS_DATA_ENTREGA; }
                set { _OS_DATA_ENTREGA = value; }
            }
            public double OS_VALOR_TOTAL {
                get { return _OS_VALOR_TOTAL; }
                set { _OS_VALOR_TOTAL = value; }
            }
            public string OS_OBS
            {
                get { return _OS_OBS; }
                set { _OS_OBS = value; }
            }
            public int OS_STATUS
            {
                get { return _OS_STATUS; }
                set { _OS_STATUS = value; }
            }
        #endregion

        #region Constructors
            public Ordem_Servico()
            { }

            public Ordem_Servico(int OS_ID)
            {
                this._OS_ID = OS_ID;
            }

        #endregion

        #region Methods
            public void load()
            {
                try
                {
                    this._sb = new StringBuilder();
                    _sb.Append(" SELECT OS_ID, OS_CLIENTE,OS_PLACA,OS_DATA_ENTRADA, OS_DATA_ENTREGA, OS_VALOR_TOTAL, OS_OBS, OS_STATUS FROM ORDEM_SERVICO ");

                    if(_OS_ID != null ) this._sb.Append(" WHERE OS_ID = @OS_ID ");

                    this._sb.Append(" ORDER BY OS_ID DESC ");

                    this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                    this.cmd.CommandType = CommandType.Text;

                    if (_OS_ID != null)
                    {
                        this.cmd.Parameters.Add("@OS_ID", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._OS_ID;
                    }

                    this.con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        this._OS_ID = dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value;
                        this._OS_CLIENTE = dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value;
                        this._OS_PLACA = dr.IsDBNull(2) ? "" : dr.GetSqlString(2).Value;
                        this._OS_DATA_ENTRADA = dr.IsDBNull(3) ? DateTime.Today : dr.GetSqlDateTime(3).Value;
                        this._OS_DATA_ENTREGA = dr.IsDBNull(4) ? DateTime.Today : dr.GetSqlDateTime(4).Value;
                        this._OS_VALOR_TOTAL = dr.IsDBNull(5) ? 0 : dr.GetSqlDouble(5).Value;
                        this._OS_OBS = dr.IsDBNull(6) ? "" : dr.GetSqlString(6).Value;
                        this._OS_STATUS = dr.IsDBNull(7) ? -1 : dr.GetSqlInt32(7).Value;
                    }
                    else
                    {
                        this._OS_ID = 0;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (this.con.State == ConnectionState.Open) this.con.Close();
                }
            }

            public void salvar()
            {
                try
                {

                    this._sb = new StringBuilder();
                    if (Global.NUM_OS != 0)
                    {
                        this._sb.Append(" UPDATE ORDEM_SERVICO SET OS_CLIENTE = @OS_CLIENTE , OS_PLACA = @OS_PLACA, OS_DATA_ENTRADA = @OS_DATA_ENTRADA ");
                        this._sb.Append(" ,OS_DATA_ENTREGA = @OS_DATA_ENTREGA, OS_VALOR_TOTAL = @OS_VALOR_TOTAL, OS_OBS = @OS_OBS, OS_STATUS = @OS_STATUS ");
                        this._sb.Append(" WHERE OS_ID = " + Global.NUM_OS + " ");
                    }
                    else
                    { 
                        this._sb.Append(" INSERT INTO ORDEM_SERVICO (OS_CLIENTE,OS_PLACA,OS_DATA_ENTRADA, OS_DATA_ENTREGA, OS_VALOR_TOTAL, OS_OBS, OS_STATUS) ");
                        this._sb.Append(" VALUES (@OS_CLIENTE, @OS_PLACA, @OS_DATA_ENTRADA, @OS_DATA_ENTREGA ,@OS_VALOR_TOTAL ,@OS_OBS ,@OS_STATUS) ");
                        this._sb.Append(" SELECT TOP 1 OS_ID FROM ORDEM_SERVICO ORDER BY OS_ID DESC ");
                    }
                    
                    this.cmd = new SqlCommand(this._sb.ToString(),this.con);
                    this.cmd.CommandType = CommandType.Text;

                    this.cmd.Parameters.Add("@OS_CLIENTE", SqlDbType.Int);
                    this.cmd.Parameters[0].Value = this._OS_CLIENTE;
                    this.cmd.Parameters.Add("@OS_PLACA", SqlDbType.VarChar);
                    this.cmd.Parameters[1].Value = this._OS_PLACA;
                    this.cmd.Parameters.Add("@OS_DATA_ENTRADA", SqlDbType.DateTime);
                    this.cmd.Parameters[2].Value = this._OS_DATA_ENTRADA;
                    this.cmd.Parameters.Add("@OS_DATA_ENTREGA", SqlDbType.DateTime);
                    this.cmd.Parameters[3].Value = this._OS_DATA_ENTREGA;
                    this.cmd.Parameters.Add("@OS_VALOR_TOTAL", SqlDbType.Float);
                    this.cmd.Parameters[4].Value = this._OS_VALOR_TOTAL;
                    this.cmd.Parameters.Add("@OS_OBS", SqlDbType.Text);
                    this.cmd.Parameters[5].Value = this._OS_OBS;
                    this.cmd.Parameters.Add("@OS_STATUS", SqlDbType.Int);
                    this.cmd.Parameters[6].Value = this._OS_STATUS;

                    this.con.Open();
                    SqlDataReader dr = this.cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        this._OS_ID = dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value;
                    }
                    else
                    {
                        if (Global.NUM_OS != 0)
                            this._OS_ID = Global.NUM_OS;
                    }
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

            public void deletar()
            { }
        #endregion
    }
}
