using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Historico_Estoque_PrecoCollection : List<Historico_Estoque_Preco>
     {
        #region Fields
        private int _HEP_PRODUTO;
        private StringBuilder _CONSULTA;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public Historico_Estoque_PrecoCollection() { }

        public Historico_Estoque_PrecoCollection(int HEP_PRODUTO)
        {
            this._HEP_PRODUTO = HEP_PRODUTO;
            this.Carregar();
        }
        #endregion
     
        #region Methods
        private void Carregar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("SELECT HEP_CODIGO, HEP_PRODUTO, HEP_COMPRA, HEP_USUARIO, HEP_ESTOQUE_ANTERIOR, ");
                this._CONSULTA.Append("HEP_ESTOQUE_ATUAL, HEP_QTDE, HEP_PRECO_UNITARIO, HEP_PRECO_TOTAL, HEP_DATA, COALESCE(FUN_NOME, '') ");
                this._CONSULTA.Append("FROM Historico_Estoque_Preco LEFT JOIN Funcionario ON HEP_USUARIO = FUN_CODIGO ");
                this._CONSULTA.Append("WHERE HEP_PRODUTO = @HEP_PRODUTO ");
                this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@HEP_PRODUTO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = this._HEP_PRODUTO;

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();                     
                while (dr.Read())                                           
                {

                    this.Add(new Historico_Estoque_Preco(dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value,
                        dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value,
                        dr.IsDBNull(2) ? 0 : dr.GetSqlInt32(2).Value,
                        dr.IsDBNull(3) ? 0 : dr.GetSqlInt32(3).Value,
                        dr.IsDBNull(4) ? 0 : float.Parse(dr.GetSqlDouble(4).Value.ToString()),
                        dr.IsDBNull(5) ? 0 : float.Parse(dr.GetSqlDouble(5).Value.ToString()),
                        dr.IsDBNull(6) ? 0 : float.Parse(dr.GetSqlDouble(6).Value.ToString()),
                        dr.IsDBNull(7) ? 0 : float.Parse(dr.GetSqlDouble(7).Value.ToString()),
                        dr.IsDBNull(8) ? 0 : float.Parse(dr.GetSqlDouble(8).Value.ToString()),
                        dr.IsDBNull(9) ? DateTime.Parse("01/01/1800") : dr.GetSqlDateTime(9).Value,
                        dr.IsDBNull(10) ? "" : dr.GetSqlString(10).Value));
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
        #endregion
    }
}
