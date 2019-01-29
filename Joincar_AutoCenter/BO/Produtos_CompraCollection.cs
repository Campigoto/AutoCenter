using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Produtos_CompraCollection : List<Produtos_Compra>
     {
        #region Fields
        private int _PC_COMPRA;
        private StringBuilder _CONSULTA;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public Produtos_CompraCollection() { }

        public Produtos_CompraCollection(int PC_COMPRA)
        {
            this._PC_COMPRA = PC_COMPRA;
            this.Carregar();
        }
        #endregion
     
        #region Methods
        private void Carregar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("SELECT PC_COMPRA, PC_ITEM, PC_PRODUTO, PC_UNIDADE, PC_QTDE, PC_PRECO_COMPRA, PC_TOTAL, ");
                this._CONSULTA.Append("COALESCE(PRO_NOME, '') FROM Produtos_Compra LEFT JOIN Produto ON PC_PRODUTO = PRO_CODIGO ");
                this._CONSULTA.Append("WHERE PC_COMPRA = @PC_COMPRA ORDER BY PC_ITEM ");
                this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@PC_COMPRA", SqlDbType.Int);
                cmd.Parameters[0].Value = this._PC_COMPRA;

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();                     
                while (dr.Read())                                           
                {

                    this.Add(new Produtos_Compra(dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value,
                        dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value,
                        dr.IsDBNull(2) ? 0 : dr.GetSqlInt32(2).Value,
                        dr.IsDBNull(3) ? "" : dr.GetSqlString(3).Value,
                        dr.IsDBNull(4) ? 0 : float.Parse(dr.GetSqlDouble(4).Value.ToString()),
                        dr.IsDBNull(5) ? 0 : float.Parse(dr.GetSqlDouble(5).Value.ToString()),
                        dr.IsDBNull(6) ? 0 : float.Parse(dr.GetSqlDouble(6).Value.ToString()),
                        dr.IsDBNull(7) ? "" : dr.GetSqlString(7).Value));
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

        public void Deletar(int PC_COMPRA)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Produtos_Compra WHERE PC_COMPRA = @PC_COMPRA ", this.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@PC_COMPRA", SqlDbType.Int);
                cmd.Parameters[0].Value = PC_COMPRA;

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
