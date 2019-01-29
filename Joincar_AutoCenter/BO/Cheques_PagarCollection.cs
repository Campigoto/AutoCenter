using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Cheques_PagarCollection : List<Cheques_Pagar>
     {
        #region Fields
        private int _CHP_CODIGO;
        private int _CHP_CARNE;
        private int _ORDER;
        private string _CHP_NUM_DOC;
        private DateTime _DATA_INICIAL;
        private DateTime _DATA_FINAL;
        private StringBuilder _CONSULTA;
        private Cheques_PagarLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public Cheques_PagarCollection() { }

        public Cheques_PagarCollection(bool isLoad, int ORDER)
        {
            this._typeLoad = Cheques_PagarLoadType.LoadAll;
            this._ORDER = ORDER;
            if (isLoad) this.Carregar();
        }

        public Cheques_PagarCollection(int CODIGO, Cheques_PagarLoadType typeLoad, int ORDER)
        {
            if (typeLoad == Cheques_PagarLoadType.LoadById)
            {
                this._typeLoad = typeLoad;
                this._CHP_CODIGO = CODIGO;
                this._ORDER = ORDER;
                this.Carregar();
            }
            else if (typeLoad == Cheques_PagarLoadType.LoadByCarne)
            {
                this._typeLoad = typeLoad;
                this._CHP_CARNE = CODIGO;
                this._ORDER = ORDER;
                this.Carregar();
            }
        }

        public Cheques_PagarCollection(string CHP_NUM_DOC, int ORDER)
        {
            this._typeLoad  = Cheques_PagarLoadType.LoadByNumDoc;
            this._CHP_NUM_DOC = CHP_NUM_DOC;
            this._ORDER = ORDER;
            this.Carregar();
        }

        public Cheques_PagarCollection(DateTime DATA_INICIAL, DateTime DATA_FINAL, Cheques_PagarLoadType typeLoad, int ORDER)
        {
            if (typeLoad == Cheques_PagarLoadType.LoadByEmissao || typeLoad == Cheques_PagarLoadType.LoadByVencimento || 
                typeLoad == Cheques_PagarLoadType.LoadByEfetivacao)
            {
                this._typeLoad = typeLoad;
                this._DATA_INICIAL = DATA_INICIAL;
                this._DATA_FINAL = DATA_FINAL;
                this._ORDER = ORDER;
                this.Carregar();
            }
        }
        #endregion
     
        #region Methods
        private void Carregar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("SELECT CHP_CODIGO, CHP_CARNE, CHP_ITEM, CHP_BANCO, CHP_AGENCIA, CHP_NUM_DOC, ");
                this._CONSULTA.Append("CHP_CONTA, CHP_EMISSAO, CHP_VENC, CHP_EFETIVACAO, CHP_VALOR, CHP_OBS FROM Cheques_Pagar ");
                switch (this._typeLoad)
                {
                    case Cheques_PagarLoadType.LoadAll:
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case Cheques_PagarLoadType.LoadById:
                        this._CONSULTA.Append("WHERE CHP_CODIGO = @CHP_CODIGO ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@CHP_CODIGO", SqlDbType.VarChar);
                        cmd.Parameters[0].Value = this._CHP_CODIGO;
                        break;
                    case Cheques_PagarLoadType.LoadByCarne:
                        this._CONSULTA.Append("WHERE CHP_CARNE = @CHP_CARNE ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CHP_CARNE", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._CHP_CARNE;
                        break;
                    case Cheques_PagarLoadType.LoadByEmissao:
                        this._CONSULTA.Append("WHERE CAST(FLOOR(CAST(CHP_EMISSAO AS FLOAT)) AS DATETIME) BETWEEN @DATA_INICIAL AND @DATA_FINAL ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@DATA_INICIAL", SqlDbType.DateTime);
                        cmd.Parameters[0].Value = this._DATA_INICIAL;
                        cmd.Parameters.Add("@DATA_FINAL", SqlDbType.DateTime);
                        cmd.Parameters[1].Value = this._DATA_FINAL;
                        break;
                    case Cheques_PagarLoadType.LoadByVencimento:
                        this._CONSULTA.Append("WHERE CAST(FLOOR(CAST(CHP_VENC AS FLOAT)) AS DATETIME) BETWEEN @DATA_INICIAL AND @DATA_FINAL ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@DATA_INICIAL", SqlDbType.DateTime);
                        cmd.Parameters[0].Value = this._DATA_INICIAL;
                        cmd.Parameters.Add("@DATA_FINAL", SqlDbType.DateTime);
                        cmd.Parameters[1].Value = this._DATA_FINAL;
                        break;
                    case Cheques_PagarLoadType.LoadByEfetivacao:
                        this._CONSULTA.Append("WHERE CAST(FLOOR(CAST(CHP_EFETIVACAO AS FLOAT)) AS DATETIME) BETWEEN @DATA_INICIAL AND @DATA_FINAL ");
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

                    this.Add(new Cheques_Pagar(dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value,
                        dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value,
                        dr.IsDBNull(2) ? 0 : dr.GetSqlInt32(2).Value,
                        dr.IsDBNull(3) ? "" : dr.GetSqlString(3).Value,
                        dr.IsDBNull(4) ? "" : dr.GetSqlString(4).Value,
                        dr.IsDBNull(5) ? "" : dr.GetSqlString(5).Value,
                        dr.IsDBNull(6) ? "" : dr.GetSqlString(6).Value,
                        dr.IsDBNull(7) ? DateTime.Parse("01/01/1800") : dr.GetSqlDateTime(7).Value,
                        dr.IsDBNull(8) ? DateTime.Parse("01/01/1800") : dr.GetSqlDateTime(8).Value,
                        dr.IsDBNull(9) ? DateTime.Parse("01/01/1800") : dr.GetSqlDateTime(9).Value,
                        dr.IsDBNull(10) ? 0 : float.Parse(dr.GetSqlDouble(10).Value.ToString()),
                        dr.IsDBNull(11) ? "" : dr.GetSqlString(11).Value));
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

        public void Deletar(int CHP_CARNE)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Cheques_Pagar WHERE CHP_CARNE = @CHP_CARNE ", this.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@CHP_CARNE", SqlDbType.Int);
                cmd.Parameters[0].Value = this._CHP_CARNE;

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

        private string Order()
        {
            string ordenado = "ORDER BY ";

            switch (this._ORDER)
            {
                case 0:
                    ordenado += "CHP_CODIGO ";
                    break;
                case 1:
                    ordenado += "CHP_CARNE ";
                    break;
                case 2:
                    ordenado += "CHP_CONTA ";
                    break;
                case 3:
                    ordenado += "CHP_EMISSAO ";
                    break;
                case 4:
                    ordenado += "CHP_VENC ";
                    break;
                case 5:
                    ordenado += "CHP_VALOR ";
                    break;
                default:
                    ordenado += "CHP_VENC ";
                    break;
            }
            return ordenado;
        }
        #endregion
    }

    public enum Cheques_PagarLoadType
    {
        LoadAll,
        LoadById,
        LoadByCarneItem,
        LoadByCarne,
        LoadByNumDoc,
        LoadByEmissao,
        LoadByVencimento,
        LoadByEfetivacao
    }
}
