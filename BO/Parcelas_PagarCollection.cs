using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Parcelas_PagarCollection : List<Parcelas_Pagar>
     {
        #region Fields
        private int _PCA_CARNE = 0;
        private int _TIPO;
        private DateTime _DATA_INICIAL;
        private DateTime _DATA_FINAL;
        private int _CAP_FORNECEDOR;
        private StringBuilder _CONSULTA;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public Parcelas_PagarCollection() { }

        public Parcelas_PagarCollection(int PCA_CARNE)
        {
            this._PCA_CARNE = PCA_CARNE;
            this.Carregar();
        }

        public Parcelas_PagarCollection(int TIPO, DateTime DATA_INICIAL, DateTime DATA_FINAL, int CAP_FORNECEDOR)
        {
            this._TIPO = TIPO;
            this._DATA_INICIAL = DATA_INICIAL;
            this._DATA_FINAL = DATA_FINAL;
            this._CAP_FORNECEDOR = CAP_FORNECEDOR;
            this.Carregar();
        }
        #endregion
     
        #region Methods
        private void Carregar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("SELECT PCA_CARNE, PCA_ITEM, PCA_TIPO, PCA_NUM_DOC, PCA_OBS, PCA_VALOR, ");
                this._CONSULTA.Append("PCA_VALOR_PAGO, PCA_DATA_PAGTO, PCA_VENC, PCA_ITEM_NOVA_PARC, PCA_ACRESCIMO, ");
                this._CONSULTA.Append("PCA_DESCONTO, COALESCE(FOR_NOME, '') FROM Parcelas_Pagar ");
                this._CONSULTA.Append("LEFT JOIN Contas_Pagar ON PCA_CARNE = CAP_CODIGO ");
                this._CONSULTA.Append("LEFT JOIN Fornecedor ON CAP_FORNECEDOR = FOR_CODIGO ");
                if (this._PCA_CARNE > 0)
                {
                    this._CONSULTA.Append("WHERE PCA_CARNE = @PCA_CARNE ORDER BY PCA_ITEM ");
                    this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@PCA_CARNE", SqlDbType.Int);
                    cmd.Parameters[0].Value = this._PCA_CARNE;
                }
                else
                {
                    if (this._TIPO == 0)
                    {
                        this._CONSULTA.Append("WHERE (PCA_VALOR_PAGO > 0) ");
                        this._CONSULTA.Append("AND (CAST(FLOOR(CAST(PCA_DATA_PAGTO AS FLOAT)) AS DATETIME) BETWEEN @DATA_INICIAL AND @DATA_FINAL) ");
                    }
                    else
                    {
                        this._CONSULTA.Append("WHERE (PCA_VALOR_PAGO = 0) ");
                        this._CONSULTA.Append("AND (CAST(FLOOR(CAST(PCA_VENC AS FLOAT)) AS DATETIME) BETWEEN @DATA_INICIAL AND @DATA_FINAL) ");
                    }
                    this._CONSULTA.Append("AND (CAP_FORNECEDOR = @CAP_FORNECEDOR OR @CAP_FORNECEDOR = 0) ");
                    this._CONSULTA.Append("ORDER BY PCA_VENC, PCA_CARNE, PCA_ITEM ");
                    this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@CAP_FORNECEDOR", SqlDbType.Int);
                    cmd.Parameters[0].Value = this._CAP_FORNECEDOR;
                    cmd.Parameters.Add("@DATA_INICIAL", SqlDbType.DateTime);
                    cmd.Parameters[1].Value = this._DATA_INICIAL;
                    cmd.Parameters.Add("@DATA_FINAL", SqlDbType.DateTime);
                    cmd.Parameters[2].Value = this._DATA_FINAL;
                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();                     
                while (dr.Read())                                           
                {

                    this.Add(new Parcelas_Pagar(dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value,
                        dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value,
                        dr.IsDBNull(2) ? 0 : dr.GetSqlInt32(2).Value,
                        dr.IsDBNull(3) ? "" : dr.GetSqlString(3).Value,
                        dr.IsDBNull(4) ? "" : dr.GetSqlString(4).Value,
                        dr.IsDBNull(5) ? 0 : float.Parse(dr.GetSqlDouble(5).Value.ToString()),
                        dr.IsDBNull(6) ? 0 : float.Parse(dr.GetSqlDouble(6).Value.ToString()),
                        dr.IsDBNull(7) ? DateTime.Parse("01/01/1800") : dr.GetSqlDateTime(7).Value,
                        dr.IsDBNull(8) ? DateTime.Parse("01/01/1800") : dr.GetSqlDateTime(8).Value,
                        dr.IsDBNull(9) ? 0 : dr.GetSqlInt32(9).Value,
                        dr.IsDBNull(10) ? 0 : float.Parse(dr.GetSqlDouble(10).Value.ToString()),
                        dr.IsDBNull(11) ? 0 : float.Parse(dr.GetSqlDouble(11).Value.ToString()),
                        dr.IsDBNull(12) ? "" : dr.GetSqlString(12).Value));
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

        public void Deletar(int PCA_CARNE)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Parcelas_Pagar WHERE PCA_CARNE = @PCA_CARNE ", this.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@PCA_CARNE", SqlDbType.Int);
                cmd.Parameters[0].Value = PCA_CARNE;

                this.con.Open();
                cmd.ExecuteNonQuery();
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
        #endregion
    }
}
