using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
   public class Parcelas_Pagar
   {
        #region Fields
       private int _PCA_CARNE = 0;
       private int _PCA_ITEM = 0;
       private int _PCA_TIPO;
       private string _PCA_NUM_DOC;
       private string _PCA_OBS;
       private float _PCA_VALOR;
       private float _PCA_VALOR_PAGO;
       private DateTime _PCA_DATA_PAGTO;
       private DateTime _PCA_VENC;
       private int _PCA_ITEM_NOVA_PARC = 0;
       private float _PCA_ACRESCIMO;
       private float _PCA_DESCONTO;

       private string _FOR_NOME = "";
       private StringBuilder _CONSULTA;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Properties
       public int PCA_CARNE
        {
            get { return _PCA_CARNE; }
            set { _PCA_CARNE = value; }                                        
        }
       public int PCA_ITEM
       {
           get { return _PCA_ITEM; }
           set { _PCA_ITEM = value; }
       }
       public int PCA_TIPO
       {
           get { return _PCA_TIPO; }
           set { _PCA_TIPO = value; }
       }
       public string PCA_TIPO_NOME
       {
           get 
           {
               if (_PCA_TIPO == 1)
               {
                   return "Dinheiro";
               }
               else if (_PCA_TIPO == 2)
               {
                   return "Cheque";
               }
               else if (_PCA_TIPO == 3)
               {
                   return "Boleto";
               }
                else if (_PCA_TIPO == 4)
               {
                   return "Débito em C/C";
               }
                else if (_PCA_TIPO == 5)
               {
                   return "DDA";
               }
                else if (_PCA_TIPO == 6)
               {
                   return "Depósito";
               }
                else if (_PCA_TIPO == 7)
               {
                   return "Cartão de Crédito";
               }
                else if (_PCA_TIPO == 8)
               {
                   return "Carnê";
               }
               else if (_PCA_TIPO == 9)
               {
                   return "Financeira";
               }
               else
               {
                   return "";
               }
           }
       }
       public string PCA_NUM_DOC
       {
           get { return _PCA_NUM_DOC; }
           set { _PCA_NUM_DOC = value; }
       }
       public string PCA_OBS
       {
           get { return _PCA_OBS; }
           set { _PCA_OBS = value; }
       }
       public float PCA_VALOR
       {
           get { return _PCA_VALOR; }
           set { _PCA_VALOR = value; }
       }
       public string PCA_VALOR_FORMATADO
       {
           get { return _PCA_VALOR.ToString("0.00"); }
           set { _PCA_VALOR = float.Parse(value); }
       }
       public float PCA_VALOR_PAGO
       {
           get { return _PCA_VALOR_PAGO; }
           set { _PCA_VALOR_PAGO = value; }
       }
       public string PCA_VALOR_PAGO_FORMATADO
       {
           get { return _PCA_VALOR_PAGO.ToString("0.00"); }
       }
       public DateTime PCA_DATA_PAGTO
       {
           get { return _PCA_DATA_PAGTO; }
           set { _PCA_DATA_PAGTO = value; }
       }
       public string PCA_DATA_PAGTO_FORMATADO
       {
           get 
           {
               if (_PCA_DATA_PAGTO.ToString("dd/MM/yyyy") != "01/01/1800")
               {
                   return _PCA_DATA_PAGTO.ToString("dd/MM/yyyy"); 
               }
               else
               {
                   return "";
               }
           }
       }
       public DateTime PCA_VENC
       {
           get { return _PCA_VENC; }
           set { _PCA_VENC = value; }
       }
       public int PCA_ITEM_NOVA_PARC
       {
           get { return _PCA_ITEM_NOVA_PARC; }
           set { _PCA_ITEM_NOVA_PARC = value; }
       }
       public float PCA_ACRESCIMO
       {
           get { return _PCA_ACRESCIMO; }
           set { _PCA_ACRESCIMO = value; }
       }
       public string PCA_ACRESCIMO_FORMATADO
       {
           get { return _PCA_ACRESCIMO.ToString("0.00"); }
           set { _PCA_ACRESCIMO = float.Parse(value); }
       }
       public float PCA_DESCONTO
       {
           get { return _PCA_DESCONTO; }
           set { _PCA_DESCONTO = value; }
       }
       public string PCA_DESCONTO_FORMATADO
       {
           get { return _PCA_DESCONTO.ToString("0.00"); }
           set { _PCA_DESCONTO = float.Parse(value); }
       }
       public string PCA_VENC_FORMATADO
       {
           get { return _PCA_VENC.ToString("dd/MM/yyyy"); }
           set { _PCA_VENC = DateTime.Parse(value); }
       }
       public string FOR_NOME
       {
           get { return _FOR_NOME; }
           set { _FOR_NOME = value; }
       }
       public string PCA_TOTAL_FORMATADO
       {
           get 
           {
               float total = _PCA_VALOR;
               total -= _PCA_DESCONTO;
               total += _PCA_ACRESCIMO;
               return total.ToString("0.00"); 
           }
       }
        #endregion                                                                                        
                                                                                                   
        #region Constructors
        public Parcelas_Pagar() { }

       public Parcelas_Pagar(int PCA_CARNE, int PCA_ITEM)
       {
           this._PCA_CARNE = PCA_CARNE;
           this._PCA_ITEM = PCA_ITEM;
           this.Carregar();
       }

       public Parcelas_Pagar(int PCA_CARNE, int PCA_ITEM, int PCA_TIPO, string PCA_NUM_DOC, string PCA_OBS, float PCA_VALOR,
           float PCA_VALOR_PAGO, DateTime PCA_DATA_PAGTO, DateTime PCA_VENC, int PCA_ITEM_NOVA_PARC, float PCA_ACRESCIMO, 
           float PCA_DESCONTO, string FOR_NOME)
        {
            this._PCA_CARNE = PCA_CARNE;
            this._PCA_ITEM = PCA_ITEM;
            this._PCA_TIPO = PCA_TIPO;
            this._PCA_NUM_DOC = PCA_NUM_DOC;
            this._PCA_OBS = PCA_OBS;
            this._PCA_VALOR = PCA_VALOR;
            this._PCA_VALOR_PAGO = PCA_VALOR_PAGO;
            this._PCA_DATA_PAGTO = PCA_DATA_PAGTO;
            this._PCA_VENC = PCA_VENC;
            this._PCA_ITEM_NOVA_PARC = PCA_ITEM_NOVA_PARC;
            this._PCA_ACRESCIMO = PCA_ACRESCIMO;
            this._PCA_DESCONTO = PCA_DESCONTO;
            this._FOR_NOME = FOR_NOME;
        }                                                                      
        #endregion

        #region Methods
       private void Carregar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("SELECT PCA_CARNE, PCA_ITEM, PCA_TIPO, PCA_NUM_DOC, PCA_OBS, PCA_VALOR, ");
                this._CONSULTA.Append("PCA_VALOR_PAGO, PCA_DATA_PAGTO, PCA_VENC, PCA_ITEM_NOVA_PARC, PCA_ACRESCIMO, PCA_DESCONTO FROM Parcelas_Pagar ");
                this._CONSULTA.Append("WHERE PCA_CARNE = @PCA_CARNE AND PCA_ITEM = @PCA_ITEM ");
                this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@PCA_CARNE", SqlDbType.Int);
                this.cmd.Parameters[0].Value = this._PCA_CARNE;
                this.cmd.Parameters.Add("@PCA_ITEM", SqlDbType.Int);
                this.cmd.Parameters[1].Value = this._PCA_ITEM;

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    this._PCA_CARNE = dr.GetSqlInt32(0).Value;
                    this._PCA_ITEM = dr.GetSqlInt32(1).Value;
                    this._PCA_TIPO = dr.GetSqlInt32(2).Value;
                    this._PCA_NUM_DOC = dr.GetSqlString(3).Value;
                    this._PCA_OBS = dr.GetSqlString(4).Value;
                    this._PCA_VALOR = float.Parse(dr.GetSqlDouble(5).Value.ToString());
                    this._PCA_VALOR_PAGO = float.Parse(dr.GetSqlDouble(6).Value.ToString());
                    this._PCA_DATA_PAGTO = dr.GetSqlDateTime(7).Value;
                    this._PCA_VENC = dr.GetSqlDateTime(8).Value;
                    try
                    {
                        this._PCA_ITEM_NOVA_PARC = dr.GetSqlInt32(9).Value;
                    }
                    catch (Exception)
                    {
                        this._PCA_ITEM_NOVA_PARC = 0;
                    }
                    this._PCA_ACRESCIMO = float.Parse(dr.GetSqlDouble(10).Value.ToString());
                    this._PCA_DESCONTO = float.Parse(dr.GetSqlDouble(11).Value.ToString());
                }
                else
                {
                    this._PCA_CARNE = 0;
                    this._PCA_ITEM = 0;
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
                this._CONSULTA.Append("INSERT INTO Parcelas_Pagar ( PCA_CARNE, PCA_ITEM, PCA_TIPO, PCA_NUM_DOC, PCA_OBS, ");
                this._CONSULTA.Append("PCA_VALOR, PCA_VALOR_PAGO, PCA_DATA_PAGTO, PCA_VENC, PCA_ITEM_NOVA_PARC, PCA_ACRESCIMO, PCA_DESCONTO ) ");
                this._CONSULTA.Append("VALUES ( @PCA_CARNE, @PCA_ITEM, @PCA_TIPO, @PCA_NUM_DOC, @PCA_OBS, ");
                this._CONSULTA.Append("@PCA_VALOR, @PCA_VALOR_PAGO, @PCA_DATA_PAGTO, @PCA_VENC, @PCA_ITEM_NOVA_PARC, @PCA_ACRESCIMO, @PCA_DESCONTO ) ");
                cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);                                   
                                                                                                          
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@PCA_CARNE", SqlDbType.Int);
                cmd.Parameters[0].Value = this._PCA_CARNE;
                cmd.Parameters.Add("@PCA_ITEM", SqlDbType.Int);
                cmd.Parameters[1].Value = this._PCA_ITEM;
                cmd.Parameters.Add("@PCA_TIPO", SqlDbType.Int);
                cmd.Parameters[2].Value = this._PCA_TIPO;
                cmd.Parameters.Add("@PCA_NUM_DOC", SqlDbType.VarChar);
                cmd.Parameters[3].Value = this._PCA_NUM_DOC;
                cmd.Parameters.Add("@PCA_OBS", SqlDbType.VarChar);
                cmd.Parameters[4].Value = this._PCA_OBS;

                cmd.Parameters.Add("@PCA_VALOR", SqlDbType.Float);
                cmd.Parameters[5].Value = this._PCA_VALOR;
                cmd.Parameters.Add("@PCA_VALOR_PAGO", SqlDbType.Float);
                cmd.Parameters[6].Value = this._PCA_VALOR_PAGO;
                cmd.Parameters.Add("@PCA_DATA_PAGTO", SqlDbType.DateTime);
                cmd.Parameters[7].Value = this._PCA_DATA_PAGTO;
                cmd.Parameters.Add("@PCA_VENC", SqlDbType.DateTime);
                cmd.Parameters[8].Value = this._PCA_VENC;
                cmd.Parameters.Add("@PCA_ITEM_NOVA_PARC", SqlDbType.Int);
                cmd.Parameters[9].Value = this._PCA_ITEM_NOVA_PARC;
                cmd.Parameters.Add("@PCA_ACRESCIMO", SqlDbType.Float);
                cmd.Parameters[10].Value = this._PCA_ACRESCIMO;
                cmd.Parameters.Add("@PCA_DESCONTO", SqlDbType.Float);
                cmd.Parameters[11].Value = this._PCA_DESCONTO;
                                           
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

       public void Deletar()
       {
           try
           {
               SqlCommand cmd = new SqlCommand("DELETE FROM Parcelas_Pagar WHERE PCA_CARNE = @PCA_CARNE AND PCA_ITEM = @PCA_ITEM ", this.con);
               cmd.CommandType = CommandType.Text;
               cmd.Parameters.Add("@PCA_CARNE", SqlDbType.Int);
               cmd.Parameters[0].Value = this._PCA_CARNE;
               cmd.Parameters.Add("@PCA_ITEM", SqlDbType.Int);
               cmd.Parameters[1].Value = this._PCA_ITEM;

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
        #endregion
    }
}
