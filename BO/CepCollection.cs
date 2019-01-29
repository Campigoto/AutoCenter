using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class CepCollection : List<Cep>
    {
        #region Fields
        private int _CEP_ID;
        private int _ORDER;
        private string _CEP_LOCAL;
        private string _NOME_RUA;
        private string _COD_CIDADE;
        private string _NOME_BAIRRO;
        private string _FILTRO;
        private StringBuilder _sb;
        private CepLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public CepCollection() { }

        public CepCollection(bool isLoad, int ORDER)
        {
            this._typeLoad = CepLoadType.LoadAll;
            this._ORDER = ORDER;
            if (isLoad) this.Load();
        }

        public CepCollection(int CLID_ID, int ORDER)
        {
            this._typeLoad = CepLoadType.LoadById;
            this._CEP_ID = CLID_ID;
            this._ORDER = ORDER;                            
            this.Load();                                                                       
        }

        public CepCollection(string CEP_LOCAL, int ORDER)
        {
            this._CEP_LOCAL = CEP_LOCAL;
            this._typeLoad = CepLoadType.LoadByCep;
            this._ORDER = ORDER;
            this.Load();
        }

        public CepCollection(CepLoadType TIPO, string FILTRO, int ORDER)
        {
            this._FILTRO = FILTRO;
            this._typeLoad = TIPO;
            this._ORDER = ORDER;
            this.Load();
        }

        public CepCollection(CepLoadType TIPO, string CODCID, string NOME_BAIRRO, string  NOME_RUA, int ORDER)
        {
            this._COD_CIDADE = CODCID;
            this._NOME_BAIRRO = NOME_BAIRRO;
            this._NOME_RUA = NOME_RUA;
            this._typeLoad = TIPO;
            this._ORDER = ORDER;
            this.Load();
        }
        #endregion

        #region Methods
        private void Load()
        {
            try
            {
                this._sb = new StringBuilder();
               
                switch (this._typeLoad)
                {
                    case CepLoadType.LoadAll:
                        this._sb.Append("SELECT CEP_ID, NMRUA, BAIRROINIC, CEPLOCAL, CODEST, TPLOG, CODCID, COMPLEM, CID_ID");
                        this._sb.Append(" FROM CEP ");
                        this._sb.Append(" LEFT JOIN Cidade ON cidade.CID_CODIGO = CEP.CODCID WHERE CEPLOCAL IS NOT NULL ");
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case CepLoadType.LoadByCep:
                        this._sb.Append("SELECT CEP_ID, NMRUA, BAIRROINIC, CEPLOCAL, CODEST, TPLOG, CODCID, COMPLEM, CID_ID");
                        this._sb.Append(" FROM CEP ");
                        this._sb.Append(" LEFT JOIN Cidade ON cidade.CID_CODIGO = CEP.CODCID WHERE CEPLOCAL IS NOT NULL ");
                        this._sb.Append("AND CEP_LOCAL COLLATE Latin1_General_CI_AI LIKE '%' + @CEP_LOCAL + '%' ");
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CEP_LOCAL", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._CEP_LOCAL;
                        break;
                    case CepLoadType.LoadById:
                        this._sb.Append("SELECT CEP_ID, NMRUA, BAIRROINIC, CEPLOCAL, CODEST, TPLOG, CODCID, COMPLEM, CID_ID");
                        this._sb.Append(" FROM CEP ");
                        this._sb.Append(" LEFT JOIN Cidade ON cidade.CID_CODIGO = CEP.CODCID WHERE CEPLOCAL IS NOT NULL ");
                        this._sb.Append("AND CEP_ID = @CEP_ID ");
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CEP_ID", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._FILTRO;
                        break;
                    case CepLoadType.LoadByBairro:
                        this._sb.Append("SELECT DISTINCT null as CEP_ID, NMRUA, null as BAIRROINIC, null as CEPLOCAL, null as CODEST, null as TPLOG, null as CODCID, null as COMPLEM, null as CID_ID");
                        this._sb.Append(" FROM CEP ");
                        this._sb.Append(" LEFT JOIN Cidade ON cidade.CID_CODIGO = CEP.CODCID WHERE CEPLOCAL IS NOT NULL ");
                        this._sb.Append(" AND BAIRROINIC COLLATE Latin1_General_CI_AI LIKE '%' + @BAIRROINIC + '%' ");
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@BAIRROINIC", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._FILTRO;
                        break;
                    case CepLoadType.LoadByCodCid:
                        this._sb.Append("SELECT DISTINCT null as CEP_ID, null as NMRUA, BAIRROINIC, null as CEPLOCAL, null as CODEST, null as TPLOG, null as CODCID, null as COMPLEM, null as CID_ID");
                        this._sb.Append(" FROM CEP ");
                        this._sb.Append(" LEFT JOIN Cidade ON cidade.CID_CODIGO = CEP.CODCID WHERE CEPLOCAL IS NOT NULL ");
                        this._sb.Append(" AND CODCID = @CODCID ");
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CODCID", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._FILTRO;
                        break;
                    case CepLoadType.LoadByStreet:
                        this._sb.Append(" SELECT DISTINCT CEP_ID, NMRUA, BAIRROINIC, CEPLOCAL, CODEST, TPLOG, CODCID, COMPLEM, CID_ID");
                        this._sb.Append(" FROM CEP ");
                        this._sb.Append(" LEFT JOIN Cidade ON cidade.CID_CODIGO = CEP.CODCID WHERE CEPLOCAL IS NOT NULL ");
                        this._sb.Append(" AND NMRUA COLLATE Latin1_General_CI_AI LIKE '%' + @NMRUA + '%'  ");
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@NMRUA", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._FILTRO;
                        break;
                    case CepLoadType.LoadCepByAll:
                        int indexParam = 0;
                        this._sb.Append(" SELECT DISTINCT CEP_ID, null as NMRUA, null as BAIRROINIC, CEPLOCAL, null as CODEST, null as TPLOG, null as CODCID, null as COMPLEM, null as CID_ID");
                        this._sb.Append(" FROM CEP ");
                        this._sb.Append(" LEFT JOIN Cidade ON cidade.CID_CODIGO = CEP.CODCID WHERE CEPLOCAL IS NOT NULL ");
                        this.cmd = new SqlCommand();
                        this.cmd.Connection = this.con;

                        this.cmd.CommandType = CommandType.Text;
                        if (_NOME_RUA != "")
                        {
                            this._sb.Append(" AND NMRUA COLLATE Latin1_General_CI_AI LIKE '%' + @NMRUA + '%'  ");
                            this.cmd.Parameters.Add("@NMRUA", SqlDbType.VarChar);
                            this.cmd.Parameters[indexParam].Value = this._NOME_RUA;

                            indexParam++;
                        }

                        if (_NOME_BAIRRO != "")
                        {
                            this._sb.Append(" AND BAIRROINIC COLLATE Latin1_General_CI_AI LIKE '%' + @BAIRROINIC + '%' ");
                            this.cmd.Parameters.Add("@BAIRROINIC", SqlDbType.VarChar);
                            this.cmd.Parameters[indexParam].Value = this._NOME_BAIRRO;
                            indexParam++;
                        }

                        if (_COD_CIDADE != "")
                        {
                            this._sb.Append(" AND CODCID = @CODCID ");
                            this.cmd.Parameters.Add("@CODCID", SqlDbType.VarChar);
                            this.cmd.Parameters[indexParam].Value = this._COD_CIDADE;
                            indexParam++;
                        }

                        this._sb.Append(Order());

                        this.cmd.CommandText = this._sb.ToString();
                        break;
                }

                this.con.Open();                                                                                      
                SqlDataReader dr = cmd.ExecuteReader();                                                               
                while (dr.Read())                                                                                     
                {                                                                                                         
                    this.Add(new Cep(     dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value,   //CEP_ID                                
                                          dr.IsDBNull(1) ? "" : dr.GetSqlString(1).Value, // NMRUA                           
                                          dr.IsDBNull(2) ? "" : dr.GetSqlString(2).Value, //BAIRROINIC                           
                                          dr.IsDBNull(3) ? "" : dr.GetSqlString(3).Value, //CEPLOCAL                           
                                          dr.IsDBNull(4) ? "" : dr.GetSqlString(4).Value, //CODEST                             
                                          dr.IsDBNull(5) ? "" : dr.GetSqlString(5).Value, //TPLOG                                
                                          dr.IsDBNull(6) ? "" : dr.GetSqlString(6).Value, //CODCID                                 
                                          dr.IsDBNull(7) ? "" : dr.GetSqlString(7).Value  //COMPLEM
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
            string ordenado = "ORDER BY ";

            switch (this._ORDER)
            {
                case 0:
                    ordenado += "CEP_ID ";
                    break;
                case 1:
                    ordenado += "NMRUA ";
                    break;
                case 2:
                    ordenado += "BAIRROINIC ";
                    break;
                case 3:
                    ordenado += "CEPLOCAL ";
                    break;
                case 4:
                    ordenado += "CODEST ";
                    break;
                default:
                    ordenado += "TPLOG ";
                    break;
            }
            return ordenado;
        }
        #endregion

    }

    public enum CepLoadType
    {
        LoadAll,
        LoadById,
        LoadByCep,
        LoadByBairro,
        LoadByCodCid,
        LoadByStreet,
        LoadCepByAll
    }
}
