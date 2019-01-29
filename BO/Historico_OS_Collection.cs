using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Historico_OS_Collection : List<Historico_OS>
    {

        #region Fields
        private int _ORDER;
        private int _HIST_ID_OS;
        private int _HIST_CLIENTE;
        private string _HIST_PLACA;
        private StringBuilder _sb;
        private LoadHistOs _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public Historico_OS_Collection(bool isLoad, int ORDER)
        {
            this._ORDER = ORDER;
            if (isLoad) this.load();
        }

        public Historico_OS_Collection(string hist_placa, LoadHistOs type)
        {
            this._HIST_PLACA = hist_placa;
            this._typeLoad = type;
            this.load();
        }


        #endregion

        #region Methods
        private void load()
        {
            try
            {
                this._sb = new StringBuilder();

                this._sb.Append(" SELECT HIST_ID_OS, HIST_CLIENTE, HIST_PLACA , OS_DATA_ENTRADA, OS_DATA_ENTREGA FROM HISTORICO INNER JOIN ORDEM_SERVICO ON HIST_ID_OS = OS_ID ");
                switch (this._typeLoad)
                {

                    case LoadHistOs.LoadAll:
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case LoadHistOs.LoadByCliente:
                        this._sb.Append(" WHERE HIST_CLIENTE = @HIST_CLIENTE ");
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;

                        this.cmd.Parameters.Add("@HIST_CLIENTE", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._HIST_CLIENTE;
                        this._sb.Append(Order());
                        break;
                    case LoadHistOs.LoadById:
                        this._sb.Append(" WHERE HIST_ID_OS = @HIST_ID_OS ");
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;

                        this.cmd.Parameters.Add("@HIST_ID_OS", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._HIST_ID_OS;
                        this._sb.Append(Order());
                        break;
                    case LoadHistOs.LoadByPlaca:
                        this._sb.Append(" WHERE HIST_PLACA = @HIST_PLACA ");
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;

                        this.cmd.Parameters.Add("@HIST_PLACA", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._HIST_PLACA;
                        this._sb.Append(Order());
                        
                        break;
                }

                this.con.Open();                                                                                      
                SqlDataReader dr = cmd.ExecuteReader();                                                               
                while (dr.Read())                                                                                     
                {                                                                                                         
                    this.Add(new Historico_OS(    
                                                dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value,   // HIST_ID_OS                                
                                                dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value, // HIST_CLIENTE                           
                                                dr.IsDBNull(2) ? "" : dr.GetSqlString(2).Value, // HIST_PLACA 
                                                dr.IsDBNull(3) ? DateTime.Today : dr.GetSqlDateTime(3).Value, //DATA_ENTRADA
                                                dr.IsDBNull(4) ? new DateTime(1900,01,01) : dr.GetSqlDateTime(4).Value
                                                ));
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

        private string Order()
        {
            string ordenado = " ORDER BY ";
            switch (this._ORDER)
            {
                case 0:
                    ordenado += "HIST_ID_OS ";
                    break;
                case 1:
                    ordenado += "HIST_CLIENTE ";
                    break;
                default:
                    ordenado += "HIST_PLACA ";
                    break;
            }

            return ordenado;
        }
        #endregion
    }

    public enum LoadHistOs
    {
        LoadAll,
        LoadById,
        LoadByPlaca,
        LoadByCliente
    }
}
