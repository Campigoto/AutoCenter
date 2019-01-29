using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class CidadeCollection : List<Cidade>
     {
        #region Fields
        private int _CID_CODIGO;
        private int _ORDER;
        private string _CID_UF;
        private string _CID_NOME;
        private CidadeLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public CidadeCollection() { }

        public CidadeCollection(bool isLoad, int ORDER)
        {
            this._typeLoad = CidadeLoadType.LoadAll;
            this._ORDER = ORDER;
            if (isLoad) this.Load();
        }

        public CidadeCollection(int CID_CODIGO, int ORDER)
        {
            this._typeLoad = CidadeLoadType.LoadById;
            this._CID_CODIGO = CID_CODIGO;
            this._ORDER = ORDER;
            this.Load();                                                                       
        }

        public CidadeCollection(CidadeLoadType TIPO, string NOME, int ORDER)
        {
            if (TIPO == CidadeLoadType.LoadByCidadeNome)
            {
                this._CID_NOME = NOME;
                this._typeLoad = TIPO;
                this._ORDER = ORDER;
                this.Load();
            }
            else if (TIPO == CidadeLoadType.LoadByCidadeUF)
            {
                this._CID_UF = NOME;
                this._typeLoad = TIPO;
                this._ORDER = ORDER;
                this.Load();
            }
        }
        #endregion
     
        #region Methods
        private void Load()
        {
            try
            {
                switch (this._typeLoad)
                {
                    case CidadeLoadType.LoadAll:
                        this.cmd = new SqlCommand("SELECT CID_CODIGO, CID_NOME, CID_UF FROM CIDADE " + Order(), this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case CidadeLoadType.LoadById:
                        this.cmd = new SqlCommand("SELECT CID_CODIGO, CID_NOME, CID_UF FROM CIDADE WHERE CID_CODIGO = @CID_CODIGO " + Order(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CID_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._CID_CODIGO;
                        break;
                    case CidadeLoadType.LoadByCidadeUF:
                        this.cmd = new SqlCommand("SELECT CID_CODIGO, CID_NOME, CID_UF FROM CIDADE WHERE CID_UF = @CID_UF " + Order(), this.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@CID_UF", SqlDbType.VarChar);
                        cmd.Parameters[0].Value = this._CID_UF;
                        break;
                    case CidadeLoadType.LoadByCidadeNome:
                        this.cmd = new SqlCommand("SELECT CID_CODIGO, CID_NOME, CID_UF FROM CIDADE WHERE CID_NOME COLLATE Latin1_General_CI_AI LIKE '%' + @CID_NOME + '%' " + Order(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CID_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._CID_NOME;
                        break;

                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();                     
                while (dr.Read())                                           
                {
                   
                    this.Add(new Cidade (dr.IsDBNull(0) ? 0  : dr.GetSqlInt32(0).Value,
                                         dr.IsDBNull(1) ? "" : dr.GetSqlString(1).Value,
                                         dr.IsDBNull(2) ? "" : dr.GetSqlString(2).Value));                     
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
                    ordenado += "CID_CODIGO ";
                    break;
                case 1:
                    ordenado += "CID_NOME ";
                    break;
                case 2:
                    ordenado += "CID_UF ";
                    break;
                default:
                    ordenado += "CID_NOME ";
                    break;
            }
            return ordenado;
        }
        #endregion
    }
    
    public enum CidadeLoadType
    {
        LoadAll,
        LoadById,
        LoadByCidadeNome,
        LoadByCidadeUF
    }
}
