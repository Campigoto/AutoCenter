using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Contas_PagarCollection : List<Contas_Pagar>
     {
        #region Fields
        private int _CAP_CODIGO;
        private int _ORDER;
        private int _CAP_COMPRA;
        private string _FOR_NOME;
        private DateTime _DATA_INICIAL;
        private DateTime _DATA_FINAL;
        private StringBuilder _CONSULTA;
        private Contas_PagarLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public Contas_PagarCollection() { }

        public Contas_PagarCollection(bool isLoad, int ORDER)
        {
            this._typeLoad = Contas_PagarLoadType.LoadAll;
            this._ORDER = ORDER;
            if (isLoad) this.Carregar();
        }

        public Contas_PagarCollection(int CODIGO, Contas_PagarLoadType typeLoad, int ORDER)
        {
            if (typeLoad == Contas_PagarLoadType.LoadById)
            {
                this._typeLoad = typeLoad;
                this._CAP_CODIGO = CODIGO;
                this._ORDER = ORDER;
                this.Carregar();
            }
            else if (typeLoad == Contas_PagarLoadType.LoadByCompra)
            {
                this._typeLoad = typeLoad;
                this._CAP_COMPRA = CODIGO;
                this._ORDER = ORDER;
                this.Carregar();
            }
        }

        public Contas_PagarCollection(string FOR_NOME, int ORDER)
        {
            this._typeLoad = Contas_PagarLoadType.LoadByFornecedor;
            this._FOR_NOME = FOR_NOME;
            this._ORDER = ORDER;
            this.Carregar();
        }

        public Contas_PagarCollection(DateTime DATA_INICIAL, DateTime DATA_FINAL, int ORDER)
        {
            this._typeLoad = Contas_PagarLoadType.LoadByData;
            this._DATA_INICIAL = DATA_INICIAL;
            this._DATA_FINAL = DATA_FINAL;
            this._ORDER = ORDER;
            this.Carregar();
        }
        #endregion
     
        #region Methods
        private void Carregar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("SELECT CAP_CODIGO, CAP_FORNECEDOR, CAP_COMPRA, CAP_TOTAL, CAP_CADASTRO, CAP_OBS, CAP_LANCAMENTO, COALESCE(FOR_NOME, '') ");
                this._CONSULTA.Append("FROM Contas_Pagar LEFT JOIN Fornecedor ON CAP_FORNECEDOR = FOR_CODIGO ");

                switch (this._typeLoad)
                {
                    case Contas_PagarLoadType.LoadAll:
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case Contas_PagarLoadType.LoadById:
                        this._CONSULTA.Append("WHERE CAP_CODIGO = @CAP_CODIGO ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@CAP_CODIGO", SqlDbType.Int);
                        cmd.Parameters[0].Value = this._CAP_CODIGO;
                        break;
                    case Contas_PagarLoadType.LoadByCompra:
                        this._CONSULTA.Append("WHERE CAP_COMPRA = @CAP_COMPRA ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CAP_COMPRA", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._CAP_COMPRA;
                        break;
                    case Contas_PagarLoadType.LoadByFornecedor:
                        this._CONSULTA.Append("WHERE (FOR_NOME LIKE @FOR_NOME + '%') ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@FOR_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._FOR_NOME;
                        break;
                    case Contas_PagarLoadType.LoadByData:
                        this._CONSULTA.Append("WHERE CAST(FLOOR(CAST(CAP_CADASTRO AS FLOAT)) AS DATETIME) BETWEEN @DATA_INICIAL AND @DATA_FINAL ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@DATA_INICIAL", SqlDbType.DateTime);
                        cmd.Parameters[0].Value = this._DATA_INICIAL;
                        cmd.Parameters.Add("@DATA_FINAL", SqlDbType.DateTime);
                        cmd.Parameters[1].Value = this._DATA_FINAL;
                        break;
                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();                     
                while (dr.Read())                                           
                {

                    this.Add(new Contas_Pagar(dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value,
                        dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value,
                        dr.IsDBNull(2) ? 0 : dr.GetSqlInt32(2).Value,
                        dr.IsDBNull(3) ? 0 : float.Parse(dr.GetSqlDouble(3).Value.ToString()),
                        dr.IsDBNull(4) ? DateTime.Parse("01/01/1800") : dr.GetSqlDateTime(4).Value,
                        dr.IsDBNull(5) ? "" : dr.GetSqlString(5).Value,
                        dr.IsDBNull(6) ? 0 : dr.GetSqlInt32(6).Value,
                        dr.IsDBNull(6) ? "" : dr.GetSqlString(7).Value));
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
            string ordenado = "ORDER BY ";

            switch (this._ORDER)
            {
                case 0:
                    ordenado += "CAP_CODIGO ";
                    break;
                case 1:
                    ordenado += "CAP_COMPRA ";
                    break;
                case 2:
                    ordenado += "FOR_NOME ";
                    break;
                case 3:
                    ordenado += "CAP_TOTAL ";
                    break;
                case 4:
                    ordenado += "CAP_CADASTRO ";
                    break;
                default:
                    ordenado += "FOR_NOME ";
                    break;
            }
            return ordenado;
        }
        #endregion
    }

    public enum Contas_PagarLoadType
    {
        LoadAll,
        LoadById,
        LoadByCompra,
        LoadByFornecedor,
        LoadByData
    }
}
