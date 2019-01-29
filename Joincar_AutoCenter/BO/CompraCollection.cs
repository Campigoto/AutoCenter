using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class CompraCollection : List<Compra>
     {
        #region Fields
        private int _COM_CODIGO;
        private int _COM_NF;
        private int _ORDER;
        private string _FOR_NOME;
        private DateTime _DATA_INICIAL;
        private DateTime _DATA_FINAL;
        private StringBuilder _CONSULTA;
        private CompraLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public CompraCollection() { }

        public CompraCollection(bool isLoad, int ORDER)
        {
            this._typeLoad = CompraLoadType.LoadAll;
            this._ORDER = ORDER;
            if (isLoad) this.Carregar();
        }

        public CompraCollection(int CODIGO, CompraLoadType typeLoad, int ORDER)
        {
            if (typeLoad == CompraLoadType.LoadById)
            {
                this._typeLoad = typeLoad;
                this._COM_CODIGO = CODIGO;
                this._ORDER = ORDER;
                this.Carregar();
            }
            else if (typeLoad == CompraLoadType.LoadByNF)
            {
                this._typeLoad = typeLoad;
                this._COM_NF = CODIGO;
                this._ORDER = ORDER;
                this.Carregar();
            }
        }

        public CompraCollection(string FOR_NOME, int ORDER)
        {
            this._typeLoad = CompraLoadType.LoadByFornecedor;
            this._FOR_NOME = FOR_NOME;
            this._ORDER = ORDER;
            this.Carregar();
        }

        public CompraCollection(DateTime DATA_INICIAL, DateTime DATA_FINAL, int ORDER)
        {
            this._typeLoad = CompraLoadType.LoadByData;
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
                this._CONSULTA.Append("SELECT COM_CODIGO, COM_NF, COM_FORNECEDOR, COM_TIPO_PAGTO, COM_CANCELADO, COM_OUT_DESPESAS, ");
                this._CONSULTA.Append("COM_FRETE, COM_ACRESCIMO, COM_DESCONTO, COM_TOTAL, COM_DATA, COM_ALTERACAO, COM_DATA_CANCELADO, ");
                this._CONSULTA.Append("COM_OBS, COM_LANCAMENTO, COALESCE(FOR_NOME, '') FROM Compra LEFT JOIN Fornecedor ON COM_FORNECEDOR = FOR_CODIGO ");
                switch (this._typeLoad)
                {
                    case CompraLoadType.LoadAll:
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case CompraLoadType.LoadById:
                        this._CONSULTA.Append("WHERE COM_CODIGO = @COM_CODIGO ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@COM_CODIGO", SqlDbType.Int);
                        cmd.Parameters[0].Value = this._COM_CODIGO;
                        break;
                    case CompraLoadType.LoadByNF:
                        this._CONSULTA.Append("WHERE COM_NF = @COM_NF ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@COM_NF", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._COM_NF;
                        break;
                    case CompraLoadType.LoadByFornecedor:
                        this._CONSULTA.Append("WHERE (FOR_NOME LIKE @FOR_NOME + '%') ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@FOR_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._FOR_NOME;
                        break;
                    case CompraLoadType.LoadByData:
                        this._CONSULTA.Append("WHERE (CAST(FLOOR(CAST(COM_DATA AS FLOAT)) AS DATETIME) BETWEEN @DATA_INICIAL AND @DATA_FINAL) ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
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

                    this.Add(new Compra(dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value,
                        dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value,
                        dr.IsDBNull(2) ? 0 : dr.GetSqlInt32(2).Value,
                        dr.IsDBNull(3) ? 0 : dr.GetSqlInt32(3).Value,
                        dr.IsDBNull(4) ? 0 : dr.GetSqlInt32(4).Value,
                        dr.IsDBNull(5) ? 0 : float.Parse(dr.GetSqlDouble(5).Value.ToString()),
                        dr.IsDBNull(6) ? 0 : float.Parse(dr.GetSqlDouble(6).Value.ToString()),
                        dr.IsDBNull(7) ? 0 : float.Parse(dr.GetSqlDouble(7).Value.ToString()),
                        dr.IsDBNull(8) ? 0 : float.Parse(dr.GetSqlDouble(8).Value.ToString()),
                        dr.IsDBNull(9) ? 0 : float.Parse(dr.GetSqlDouble(9).Value.ToString()),
                        dr.IsDBNull(10) ? DateTime.Parse("01/01/1800") : dr.GetSqlDateTime(10).Value,
                        dr.IsDBNull(11) ? DateTime.Parse("01/01/1800") : dr.GetSqlDateTime(11).Value,
                        dr.IsDBNull(12) ? DateTime.Parse("01/01/1800") : dr.GetSqlDateTime(12).Value,
                        dr.IsDBNull(13) ? "" : dr.GetSqlString(13).Value,
                        dr.IsDBNull(14) ? 0 : dr.GetSqlInt32(14).Value,
                        dr.IsDBNull(15) ? "" : dr.GetSqlString(15).Value));
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
                    ordenado += "COM_CODIGO ";
                    break;
                case 1:
                    ordenado += "COM_NF ";
                    break;
                case 2:
                    ordenado += "FOR_NOME ";
                    break;
                case 3:
                    ordenado += "COM_TOTAL ";
                    break;
                case 4:
                    ordenado += "COM_DATA ";
                    break;
                default:
                    ordenado += "FOR_NOME ";
                    break;
            }
            return ordenado;
        }
        #endregion
    }

    public enum CompraLoadType
    {
        LoadAll,
        LoadById,
        LoadByNF,
        LoadByFornecedor,
        LoadByData
    }
}
