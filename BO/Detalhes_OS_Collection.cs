using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Detalhes_OS_Collection : List<Detalhes_OS>
    {
        #region Fields
        private int OS_ID;
        private StringBuilder _sb = null;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructor

        public Detalhes_OS_Collection() { }
        public Detalhes_OS_Collection(int ID_OS) {
            this.OS_ID = ID_OS;
            this.load();
        }

        #endregion
        #region Methods

        public void load()
        {
            try
            {
                this._sb = new StringBuilder();
                this._sb.Append(@" SELECT DET_OS_ID, 
                                     DET_PRODUTO, DET_QTD, 
                                     DET_VALOR_UNIT, 
                                     DET_VALOR_TOTAL, 
                                     DET_DESCONTO, 
                                     OS_CLIENTE, 
                                     OS_PLACA, 
                                     OS_DATA_ENTRADA, 
                                     OS_DATA_ENTREGA, 
                                     OS_OBS, 
                                     OS_STATUS, 
                                     OS_KM_ATUAL,
                                     OBSERVACAO 
                                   FROM DETALHE_OS 
                                   INNER JOIN ORDEM_SERVICO ON DET_OS_ID = OS_ID 
                                   WHERE OS_ID = @OS_ID ");
                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.Parameters.Add("@OS_ID", SqlDbType.Int);
                this.cmd.Parameters[0].Value = this.OS_ID;
                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                        
                    this.Add(new Detalhes_OS(
                                                dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value,
                                                dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value,
                                                dr.IsDBNull(2) ? 0 : dr.GetSqlInt32(2).Value,
                                                dr.IsDBNull(3) ? 0 : dr.GetSqlDouble(3).Value,
                                                dr.IsDBNull(4) ? 0 : dr.GetSqlDouble(4).Value,
                                                dr.IsDBNull(5) ? 0 : dr.GetSqlDouble(5).Value,
                                                dr.IsDBNull(6) ? 0 : dr.GetSqlInt32(6).Value,
                                                dr.IsDBNull(7) ? "" : dr.GetSqlString(7).Value,
                                                dr.IsDBNull(8) ? new DateTime(1900,01,01) : dr.GetSqlDateTime(8).Value,
                                                dr.IsDBNull(9) ? new DateTime(1900,01,01) : dr.GetSqlDateTime(9).Value,
                                                dr.IsDBNull(10) ? "" : dr.GetSqlString(10).Value,
                                                dr.IsDBNull(11) ? 0 : dr.GetSqlInt32(11).Value,
                                                dr.IsDBNull(12) ? 0 : dr.GetSqlInt64(12).Value,
                                                dr.IsDBNull(13) ? "" : dr.GetSqlString(13).Value
                                            ));
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

        #endregion
    }
}
