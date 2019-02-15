using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Historico_OS
    {
        #region fields
        private int _HIST_ID_OS;
        private int _HIST_CLIENTE;
        private string _HIST_PLACA;
        private DateTime _DATA_ENTRADA;
        private DateTime _DATA_ENTREGA;
        private long _OS_KM_ATUAL;

        private StringBuilder _sb;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        #endregion

        #region properties
        public int HIST_ID_OS
        {
            get { return _HIST_ID_OS; }
            set { _HIST_ID_OS = value; }
        }
        public int HIST_CLIENTE
        {
            get { return _HIST_CLIENTE; }
            set { _HIST_CLIENTE = value; }  
        }

        private Cliente cli;
        public string NOME_CLIENTE
        {
            get { 
                    cli = new Cliente(this._HIST_CLIENTE);
                    return cli.CLI_NOME;
                }
        }
        public string HIST_PLACA
        {
            get { return _HIST_PLACA; }
            set { _HIST_PLACA = value; } 
        }

        public DateTime DATA_ENTRADA { get{ return _DATA_ENTRADA;} set{ _DATA_ENTRADA = value;} }
        public DateTime DATA_ENTREGA { get{ return _DATA_ENTREGA;} set{ _DATA_ENTREGA = value;} }

        public long OS_KM_ATUAL
        {
            get { return _OS_KM_ATUAL; }
            set { _OS_KM_ATUAL = value; } 
        }

        #endregion

        #region Constructores
        public Historico_OS()
        { }

        public Historico_OS(int os_id)
        {
            this._HIST_ID_OS = os_id;
        }

        public Historico_OS(int hist_id_os, int hist_cliente, string hist_placa, DateTime entrada, DateTime entrega, long OS_KM_ATUAL)
        {
            this._HIST_ID_OS = hist_id_os;
            this._HIST_CLIENTE = hist_cliente;
            this._HIST_PLACA = hist_placa;
            this._DATA_ENTRADA = entrada;
            this._DATA_ENTREGA = entrega;
            this._OS_KM_ATUAL = OS_KM_ATUAL;
        }
        #endregion

        #region Methods
        public void Carregar()
        {
            try
            {
                this._sb = new StringBuilder();
                this._sb.Append(" SELECT HIST_ID_OS, HIST_CLIENTE, HIST_PLACA FROM HISTORICO ");
                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@HIST_ID_OS", SqlDbType.Int);
                this.cmd.Parameters[0].Value = this._HIST_ID_OS;

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    this._HIST_ID_OS = dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value;
                    this._HIST_CLIENTE = dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value;
                    this._HIST_PLACA = dr.IsDBNull(2) ? "" : dr.GetSqlString(2).Value;
                }
                else
                {
                    this._HIST_ID_OS = 0;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Salvar()
        {
            try
            {
                this._sb = new StringBuilder();

                if(Global.NUM_OS != 0)
                    this._sb.Append(" UPDATE HISTORICO SET HIST_ID_OS = @HIST_ID_OS, HIST_CLIENTE = @HIST_CLIENTE, HIST_PLACA = @HIST_PLACA WHERE HIST_ID_OS = " + Global.NUM_OS);
                else
                    this._sb.Append(" INSERT INTO HISTORICO (HIST_ID_OS, HIST_CLIENTE, HIST_PLACA) VALUES (@HIST_ID_OS,@HIST_CLIENTE,@HIST_PLACA)");
                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@HIST_ID_OS", SqlDbType.Int);
                this.cmd.Parameters[0].Value = this._HIST_ID_OS;
                this.cmd.Parameters.Add("@HIST_CLIENTE", SqlDbType.Int);
                this.cmd.Parameters[1].Value = this._HIST_CLIENTE;
                this.cmd.Parameters.Add("@HIST_PLACA", SqlDbType.VarChar);
                this.cmd.Parameters[2].Value = this._HIST_PLACA;

                this.con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }
        #endregion

        
    }
}
