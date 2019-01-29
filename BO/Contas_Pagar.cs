using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
   public class Contas_Pagar
   {
       #region Fields
       private int _CAP_CODIGO = 0;
       private int _CAP_FORNECEDOR;
       private int _CAP_COMPRA;
       private float _CAP_TOTAL;
       private DateTime _CAP_CADASTRO;
       private string _CAP_OBS;
       private int _CAP_LANCAMENTO;

       private string _FOR_NOME = "";
       private StringBuilder _CONSULTA;
       private SqlCommand cmd;
       private SqlConnection con = new SqlConnection(Connection.ConnectionString);
       #endregion

        #region Properties
       public int CAP_CODIGO
        {
            get { return _CAP_CODIGO; }
            set { _CAP_CODIGO = value; }                                        
        }
       public int CAP_FORNECEDOR
       {
           get { return _CAP_FORNECEDOR; }
           set { _CAP_FORNECEDOR = value; }
       }
       public int CAP_COMPRA
       {
           get { return _CAP_COMPRA; }
           set { _CAP_COMPRA = value; }
       }
       public string CAP_COMPRA_FORMATADO
       {
           get 
           {
               if (_CAP_COMPRA > 0)
               {
                   return _CAP_COMPRA.ToString(); 
               }
               else
               {
                   return "";
               }
           }
       }
       public float CAP_TOTAL
       {
           get { return _CAP_TOTAL; }
           set { _CAP_TOTAL = value; }
       }
       public string CAP_TOTAL_FORMATADO
       {
           get { return _CAP_TOTAL.ToString("0.00"); }
       }
       public DateTime CAP_CADASTRO
       {
           get { return _CAP_CADASTRO; }
           set { _CAP_CADASTRO = value; }
       }
       public string CAP_OBS
         {
             get { return _CAP_OBS; }
             set { _CAP_OBS = value; }
         }
       public int CAP_LANCAMENTO
       {
           get { return _CAP_LANCAMENTO; }
           set { _CAP_LANCAMENTO = value; }
       }

       public string FOR_NOME
       {
           get { return _FOR_NOME; }
           set { _FOR_NOME = value; }
       }
        #endregion                                                                                        
                                                                                                   
        #region Constructors
        public Contas_Pagar() { }

       public Contas_Pagar(int CAP_CODIGO)
        {
            this._CAP_CODIGO = CAP_CODIGO;
            this.Carregar();                                                                       
        }

       public Contas_Pagar(int CAP_CODIGO, int CAP_FORNECEDOR, int CAP_COMPRA, float CAP_TOTAL, DateTime CAP_CADASTRO, 
           string CAP_OBS, int CAP_LANCAMENTO, string FOR_NOME)
        {
            this._CAP_CODIGO = CAP_CODIGO;
            this._CAP_FORNECEDOR = CAP_FORNECEDOR;
            this._CAP_COMPRA = CAP_COMPRA;
            this._CAP_TOTAL = CAP_TOTAL;
            this._CAP_CADASTRO = CAP_CADASTRO;
            this._CAP_OBS = CAP_OBS;
            this._CAP_LANCAMENTO = CAP_LANCAMENTO;
            this._FOR_NOME = FOR_NOME;
        }                                                                      
        #endregion

        #region Methods
        public void Deletar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Contas_Pagar WHERE CAP_CODIGO = @CAP_CODIGO ", this.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@CAP_CODIGO", SqlDbType.Int);
                cmd.Parameters[0].Value = this._CAP_CODIGO;

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
                this._CONSULTA.Append("SELECT CAP_CODIGO, CAP_FORNECEDOR, CAP_COMPRA, CAP_TOTAL, CAP_CADASTRO, CAP_OBS, CAP_LANCAMENTO ");
                this._CONSULTA.Append("FROM Contas_Pagar WHERE CAP_CODIGO = @CAP_CODIGO ");
                this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@CAP_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = this._CAP_CODIGO;

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    this._CAP_CODIGO = dr.GetSqlInt32(0).Value;
                    this._CAP_FORNECEDOR = dr.GetSqlInt32(1).Value;
                    this._CAP_COMPRA = dr.GetSqlInt32(2).Value;
                    this._CAP_TOTAL = float.Parse(dr.GetSqlDouble(3).Value.ToString());
                    this._CAP_CADASTRO = dr.GetSqlDateTime(4).Value;
                    this._CAP_OBS = dr.GetSqlString(5).Value;
                    try
                    {
                        this._CAP_LANCAMENTO = dr.GetSqlInt32(6).Value;
                    }
                    catch (Exception)
                    {
                        this._CAP_LANCAMENTO = 0;
                    }
                    
                }                           
                else
                    this._CAP_CODIGO = 0;
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
                if (this._CAP_CODIGO == 0)
                {

                    this._CONSULTA.Append("INSERT INTO Contas_Pagar ( CAP_FORNECEDOR, CAP_COMPRA, ");
                    this._CONSULTA.Append("CAP_TOTAL, CAP_CADASTRO, CAP_OBS, CAP_LANCAMENTO ) ");
                    this._CONSULTA.Append("VALUES ( @CAP_FORNECEDOR, @CAP_COMPRA, @CAP_TOTAL, @CAP_CADASTRO, @CAP_OBS, @CAP_LANCAMENTO ) ");
                    this._CONSULTA.Append("SET @CAP_CODIGO = @@IDENTITY ");
                }
                else
                {
                    this._CONSULTA.Append("UPDATE Contas_Pagar SET CAP_FORNECEDOR = @CAP_FORNECEDOR, CAP_COMPRA = @CAP_COMPRA, ");
                    this._CONSULTA.Append("CAP_TOTAL = @CAP_TOTAL, CAP_CADASTRO = @CAP_CADASTRO, CAP_OBS = @CAP_OBS, CAP_LANCAMENTO = @CAP_LANCAMENTO ");
                    this._CONSULTA.Append("WHERE CAP_CODIGO = @CAP_CODIGO ");
                }
                SqlCommand cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);                                   
                                                                                                          
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@CAP_CODIGO", SqlDbType.Int);
                cmd.Parameters[0].Value = this._CAP_CODIGO;
                cmd.Parameters[0].Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add("@CAP_FORNECEDOR", SqlDbType.Int);
                cmd.Parameters[1].Value = this._CAP_FORNECEDOR;
                cmd.Parameters.Add("@CAP_COMPRA", SqlDbType.Int);
                cmd.Parameters[2].Value = this._CAP_COMPRA;
                cmd.Parameters.Add("@CAP_TOTAL", SqlDbType.Float);
                cmd.Parameters[3].Value = this._CAP_TOTAL;
                cmd.Parameters.Add("@CAP_CADASTRO", SqlDbType.DateTime);
                cmd.Parameters[4].Value = this._CAP_CADASTRO;
                cmd.Parameters.Add("@CAP_OBS", SqlDbType.VarChar);
                cmd.Parameters[5].Value = this._CAP_OBS;
                cmd.Parameters.Add("@CAP_LANCAMENTO", SqlDbType.Int);
                cmd.Parameters[6].Value = this._CAP_LANCAMENTO;
                                           
                this.con.Open();                                                                                 
                if (cmd.ExecuteNonQuery() > 0)                                                                     
                {
                    this._CAP_CODIGO = int.Parse(cmd.Parameters[0].Value.ToString());                            
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
