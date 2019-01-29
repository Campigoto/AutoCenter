using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient; 

namespace BO
{
    public class Historico_LancamentoCollection : List<Historico_Lancamento>
    {
         #region Fields
        private int _HIS_ID;
        private string _HIS_CODIGO;
        private string _HIS_DESCRICAO;
        private Historico_LancamentoLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public Historico_LancamentoCollection() { }

        public Historico_LancamentoCollection(bool isLoad)
        {
            this._typeLoad = Historico_LancamentoLoadType.LoadAll;
            if (isLoad) this.Load();
        }

        public Historico_LancamentoCollection(int HIS_ID)
        {
            this._typeLoad = Historico_LancamentoLoadType.LoadById;
            this._HIS_ID = HIS_ID;                                                   
            this.Load();                                                                       
        }                                                                                  

        public Historico_LancamentoCollection(string HIS_DESCRICAO)
        {
            this._HIS_DESCRICAO = HIS_DESCRICAO;
            this._typeLoad = Historico_LancamentoLoadType.LoadByHistorico_LancamentoDESCRICAO;
            this.Load();
        }

        public Historico_LancamentoCollection(Historico_LancamentoLoadType TIPO, string HIS_DESCRICAO)
        {
            this._HIS_DESCRICAO = HIS_DESCRICAO;
            this._typeLoad = TIPO;
            this.Load();
        }
        #endregion
     
        #region Methods
        private void Load()
        {
            try
            {
                switch (this._typeLoad)
                {
                    case Historico_LancamentoLoadType.LoadAll:
                        this.cmd = new SqlCommand("SELECT HIS_ID, HIS_CODIGO, HIS_DESCRICAO FROM Historico_Lancamento ORDER BY HIS_DESCRICAO ", this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case Historico_LancamentoLoadType.LoadByHistorico_LancamentoDESCRICAO:
                        this.cmd = new SqlCommand("SELECT HIS_ID, HIS_CODIGO, HIS_DESCRICAO FROM Historico_Lancamento WHERE HIS_DESCRICAO COLLATE Latin1_General_CI_AI LIKE '%' + @HIS_DESCRICAO + '%' ORDER BY HIS_DESCRICAO ", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@HIS_DESCRICAO", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._HIS_DESCRICAO;
                        break;
                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();                     
                while (dr.Read())                                           
                {

                    this.Add(new Historico_Lancamento(dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value,
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
        #endregion
    }
    
    public enum Historico_LancamentoLoadType
    {
        LoadAll,
        LoadById,
        LoadByCodigo,
        LoadByHistorico_LancamentoDESCRICAO
    }
    
}
