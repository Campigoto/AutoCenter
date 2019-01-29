using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
   public class Cheques_Pagar
   {
        #region Fields
        private int    _CHP_CODIGO = 0;
        private int    _CHP_CARNE;
        private int    _CHP_ITEM;
        private string _CHP_BANCO;
        private string _CHP_AGENCIA;
        private string _CHP_NUM_DOC;
        private string _CHP_CONTA;
        private DateTime _CHP_EMISSAO;
        private DateTime _CHP_VENC;
        private DateTime _CHP_EFETIVACAO;
        private float _CHP_VALOR;
       private string _CHP_OBS;

       private StringBuilder _CONSULTA;
        private SqlCommand cmd;
        private Cheques_PagarLoadType _loadType;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Properties
       public int CHP_CODIGO
        {
            get { return _CHP_CODIGO; }
            set { _CHP_CODIGO = value; }                                        
        }
       public int CHP_CARNE
       {
           get { return _CHP_CARNE; }
           set { _CHP_CARNE = value; }
       }
       public string CHP_CARNE_FORMATADO
       {
           get 
           { 
               if (_CHP_CARNE > 0)
	            {
                    return _CHP_CARNE.ToString(); 
	            }
                else
	            {
                    return "";
	            }
               
           }
       }
       public int CHP_ITEM
       {
           get { return _CHP_ITEM; }
           set { _CHP_ITEM = value; }
       }
       public string CHP_BANCO
         {
             get { return _CHP_BANCO; }
             set { _CHP_BANCO = value; }
         }
       public string CHP_AGENCIA
        {
            get { return _CHP_AGENCIA; }
            set { _CHP_AGENCIA = value; }
        }
       public string CHP_NUM_DOC
       {
           get { return _CHP_NUM_DOC; }
           set { _CHP_NUM_DOC = value; }
       }
       public string CHP_CONTA
       {
           get { return _CHP_CONTA; }
           set { _CHP_CONTA = value; }
       }
       public DateTime CHP_EMISSAO
       {
           get { return _CHP_EMISSAO; }
           set { _CHP_EMISSAO = value; }
       }
       public string CHP_EMISSAO_FORMATADO
       {
           get { return _CHP_EMISSAO.ToString("dd/MM/yyyy"); }
       }
       public DateTime CHP_VENC
       {
           get { return _CHP_VENC; }
           set { _CHP_VENC = value; }
       }
       public string CHP_VENC_FORMATADO
       {
           get { return _CHP_VENC.ToString("dd/MM/yyyy"); }
       }
       public DateTime CHP_EFETIVACAO
       {
           get { return _CHP_EFETIVACAO; }
           set { _CHP_EFETIVACAO = value; }
       }
       public float CHP_VALOR
       {
           get { return _CHP_VALOR; }
           set { _CHP_VALOR = value; }
       }
       public string CHP_VALOR_FORMATADO
       {
           get { return _CHP_VALOR.ToString("0.00"); }
       }
       public string CHP_OBS
       {
           get { return _CHP_OBS; }
           set { _CHP_OBS = value; }
       }
        #endregion                                                                                        
                                                                                                   
        #region Constructors
        public Cheques_Pagar() { }

       public Cheques_Pagar(int CHP_CODIGO)
        {
            this._loadType = Cheques_PagarLoadType.LoadById;
            this._CHP_CODIGO = CHP_CODIGO;
            this.Carregar();                                                                       
        }

       public Cheques_Pagar(int CHP_CARNE, int CHP_ITEM)
       {
           this._loadType = Cheques_PagarLoadType.LoadByCarneItem;
           this._CHP_CARNE = CHP_CARNE;
           this._CHP_ITEM = CHP_ITEM;
           this.Carregar();
       }

       public Cheques_Pagar(int CHP_CODIGO, int CHP_CARNE, int CHP_ITEM, string CHP_BANCO, string CHP_AGENCIA,
            string CHP_NUM_DOC, string CHP_CONTA, DateTime CHP_EMISSAO, DateTime CHP_VENC, DateTime CHP_EFETIVACAO,
           float CHP_VALOR, string CHP_OBS)
        {
            this._CHP_CODIGO = CHP_CODIGO;
            this._CHP_CARNE = CHP_CARNE;
            this._CHP_ITEM = CHP_ITEM;
            this._CHP_BANCO = CHP_BANCO;
            this._CHP_AGENCIA = CHP_AGENCIA;
            this._CHP_NUM_DOC = CHP_NUM_DOC;
            this._CHP_CONTA = CHP_CONTA;
            this._CHP_EMISSAO = CHP_EMISSAO;
            this._CHP_VENC = CHP_VENC;
            this._CHP_EFETIVACAO = CHP_EFETIVACAO;
            this._CHP_VALOR = CHP_VALOR;
            this._CHP_OBS = CHP_OBS;
        }                                                                      
        #endregion

        #region Methods
        public void Deletar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Cheques_Pagar	WHERE CHP_CODIGO = @CHP_CODIGO", this.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@CHP_CODIGO", SqlDbType.Int);
                cmd.Parameters[0].Value = this._CHP_CODIGO;

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

       private void Carregar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("SELECT CHP_CODIGO, CHP_CARNE, CHP_ITEM, CHP_BANCO, CHP_AGENCIA, CHP_NUM_DOC, ");
                this._CONSULTA.Append("CHP_CONTA, CHP_EMISSAO, CHP_VENC, CHP_EFETIVACAO, CHP_VALOR, CHP_OBS FROM Cheques_Pagar ");
                switch (this._loadType)
                {
                    case Cheques_PagarLoadType.LoadById:
                        this._CONSULTA.Append("WHERE CHP_CODIGO = @CHP_CODIGO ");
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CHP_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._CHP_CODIGO;
                        break;
                    case Cheques_PagarLoadType.LoadByCarneItem:
                        this._CONSULTA.Append("WHERE CHP_CARNE = @CHP_CARNE AND CHP_ITEM = @CHP_ITEM ");
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CHP_CARNE", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._CHP_CARNE;
                        this.cmd.Parameters.Add("@CHP_ITEM", SqlDbType.Int);
                        this.cmd.Parameters[1].Value = this._CHP_ITEM;
                        break;

                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    this._CHP_CODIGO = dr.GetSqlInt32(0).Value;
                    this._CHP_CARNE = dr.GetSqlInt32(1).Value;
                    this._CHP_ITEM = dr.GetSqlInt32(2).Value;
                    this._CHP_BANCO = dr.GetSqlString(3).Value;
                    this._CHP_AGENCIA = dr.GetSqlString(4).Value;
                    this._CHP_NUM_DOC = dr.GetSqlString(5).Value;
                    this._CHP_CONTA = dr.GetSqlString(6).Value;
                    this._CHP_EMISSAO = dr.GetSqlDateTime(7).Value;
                    this._CHP_VENC = dr.GetSqlDateTime(8).Value;
                    this._CHP_EFETIVACAO = dr.GetSqlDateTime(9).Value;
                    this._CHP_VALOR = float.Parse(dr.GetSqlDouble(10).Value.ToString());
                    this._CHP_OBS = dr.GetSqlString(11).Value;
                }
                else
                {
                    this._CHP_CODIGO = 0;
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

        public void Salvar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                if (this._CHP_CODIGO == 0)
                {

                    this._CONSULTA.Append("INSERT INTO Cheques_Pagar ( CHP_CARNE, CHP_ITEM, CHP_BANCO, CHP_AGENCIA, CHP_NUM_DOC, ");
                    this._CONSULTA.Append("CHP_CONTA, CHP_EMISSAO, CHP_VENC, CHP_EFETIVACAO, CHP_VALOR, CHP_OBS ) ");
                    this._CONSULTA.Append("VALUES ( @CHP_CARNE, @CHP_ITEM, @CHP_BANCO, @CHP_AGENCIA, @CHP_NUM_DOC, ");
                    this._CONSULTA.Append("@CHP_CONTA, @CHP_EMISSAO, @CHP_VENC, @CHP_EFETIVACAO, @CHP_VALOR, @CHP_OBS ) ");
                    this._CONSULTA.Append("SET @CHP_CODIGO = @@IDENTITY ");
                }
                else
                {
                    this._CONSULTA.Append("UPDATE Cheques_Pagar SET CHP_CARNE=@CHP_CARNE, CHP_ITEM=@CHP_ITEM, CHP_BANCO=@CHP_BANCO, CHP_AGENCIA=@CHP_AGENCIA, CHP_NUM_DOC=@CHP_NUM_DOC, ");
                    this._CONSULTA.Append("CHP_CONTA=@CHP_CONTA, CHP_EMISSAO=@CHP_EMISSAO, CHP_VENC=@CHP_VENC, CHP_EFETIVACAO=@CHP_EFETIVACAO, CHP_VALOR=@CHP_VALOR, CHP_OBS=@CHP_OBS ");
                    this._CONSULTA.Append("WHERE CHP_CODIGO = @CHP_CODIGO ");
                }
                SqlCommand cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);                                   
                                                                                                          
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@CHP_CODIGO", SqlDbType.Int);
                cmd.Parameters[0].Value = this._CHP_CODIGO;
                cmd.Parameters[0].Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add("@CHP_CARNE", SqlDbType.Int);
                cmd.Parameters[1].Value = this._CHP_CARNE;
                cmd.Parameters.Add("@CHP_ITEM", SqlDbType.Int);
                cmd.Parameters[2].Value = this._CHP_ITEM;

                cmd.Parameters.Add("@CHP_BANCO", SqlDbType.VarChar);
                cmd.Parameters[3].Value = this._CHP_BANCO;
                cmd.Parameters.Add("@CHP_AGENCIA", SqlDbType.VarChar);
                cmd.Parameters[4].Value = this._CHP_AGENCIA;
                cmd.Parameters.Add("@CHP_NUM_DOC", SqlDbType.VarChar);
                cmd.Parameters[5].Value = this._CHP_NUM_DOC;
                cmd.Parameters.Add("@CHP_CONTA", SqlDbType.VarChar);
                cmd.Parameters[6].Value = this._CHP_CONTA;

                cmd.Parameters.Add("@CHP_EMISSAO", SqlDbType.DateTime);
                cmd.Parameters[7].Value = this._CHP_EMISSAO;
                cmd.Parameters.Add("@CHP_VENC", SqlDbType.DateTime);
                cmd.Parameters[8].Value = this._CHP_VENC;
                cmd.Parameters.Add("@CHP_EFETIVACAO", SqlDbType.DateTime);
                cmd.Parameters[9].Value = this._CHP_EFETIVACAO;

                cmd.Parameters.Add("@CHP_VALOR", SqlDbType.Float);
                cmd.Parameters[10].Value = this._CHP_VALOR;
                cmd.Parameters.Add("@CHP_OBS", SqlDbType.VarChar);
                cmd.Parameters[11].Value = this._CHP_OBS;
                                           
                this.con.Open();                                                                                 
                if (cmd.ExecuteNonQuery() > 0)                                                                     
                {
                    this._CHP_CODIGO = int.Parse(cmd.Parameters[0].Value.ToString());                            
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
