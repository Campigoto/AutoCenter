using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
   public class Compra
   {
        #region Fields
       private int _COM_CODIGO = 0;
       private int _COM_NF;
       private int _COM_CLIENTE_FORNECEDOR;
       private int _COM_TIPO_PAGTO;
       private int _COM_CANCELADO;
       private float _COM_OUT_DESPESAS;
       private float _COM_FRETE;
       private float _COM_ACRESCIMO;
       private float _COM_DESCONTO;
       private float _COM_TOTAL;
       private DateTime _COM_DATA;
       private DateTime _COM_ALTERACAO;
       private DateTime _COM_DATA_CANCELADO;
       private string _COM_OBS;
       private int _COM_LANCAMENTO;
       private int _PARAMETRO_PESQUISA;
       private int _COM_TIPO_MOVIMENTO;

       private string _FOR_NOME = "";
       private StringBuilder _CONSULTA;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Properties
       public int COM_CODIGO
        {
            get { return _COM_CODIGO; }
            set { _COM_CODIGO = value; }                                        
        }
       public int COM_NF
       {
           get { return _COM_NF; }
           set { _COM_NF = value; }
       }
       public string COM_NF_FORMATADO
       {
           get 
           {
               if (_COM_NF > 0)
               {
                   return _COM_NF.ToString(); 
               }
               else
               {
                   return ""; 
               }
           }
       }
       public int COM_CLIENTE_FORNECEDOR
       {
           get { return _COM_CLIENTE_FORNECEDOR; }
           set { _COM_CLIENTE_FORNECEDOR = value; }
       }
       public int COM_TIPO_PAGTO
       {
           get { return _COM_TIPO_PAGTO; }
           set { _COM_TIPO_PAGTO = value; }
       }
       public int COM_CANCELADO
       {
           get { return _COM_CANCELADO; }
           set { _COM_CANCELADO = value; }
       }
       public float COM_OUT_DESPESAS
       {
           get { return _COM_OUT_DESPESAS; }
           set { _COM_OUT_DESPESAS = value; }
       }
       public float COM_FRETE
       {
           get { return _COM_FRETE; }
           set { _COM_FRETE = value; }
       }
       public float COM_ACRESCIMO
       {
           get { return _COM_ACRESCIMO; }
           set { _COM_ACRESCIMO = value; }
       }
       public float COM_DESCONTO
       {
           get { return _COM_DESCONTO; }
           set { _COM_DESCONTO = value; }
       }
       public float COM_TOTAL
       {
           get { return _COM_TOTAL; }
           set { _COM_TOTAL = value; }
       }
       public string COM_TOTAL_FORMATADO
       {
           get { return _COM_TOTAL.ToString("0.00"); }
       }
       public DateTime COM_DATA
       {
           get { return _COM_DATA; }
           set { _COM_DATA = value; }
       }
       public DateTime COM_ALTERACAO
       {
           get { return _COM_ALTERACAO; }
           set { _COM_ALTERACAO = value; }
       }
       public DateTime COM_DATA_CANCELADO
       {
           get { return _COM_DATA_CANCELADO; }
           set { _COM_DATA_CANCELADO = value; }
       }
       public string COM_OBS
         {
             get { return _COM_OBS; }
             set { _COM_OBS = value; }
         }
       public int COM_LANCAMENTO
       {
           get { return _COM_LANCAMENTO; }
           set { _COM_LANCAMENTO = value; }
       }
       public string FOR_NOME
       {
           get { return _FOR_NOME; }
           set { _FOR_NOME = value; }
       }

       public int COM_TIPO_MOVIMENTO
       {
           get { return _COM_TIPO_MOVIMENTO; }
           set { _COM_TIPO_MOVIMENTO = value; }
       }
        #endregion                                                                                        
                                                                                                   
        #region Constructors
        public Compra() { }

       public Compra(int COM_CODIGO, int PARAMETRO_PESQUISA)
        {
            this._COM_CODIGO = COM_CODIGO;
            this._PARAMETRO_PESQUISA = PARAMETRO_PESQUISA;
            this.Carregar();                                                                       
        }

       public Compra(int COM_CODIGO, int COM_NF, int COM_CLIENTE_FORNECEDOR, int COM_TIPO_PAGTO, int COM_CANCELADO, float COM_OUT_DESPESAS, 
           float COM_FRETE, float COM_ACRESCIMO, float COM_DESCONTO, float COM_TOTAL, DateTime COM_DATA, DateTime COM_ALTERACAO,
           DateTime COM_DATA_CANCELADO, string COM_OBS, int COM_LANCAMENTO, string FOR_NOME, int COM_TIPO_MOVIMENTO)
        {
            this._COM_CODIGO = COM_CODIGO;
            this._COM_NF = COM_NF;
            this._COM_CLIENTE_FORNECEDOR = COM_CLIENTE_FORNECEDOR;
            this._COM_TIPO_PAGTO = COM_TIPO_PAGTO;
            this._COM_CANCELADO = COM_CANCELADO;
            this._COM_OUT_DESPESAS = COM_OUT_DESPESAS;
            this._COM_FRETE = COM_FRETE;
            this._COM_ACRESCIMO = COM_ACRESCIMO;
            this._COM_DESCONTO = COM_DESCONTO;
            this._COM_TOTAL = COM_TOTAL;
            this._COM_DATA = COM_DATA;
            this._COM_ALTERACAO = COM_ALTERACAO;
            this._COM_DATA_CANCELADO = COM_DATA_CANCELADO;
            this._COM_OBS = COM_OBS;
            this._COM_LANCAMENTO = COM_LANCAMENTO;
            this._FOR_NOME = FOR_NOME;
            this._COM_TIPO_MOVIMENTO = COM_TIPO_MOVIMENTO;
        }                                                                      
        #endregion

        #region Methods
        private void Carregar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("SELECT COM_CODIGO, COM_NF, COM_CLIENTE_FORNECEDOR, COM_TIPO_PAGTO, COM_CANCELADO, COM_OUT_DESPESAS, ");
                this._CONSULTA.Append("COM_FRETE, COM_ACRESCIMO, COM_DESCONTO, COM_TOTAL, COM_DATA, COM_ALTERACAO, COM_DATA_CANCELADO, ");
                this._CONSULTA.Append("COM_OBS, COM_LANCAMENTO, COM_TIPO_MOVIMENTO FROM Compra WHERE COM_CODIGO = @COM_CODIGO AND COM_LANCAMENTO = @COM_LANCAMENTO");
                this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@COM_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = this._COM_CODIGO;
                this.cmd.Parameters.Add("@COM_LANCAMENTO", SqlDbType.Int);
                this.cmd.Parameters[1].Value = this._PARAMETRO_PESQUISA;

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    this._COM_CODIGO = dr.GetSqlInt32(0).Value;
                    this._COM_NF = dr.GetSqlInt32(1).Value;
                    this._COM_CLIENTE_FORNECEDOR = dr.GetSqlInt32(2).Value;
                    this._COM_TIPO_PAGTO = dr.GetSqlInt32(3).Value;
                    this._COM_CANCELADO = dr.GetSqlInt32(4).Value;
                    this._COM_OUT_DESPESAS = float.Parse(dr.GetSqlDouble(5).Value.ToString());
                    this._COM_FRETE = float.Parse(dr.GetSqlDouble(6).Value.ToString());
                    this._COM_ACRESCIMO = float.Parse(dr.GetSqlDouble(7).Value.ToString());
                    this._COM_DESCONTO = float.Parse(dr.GetSqlDouble(8).Value.ToString());
                    this._COM_TOTAL = float.Parse(dr.GetSqlDouble(9).Value.ToString());
                    this._COM_DATA = dr.GetSqlDateTime(10).Value;
                    this._COM_ALTERACAO = dr.GetSqlDateTime(11).Value;
                    this._COM_DATA_CANCELADO = dr.GetSqlDateTime(12).Value;
                    this._COM_OBS = dr.GetSqlString(13).Value;
                    try
                    {
                        this._COM_LANCAMENTO = dr.GetSqlInt32(14).Value;
                    }
                    catch (Exception)
                    {
                        this._COM_LANCAMENTO = 0;
                    }
                    this.COM_TIPO_MOVIMENTO = dr.IsDBNull(15) ? 0 : dr.GetSqlInt32(15).Value;
                }
                else
                {
                    this._COM_CODIGO = 0;
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
                if (this._COM_CODIGO == 0)
                {

                    this._CONSULTA.Append("INSERT INTO Compra ( COM_NF, COM_CLIENTE_FORNECEDOR, COM_TIPO_PAGTO, COM_CANCELADO, ");
                    this._CONSULTA.Append("COM_OUT_DESPESAS, COM_FRETE, COM_ACRESCIMO, COM_DESCONTO, COM_TOTAL, COM_DATA, COM_ALTERACAO, ");
                    this._CONSULTA.Append("COM_DATA_CANCELADO, COM_OBS, COM_LANCAMENTO, COM_TIPO_MOVIMENTO ) ");
                    this._CONSULTA.Append("VALUES ( @COM_NF, @COM_CLIENTE_FORNECEDOR, @COM_TIPO_PAGTO, @COM_CANCELADO, ");
                    this._CONSULTA.Append("@COM_OUT_DESPESAS, @COM_FRETE, @COM_ACRESCIMO, @COM_DESCONTO, @COM_TOTAL, @COM_DATA, @COM_ALTERACAO, ");
                    this._CONSULTA.Append("@COM_DATA_CANCELADO, @COM_OBS, @COM_LANCAMENTO, @COM_TIPO_MOVIMENTO ) ");
                    this._CONSULTA.Append("SET @COM_CODIGO = @@IDENTITY ");
                }
                else
                {
                    this._CONSULTA.Append("UPDATE Compra SET COM_NF = @COM_NF, COM_CLIENTE_FORNECEDOR = @COM_CLIENTE_FORNECEDOR, ");
                    this._CONSULTA.Append("COM_TIPO_PAGTO = @COM_TIPO_PAGTO, COM_CANCELADO = @COM_CANCELADO, COM_OUT_DESPESAS = @COM_OUT_DESPESAS, ");
                    this._CONSULTA.Append("COM_FRETE = @COM_FRETE, COM_ACRESCIMO = @COM_ACRESCIMO, COM_DESCONTO = @COM_DESCONTO, COM_TOTAL = @COM_TOTAL, ");
                    this._CONSULTA.Append("COM_DATA = @COM_DATA, COM_ALTERACAO = @COM_ALTERACAO, COM_DATA_CANCELADO = @COM_DATA_CANCELADO, COM_OBS = @COM_OBS, ");
                    this._CONSULTA.Append("COM_LANCAMENTO = @COM_LANCAMENTO, COM_TIPO_MOVIMENTO = @COM_TIPO_MOVIMENTO WHERE COM_CODIGO = @COM_CODIGO ");
                }
                SqlCommand cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);                                   
                                                                                                          
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@COM_CODIGO", SqlDbType.Int);
                cmd.Parameters[0].Value = this._COM_CODIGO;
                cmd.Parameters[0].Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add("@COM_NF", SqlDbType.Int);
                cmd.Parameters[1].Value = this._COM_NF;
                cmd.Parameters.Add("@COM_CLIENTE_FORNECEDOR", SqlDbType.Int);
                cmd.Parameters[2].Value = this._COM_CLIENTE_FORNECEDOR;
                cmd.Parameters.Add("@COM_TIPO_PAGTO", SqlDbType.Int);
                cmd.Parameters[3].Value = this._COM_TIPO_PAGTO;
                cmd.Parameters.Add("@COM_CANCELADO", SqlDbType.Int);
                cmd.Parameters[4].Value = this._COM_CANCELADO;

                cmd.Parameters.Add("@COM_OUT_DESPESAS", SqlDbType.Float);
                cmd.Parameters[5].Value = this._COM_OUT_DESPESAS;
                cmd.Parameters.Add("@COM_FRETE", SqlDbType.Float);
                cmd.Parameters[6].Value = this._COM_FRETE;
                cmd.Parameters.Add("@COM_ACRESCIMO", SqlDbType.Float);
                cmd.Parameters[7].Value = this._COM_ACRESCIMO;
                cmd.Parameters.Add("@COM_DESCONTO", SqlDbType.Float);
                cmd.Parameters[8].Value = this._COM_DESCONTO;
                cmd.Parameters.Add("@COM_TOTAL", SqlDbType.Float);
                cmd.Parameters[9].Value = this._COM_TOTAL;

                cmd.Parameters.Add("@COM_DATA", SqlDbType.DateTime);
                cmd.Parameters[10].Value = this._COM_DATA;
                cmd.Parameters.Add("@COM_ALTERACAO", SqlDbType.DateTime);
                cmd.Parameters[11].Value = this._COM_ALTERACAO;
                cmd.Parameters.Add("@COM_DATA_CANCELADO", SqlDbType.DateTime);
                cmd.Parameters[12].Value = this._COM_DATA_CANCELADO;

                cmd.Parameters.Add("@COM_OBS", SqlDbType.VarChar);
                cmd.Parameters[13].Value = this._COM_OBS;
                cmd.Parameters.Add("@COM_LANCAMENTO", SqlDbType.Int);
                cmd.Parameters[14].Value = this._COM_LANCAMENTO;
                cmd.Parameters.Add("@COM_TIPO_MOVIMENTO", SqlDbType.Int);
                cmd.Parameters[15].Value = this._COM_TIPO_MOVIMENTO;
                                           
                this.con.Open();                                                                                 
                if (cmd.ExecuteNonQuery() > 0)                                                                     
                {
                    this._COM_CODIGO = int.Parse(cmd.Parameters[0].Value.ToString());                            
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

        public int BaixaEstoque(string query)
        {
            int executou = 0;
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append(query);
              
                SqlCommand cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);

                this.con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                executou = int.Parse(reader["Aviso"].ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.con.State == ConnectionState.Open) this.con.Close();
            }
            return executou;
        }
        #endregion
    }
}
