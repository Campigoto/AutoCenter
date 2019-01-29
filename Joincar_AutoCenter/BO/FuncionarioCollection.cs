using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;                                                                                       

namespace BO
{
    public class FuncionarioCollection : List<Funcionario>
    {
        #region Fields
        private int _FUN_CODIGO;
        private string _FUN_NOME;
        private FuncionarioLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public FuncionarioCollection() { }

        public FuncionarioCollection(bool isLoad)
        {
            this._typeLoad = FuncionarioLoadType.LoadAll;
            if (isLoad) this.Load();
        }

        public FuncionarioCollection(int FUN_CODIGO)
        {
            this._typeLoad = FuncionarioLoadType.LoadById;
            this._FUN_CODIGO = FUN_CODIGO;                                                   
            this.Load();                                                                       
        }

        public FuncionarioCollection(string FUN_NOME)
        {
            this._FUN_NOME = FUN_NOME;
            this._typeLoad = FuncionarioLoadType.LoadByNome;
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
                    case FuncionarioLoadType.LoadAll:
                        this.cmd = new SqlCommand("SELECT FUN_CODIGO,FUN_USUARIO,FUN_INATIVO, FUN_CIDADE,FUN_NOME,FUN_LOGIN,FUN_SENHA,FUN_OBS,FUN_CADASTRO,FUN_DESPESAS FROM Funcionario ", this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case FuncionarioLoadType.LoadByNome:
                        this.cmd = new SqlCommand("SELECT FUN_CODIGO,FUN_USUARIO,FUN_INATIVO, FUN_CIDADE,FUN_NOME,FUN_LOGIN,FUN_SENHA,FUN_OBS,FUN_CADASTRO,FUN_DESPESAS FROM Funcionario WHERE FUN_NOME = @FUN_NOME ", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@FUN_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._FUN_NOME;
                        break;
                    case FuncionarioLoadType.LoadById:
                        this.cmd = new SqlCommand("SELECT FUN_CODIGO,FUN_USUARIO,FUN_INATIVO, FUN_CIDADE,FUN_NOME,FUN_LOGIN,FUN_SENHA,FUN_OBS,FUN_CADASTRO,FUN_DESPESAS FROM Funcionario WHERE FUN_CODIGO = @FUN_CODIGO ", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@FUN_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._FUN_CODIGO;
                        break;

                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();                     
                while (dr.Read())                                           
                {
                   
                    this.Add(new Funcionario (dr.IsDBNull(0) ? 0  : dr.GetSqlInt32(0).Value,
                        dr.IsDBNull(1) ? 0  : dr.GetSqlInt32(1).Value,
                        dr.IsDBNull(2) ? 0  : dr.GetSqlInt32(2).Value,
                        dr.IsDBNull(3) ? 0  : dr.GetSqlInt32(3).Value,
                        dr.IsDBNull(4) ? ""  : dr.GetSqlString(4).Value,
                        dr.IsDBNull(5) ? ""  : dr.GetSqlString(5).Value,
                        dr.IsDBNull(6) ? ""  : dr.GetSqlString(6).Value,
                        dr.IsDBNull(7) ? ""  : dr.GetSqlString(7).Value,
                        dr.IsDBNull(8) ? DateTime.Now  : dr.GetSqlDateTime(8).Value,
                        dr.IsDBNull(9) ? 0 : float.Parse(dr.GetSqlDouble(9).Value.ToString())));                     
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

    public enum FuncionarioLoadType
    {
        LoadAll,
        LoadById,
        LoadByNome
    }
}
