using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BO
{
    public class Produto
    {
        #region Fields
        private int      _PRO_CODIGO = 0;
        private GrupoProduto _PRO_GRUPO;                                                                                                       
        private int      _PRO_INATIVO;                                                           
        private int      _PRO_ULT_COMPRA;                                                       
        private string   _PRO_NOME;                                                         
        private string   _PRO_REFERENCIA;
        private string   _PRO_UNIDADE;                                                                                                                     
        private string   _PRO_OBS;
        private float _PRO_PRECO_COMPRA;                                                            
        private float    _PRO_ESTOQUE;
        private float    _PRO_EST_MINIMO;
        private SubGrupo_Produtos _PRO_SUBGRUPO;


        private float _PRO_PRECO_VENDA;
        private  float  _PRO_PRECO_VALOR;
        private  float  _PRO_PERCENTUAL_GANHO;
        private  float  _PRO_PERCENTUAL_IND_FABRICA;
        private  float  _PRO_PRECO_TABELA;
        private  float  _PRO_PERCENTUAL_ABATE;
        private  string _PRO_CODIGO_ORIGINAL1;
        private  string _PRO_CODIGO_ORIGINAL;
        private  float _PRO_QTDADE_ULT_ENTR;
        private  string _PRO_DESCRICAO_LOCAL;
        private  int   _PRO_ULTIMO_FORNECEDOR;
      
        private string   _GRP_NOME;
        private string _SGP_NOME;   
        private DateTime _COM_DATA = DateTime.Parse("01/01/1800");
        //Usado meramente para atualizar o estoque
        private float _PRO_EST_ATUAL = 0;
        private StringBuilder _sb;                                                                                         
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        private ProdutoLoadType _typeLoad;                                                                                         
        #endregion                                                                                                         
                                                                                                                           
        #region Properties
        public int PRO_CODIGO
        {                                                                                                                  
            get { return _PRO_CODIGO; }                                                                                    
            set { _PRO_CODIGO = value; }                                                                                     
        }                                                                                                    
                                                             
        public int PRO_INATIVO
        {                                                                          
            get { return _PRO_INATIVO; }                                           
            set { _PRO_INATIVO = value; }                                              
        }                                                                              

        public int PRO_ULT_COMPRA
        {                                                                              
            get { return _PRO_ULT_COMPRA; }                                                
            set { _PRO_ULT_COMPRA = value; }                                               
        }                                                                                 
                                                                          
        public string PRO_REFERENCIA
        {                                                                                 
            get { return _PRO_REFERENCIA; }                                                      
            set { _PRO_REFERENCIA = value; }                                                     
        }                                                                                 
                                                                
        public string PRO_NOME
        {                                                                                          
            get { return _PRO_NOME; }                                                                
            set { _PRO_NOME = value; }                                                                    
        }                                                                                                
                                                                                                         
        public string PRO_UNIDADE
        {                                                                                                
            get { return _PRO_UNIDADE; }                                                                
            set 
            {
                if (value.Length > 6)
                {
                    _PRO_UNIDADE = value.Substring(0, 6); 
                }
                else
                {
                    _PRO_UNIDADE = value; 
                }
            }                                                               
        }

        public float PRO_PRECO_COMPRA
        {                                                                                                
            get { return _PRO_PRECO_COMPRA; }                                                                  
            set { _PRO_PRECO_COMPRA = value; }                                                                 
        }

        public string PRO_PRECO_COMPRA_FORMATADO
        {
            get { return _PRO_PRECO_COMPRA.ToString("0.000"); }
        }
        public float PRO_PRECO_VENDA
        {
            get { return _PRO_PRECO_VENDA; }
            set { _PRO_PRECO_VENDA = value; }
        }

        public string PRO_PRECO_VENDA_FORMATADO
        {
            get { return _PRO_PRECO_VENDA.ToString("0.000"); }
        }
        public float PRO_ESTOQUE
        {                                                                            
            get { return _PRO_ESTOQUE; }                                          
            set { _PRO_ESTOQUE = value; }                                                             
        }

        public string PRO_ESTOQUE_FORMATADO
        {
            get { return _PRO_ESTOQUE.ToString("0.000"); }
        }

        public string PRO_EST_ATUAL
        {
            get { return _PRO_EST_ATUAL.ToString("0.000"); }
            set { _PRO_EST_ATUAL = float.Parse(value); }
        }
                                                                       
        public float PRO_EST_MINIMO
        {                                                                                       
            get { return _PRO_EST_MINIMO; }                                                        
            set { _PRO_EST_MINIMO = value; }                                                                                 
        }                                                                                       
                                                                                                              
        public string PRO_OBS
        {                                                                                                                     
            get { return _PRO_OBS; }                                                                                          
            set { _PRO_OBS = value; }                                                                                         
        }

        public SubGrupo_Produtos PRO_SUBGRUPO
        {
            get { return _PRO_SUBGRUPO; }
            set { _PRO_SUBGRUPO = value;}
        }

        public int PRO_SUBGRUPO_SGP_CODIGO
            {
                get { return _PRO_SUBGRUPO.SGP_CODIGO; }
            }

        public int PRO_SUBGRUPO_SGP_ID
            {
                get { return _PRO_SUBGRUPO.SGP_ID; }
            }

        public string PRO_SUBGRUPO_SGP_NOME
            {
                get { return _PRO_SUBGRUPO.SGP_NOME; }
            }

        public GrupoProduto PRO_GRUPO
        {
            get { return _PRO_GRUPO; }
            set { _PRO_GRUPO = value; }
        }

        public int PRO_GRUPO_GRP_CODIGO
        {
            get { return _PRO_GRUPO.GRP_CODIGO; }
        }
       
        public string PRO_GRUPO_GRP_NOME
        {
            get { return _PRO_GRUPO.GRP_NOME; }
        }

        public string COM_DATA_FORMATADA
        {
            get 
            {
                if (_COM_DATA.ToString("dd/MM/yyyy") != "01/01/1800")
                {
                    return _COM_DATA.ToString("dd/MM/yyyy");
                }
                else
                {
                    return "";
                }
            }
        }                                                                                                            
        public string GRP_NOME
        {                                                                                 
            get { return _GRP_NOME; }                                                      
            set { _GRP_NOME = value; }                                                     
        }
        public string SGP_NOME
        {
            get { return _SGP_NOME; }
            set { _SGP_NOME = value; }
        } 
      
         public float PRO_PRECO_VALOR 
        {
            get { return _PRO_PRECO_VALOR; }
              set {_PRO_PRECO_VALOR = value;}
         }
         public string _PRO_PRECO_VALOR_FORMATADO
         {
             get { return _PRO_PRECO_VALOR.ToString("00.000"); }
         }
        public float PRO_PERCENTUAL_GANHO
        {
            get{return _PRO_PERCENTUAL_GANHO;}
            set {_PRO_PERCENTUAL_GANHO = value;}
        }
        public string _PRO_PERCENTUAL_GANHO_FORMATADO
        {
            get { return _PRO_PERCENTUAL_GANHO.ToString("00.000"); }
        }
        public float PRO_PERCENTUAL_IND_FABRICA
        {
            get {return _PRO_PERCENTUAL_IND_FABRICA;}
            set { _PRO_PERCENTUAL_IND_FABRICA = value;}
        }
        public string _PRO_PERCENTUAL_IND_FABRICA_FORMATADO
        {
            get { return _PRO_PERCENTUAL_IND_FABRICA.ToString("00.000"); }
        }
        public float PRO_PRECO_TABELA
        {
            get {return _PRO_PRECO_TABELA;}
            set {_PRO_PRECO_TABELA = value;}
        }
        public string _PRO_PRECO_TABELA_FORMATADO
        {
            get { return _PRO_PRECO_TABELA.ToString("00.000"); }
        }
        public float PRO_PERCENTUAL_ABATE
        {
           get {return _PRO_PERCENTUAL_ABATE;}
            set { _PRO_PERCENTUAL_ABATE = value; }
        }
        public string _PRO_PERCENTUAL_ABATE_FORMATADO
        {
            get { return _PRO_PERCENTUAL_ABATE.ToString("00.000"); }
        }
        public string PRO_CODIGO_ORIGINAL1
        {
           get {return _PRO_CODIGO_ORIGINAL1 ;}
           set { _PRO_CODIGO_ORIGINAL1 = value;}
        }
        public string PRO_CODIGO_ORIGINAL
        {
           get {return _PRO_CODIGO_ORIGINAL ;}
           set { _PRO_CODIGO_ORIGINAL = value;}
        }
        public float PRO_QTDADE_ULT_ENTR
        {
           get {return _PRO_QTDADE_ULT_ENTR ;}
           set { _PRO_QTDADE_ULT_ENTR = value;}
        }
        public string _PRO_QTDADE_ULT_ENTR_FORMATADO
        {
            get { return _PRO_QTDADE_ULT_ENTR.ToString("0.000"); }
        }
        public string PRO_DESCRICAO_LOCAL
        {
           get {return _PRO_DESCRICAO_LOCAL ;}
           set { _PRO_DESCRICAO_LOCAL = value;}
        }
        public int PRO_ULTIMO_FORNECEDOR
        {
            get { return _PRO_ULTIMO_FORNECEDOR; }
            set { _PRO_ULTIMO_FORNECEDOR  = value; }
        }


        float WPr_Vlr, WPr_perc_ganho, WPr_vend, mDesc, WPR_liq, WPr_Abat;
        public float PRO_PRECO_LIQ
        {
            get
            {
                WPr_perc_ganho = PRO_PERCENTUAL_GANHO;
                WPr_Vlr = PRO_PRECO_COMPRA;
                WPr_vend = (WPr_Vlr * (1 + (WPr_perc_ganho / 100)));
                WPr_Abat = PRO_PERCENTUAL_ABATE;
                mDesc = WPr_vend * (WPr_Abat / 100);
                WPR_liq = WPr_vend - mDesc;
                return WPR_liq;
            }
        }

        public string PRO_PRECO_LIQ_FORMATADO
        {
            get { return PRO_PRECO_LIQ.ToString("00.000"); }
        }

        #endregion                                                                                      
                                                                                                             
        #region Constructors
        public Produto() { }                                                                                 
                                                                                                             
        public Produto(int PRO_CODIGO)                                                                                  
        {
            this._PRO_CODIGO = PRO_CODIGO;
            this._typeLoad = ProdutoLoadType.LoadById;  
            this.Load();                                                                                 
        }

        public Produto(string PRO_NOME)
        {
          this._PRO_NOME = PRO_NOME;
        }

        public Produto(int PRO_CODIGO,
            int    PRO_GRUPO,
            int    PRO_INATIVO,
            int    PRO_ULT_COMPRA,
            string PRO_NOME,
            string PRO_REFERENCIA,
            string PRO_UNIDADE,
            string PRO_OBS,
            float  PRO_PRECO_COMPRA,
            float  PRO_ESTOQUE,
            float  PRO_EST_MINIMO,
            int    PRO_SUBGRUPO,
            DateTime COM_DATA,
            float _PRO_PRECO_VENDA,
            float PRO_PRECO_VALOR,
            float PRO_PERCENTUAL_GANHO,
            float PRO_PERCENTUAL_IND_FABRICA,
            float PRO_PRECO_TABELA,
            float PRO_PERCENTUAL_ABATE,
            string PRO_CODIGO_ORIGINAL1,
            string PRO_CODIGO_ORIGINAL,
            float PRO_QTDADE_ULT_ENTR,
            string PRO_DESCRICAO_LOCAL,
            int PRO_ULTIMO_FORNECEDOR)
        {
            this._PRO_CODIGO      = PRO_CODIGO;
            this._PRO_GRUPO       = new GrupoProduto(PRO_GRUPO);
            this._PRO_INATIVO     = PRO_INATIVO;
            this._PRO_ULT_COMPRA  = PRO_ULT_COMPRA;
            this._PRO_NOME        = PRO_NOME;
            this._PRO_REFERENCIA  = PRO_REFERENCIA;
            this._PRO_UNIDADE     = PRO_UNIDADE;
            this._PRO_OBS         = PRO_OBS;
            this._PRO_PRECO_COMPRA= PRO_PRECO_COMPRA;
            this._PRO_ESTOQUE     = PRO_ESTOQUE;
            this._PRO_EST_MINIMO  = PRO_EST_MINIMO;
            this._PRO_SUBGRUPO = new SubGrupo_Produtos(PRO_SUBGRUPO, PRO_GRUPO);
            this._COM_DATA = COM_DATA;
            this._PRO_PRECO_VENDA = PRO_PRECO_VENDA;
            this._PRO_PRECO_VALOR = PRO_PRECO_VALOR;
            this._PRO_PERCENTUAL_GANHO = PRO_PERCENTUAL_GANHO;
            this._PRO_PERCENTUAL_IND_FABRICA = PRO_PERCENTUAL_IND_FABRICA;
            this._PRO_PRECO_TABELA = PRO_PRECO_TABELA;
            this._PRO_PERCENTUAL_ABATE = PRO_PERCENTUAL_ABATE;
            this._PRO_CODIGO_ORIGINAL1 = PRO_CODIGO_ORIGINAL1;
            this._PRO_CODIGO_ORIGINAL = PRO_CODIGO_ORIGINAL;
            this._PRO_QTDADE_ULT_ENTR = PRO_QTDADE_ULT_ENTR;
            this._PRO_DESCRICAO_LOCAL = PRO_DESCRICAO_LOCAL;
            this._PRO_ULTIMO_FORNECEDOR = PRO_ULTIMO_FORNECEDOR;
        }

        //Pesquisa
        public Produto(
            int PRO_CODIGO,
            int PRO_GRUPO,
            string GRP_NOME,
            int PRO_INATIVO,
            int PRO_ULT_COMPRA,
            string PRO_NOME,
            string PRO_REFERENCIA,
            string PRO_UNIDADE,
            string PRO_OBS,
            float PRO_PRECO_COMPRA,
            float PRO_ESTOQUE,
            float PRO_EST_MINIMO,
            int PRO_SUBGRUPO,
            string SGP_NOME,
            DateTime COM_DATA,
            float PRO_PRECO_VENDA,
            float PRO_PRECO_VALOR,
            float  PRO_PERCENTUAL_GANHO,
            float  PRO_PERCENTUAL_IND_FABRICA,
            float  PRO_PRECO_TABELA,
            float  PRO_PERCENTUAL_ABATE,
            string PRO_CODIGO_ORIGINAL1,
            string PRO_CODIGO_ORIGINAL,
            float  PRO_QTDADE_ULT_ENTR,
            string PRO_DESCRICAO_LOCAL,
            int    PRO_ULTIMO_FORNECEDOR)
        {
            this._PRO_CODIGO                = PRO_CODIGO;
            this._GRP_NOME                  = GRP_NOME;
            this._PRO_INATIVO               = PRO_INATIVO;
            this._PRO_ULT_COMPRA            = PRO_ULT_COMPRA;
            this._PRO_NOME                  = PRO_NOME;
            this._PRO_REFERENCIA            = PRO_REFERENCIA;
            this._PRO_UNIDADE               = PRO_UNIDADE;
            this._PRO_OBS                   = PRO_OBS;
            this._PRO_PRECO_COMPRA          = PRO_PRECO_COMPRA;
            this._PRO_ESTOQUE               = PRO_ESTOQUE;
            this._PRO_EST_MINIMO            = PRO_EST_MINIMO;
            this._SGP_NOME                  = SGP_NOME;
            this._COM_DATA                  = COM_DATA;
            this._PRO_PRECO_VENDA           = PRO_PRECO_VENDA ;
            this._PRO_PRECO_VALOR           = PRO_PRECO_VALOR      ;
            this._PRO_PERCENTUAL_GANHO      = PRO_PERCENTUAL_GANHO      ;
            this._PRO_PERCENTUAL_IND_FABRICA= PRO_PERCENTUAL_IND_FABRICA;
            this._PRO_PRECO_TABELA     = PRO_PRECO_TABELA     ;
            this._PRO_PERCENTUAL_ABATE      = PRO_PERCENTUAL_ABATE      ;
            this._PRO_CODIGO_ORIGINAL1      = PRO_CODIGO_ORIGINAL1      ;
            this._PRO_CODIGO_ORIGINAL       = PRO_CODIGO_ORIGINAL    ;
            this._PRO_QTDADE_ULT_ENTR       = PRO_QTDADE_ULT_ENTR    ;
            this._PRO_DESCRICAO_LOCAL       = PRO_DESCRICAO_LOCAL    ;
            this._PRO_ULTIMO_FORNECEDOR     = PRO_ULTIMO_FORNECEDOR  ;
        }
        
        #endregion                                                                                                                       
                                                                                                                                         
        #region Methods
        public static bool Verificar_Produto(int PRO_CODIGO)                                                                             
        {                                                                                                                                
            SqlConnection static_conn = new SqlConnection(Connection.ConnectionString);                                                  
            SqlCommand static_cmd;                                                                                                       
            StringBuilder sb = new StringBuilder();                                                                                      
                                                                                                                                         
         try                                                                                                                             
            {
                sb.Append("SELECT PRO_CODIGO, PRO_GRUPO,PRO_INATIVO,PRO_ULT_COMPRA,PRO_NOME,PRO_REFERENCIA,PRO_UNIDADE,PRO_OBS,PRO_PRECO_COMPRA ,PRO_ESTOQUE,PRO_EST_MINIMO,PRO_SUBGRUPO FROM Produto ");
                sb.Append("WHERE (PRO_CODIGO = @PRO_CODIGO) ");                                                                    
                static_cmd = new SqlCommand(sb.ToString(), static_conn);                                                                                         
                static_cmd.CommandType = CommandType.Text;                                                                                                       
                static_cmd.Parameters.Add("@PRO_CODIGO", SqlDbType.Int);                                                                                         
                static_cmd.Parameters[0].Value = PRO_CODIGO;                                                                                                     
                                                                                                                                                                 
                static_conn.Open();                                                                                                                              
                SqlDataReader dr = static_cmd.ExecuteReader();                                                                                                   
                if (dr.HasRows)                                                                                                                                  
                {                                                                                                                                                
                    dr.Read();                                                                                                                                   
                    if (dr.GetInt32(0) > 0)                                                                                                                      
                    {
                        return true;
                    }
                    else                                                                                                                                         
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (static_conn.State == ConnectionState.Open) static_conn.Close();
            }
        } //  0 PRO_GRUPO, 1 - PRO_INATIVO, 2 - PRO_ULT_COMPRA, 3 - PRO_NOME, 4 - PRO_REFERENCIA, 5 - PRO_UNIDADE, 6 - PRO_OBS, 7 - PRO_PRECO_COMPRA ,
        //  8 - PRO_ESTOQUE , 9 - PRO_EST_MINIMO, 10 - PRO_SUBGRUPO, 11 - PRO_PRECO_VENDA, 12 - PRO_PRECO_VALOR, 13 - PRO_PERCENTUAL_GANHO, 14 - PRO_PERCENTUAL_IND_FABRICA,
        // 15 - PRO_PRECO_TABELA, 16 - PRO_PERCENTUAL_ABATE, 17 - PRO_CODIGO_ORIGINAL1, 18 - PRO_CODIGO_ORIGINAL,
        // 19 - PRO_QTDADE_ULT_ENTR, 20 - PRO_DESCRICAO_LOCAL, 21 - PRO_ULTIMO_FORNECEDOR 

        public void Salvar()
        {
            try
            {
                this._sb = new StringBuilder();
                if (this.PRO_CODIGO == 0)
                {
                    this._sb.Append("INSERT INTO Produto ( PRO_GRUPO, PRO_INATIVO, PRO_ULT_COMPRA, PRO_NOME, PRO_REFERENCIA, PRO_UNIDADE, PRO_OBS, PRO_PRECO_COMPRA, ");
                    this._sb.Append("PRO_ESTOQUE, PRO_EST_MINIMO,PRO_SUBGRUPO,PRO_PRECO_VENDA,PRO_PRECO_VALOR,PRO_PERCENTUAL_GANHO,PRO_PERCENTUAL_IND_FABRICA,");
                    this._sb.Append("PRO_PRECO_TABELA,PRO_PERCENTUAL_ABATE,PRO_CODIGO_ORIGINAL1,PRO_CODIGO_ORIGINAL,PRO_QTDADE_ULT_ENTR,PRO_DESCRICAO_LOCAL,PRO_ULTIMO_FORNECEDOR)");
                    this._sb.Append("VALUES ( @PRO_GRUPO,@PRO_INATIVO,@PRO_ULT_COMPRA,@PRO_NOME,@PRO_REFERENCIA,@PRO_UNIDADE,@PRO_OBS,@PRO_PRECO_COMPRA,@PRO_ESTOQUE,@PRO_EST_MINIMO,@PRO_SUBGRUPO,");
                    this._sb.Append("@PRO_PRECO_VENDA, @PRO_PRECO_VALOR, @PRO_PERCENTUAL_GANHO, @PRO_PERCENTUAL_IND_FABRICA, ");
                    this._sb.Append("@PRO_PRECO_TABELA,@PRO_PERCENTUAL_ABATE,@PRO_CODIGO_ORIGINAL1,@PRO_CODIGO_ORIGINAL,@PRO_QTDADE_ULT_ENTR,@PRO_DESCRICAO_LOCAL,@PRO_ULTIMO_FORNECEDOR) ");
                    this._sb.Append("SET @PRO_CODIGO = @@IDENTITY ");
                }
                else
                {

                    this._sb.Append("UPDATE Produto SET PRO_GRUPO=@PRO_GRUPO, PRO_INATIVO=@PRO_INATIVO, PRO_ULT_COMPRA=@PRO_ULT_COMPRA, PRO_NOME=@PRO_NOME, PRO_REFERENCIA=@PRO_REFERENCIA,");
                    this._sb.Append("PRO_UNIDADE=@PRO_UNIDADE, PRO_OBS=@PRO_OBS, PRO_PRECO_COMPRA=@PRO_PRECO_COMPRA ,PRO_ESTOQUE=@PRO_ESTOQUE, PRO_EST_MINIMO=@PRO_EST_MINIMO,PRO_SUBGRUPO=@PRO_SUBGRUPO,");
                    this._sb.Append("PRO_PRECO_VENDA=@PRO_PRECO_VENDA, PRO_PRECO_VALOR=@PRO_PRECO_VALOR,PRO_PERCENTUAL_GANHO=@PRO_PERCENTUAL_GANHO, PRO_PERCENTUAL_IND_FABRICA=@PRO_PERCENTUAL_IND_FABRICA,");
                    this._sb.Append("PRO_PRECO_TABELA=@PRO_PRECO_TABELA,PRO_PERCENTUAL_ABATE=@PRO_PERCENTUAL_ABATE,PRO_CODIGO_ORIGINAL1=@PRO_CODIGO_ORIGINAL1,PRO_CODIGO_ORIGINAL=@PRO_CODIGO_ORIGINAL,");
                    this._sb.Append("PRO_QTDADE_ULT_ENTR=@PRO_QTDADE_ULT_ENTR,PRO_DESCRICAO_LOCAL=@PRO_DESCRICAO_LOCAL,PRO_ULTIMO_FORNECEDOR=@PRO_ULTIMO_FORNECEDOR ");
                    this._sb.Append("WHERE PRO_CODIGO=@PRO_CODIGO");
                }
                    
                this.cmd = new SqlCommand(this._sb.ToString(), this.con);                                       
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@PRO_CODIGO", SqlDbType.Int);                                       ///* 0 - PRO_CODIGO
                this.cmd.Parameters[0].Value = PRO_CODIGO;                                                   // * 1 - PRO_GRUPO, 
                this.cmd.Parameters[0].Direction = ParameterDirection.InputOutput;                           // * 2 - PRO_INATIVO,
                                                                                                             // * 3 - PRO_ULT_COMPRA,
                this.cmd.Parameters.Add("@PRO_GRUPO", SqlDbType.Int);                                        // * 4 - PRO_NOME,
                this.cmd.Parameters[1].Value = PRO_GRUPO.GRP_CODIGO;                                         // * 5 - PRO_REFERENCIA,
                                                                                                             // * 6 - PRO_UNIDADE,
                this.cmd.Parameters.Add("@PRO_INATIVO", SqlDbType.Int);                                      // * 7 - PRO_OBS,
                this.cmd.Parameters[2].Value = PRO_INATIVO;                                                  // * 8 - PRO_PRECO_COMPRA ,
                                                                                                             //   9 - PRO_ESTOQUE ,
                this.cmd.Parameters.Add("@PRO_ULT_COMPRA", SqlDbType.Int);                                   // * 10- PRO_EST_MINIMO,
                this.cmd.Parameters[3].Value = PRO_ULT_COMPRA;                                               // * 11 - PRO_SUBGRUPO,
                                                                                                             // * 12 - PRO_PRECO_VENDA,
                this.cmd.Parameters.Add("@PRO_NOME", SqlDbType.VarChar);                                     // * 13 - PRO_PRECO_VALOR,
                this.cmd.Parameters[4].Value = PRO_NOME;                                                     // * 14 - PRO_PERCENTUAL_GANHO,
                                                                                                             // * 15 - PRO_PERCENTUAL_IND_FABRICA,
                this.cmd.Parameters.Add("@PRO_REFERENCIA", SqlDbType.VarChar);                               //// 16 - PRO_PRECO_TABELA,
                this.cmd.Parameters[5].Value = PRO_REFERENCIA;                                               // * 17 - PRO_PERCENTUAL_ABATE,
                                                                                                             // * 18 - PRO_CODIGO_ORIGINAL1,
                this.cmd.Parameters.Add("@PRO_UNIDADE", SqlDbType.VarChar);                                  // * 19 - PRO_CODIGO_ORIGINAL,
                this.cmd.Parameters[6].Value = PRO_UNIDADE;                                                  //// 20 - PRO_QTDADE_ULT_ENTR,
                                                                                                             // * 21 - PRO_DESCRICAO_LOCAL,
                this.cmd.Parameters.Add("@PRO_OBS", SqlDbType.Text);                                         // * 22 - PRO_ULTIMO_FORNECEDOR 
                this.cmd.Parameters[7].Value = PRO_OBS;                                                      //*/
 
                this.cmd.Parameters.Add("@PRO_PRECO_COMPRA", SqlDbType.Float);
                this.cmd.Parameters[8].Value = PRO_PRECO_COMPRA;             
 
                this.cmd.Parameters.Add("@PRO_ESTOQUE", SqlDbType.Float);     
                this.cmd.Parameters[9].Value = PRO_ESTOQUE;                   

                this.cmd.Parameters.Add("@PRO_EST_MINIMO", SqlDbType.Float);  
                this.cmd.Parameters[10].Value = PRO_EST_MINIMO;               
                
                this.cmd.Parameters.Add("@PRO_SUBGRUPO", SqlDbType.Int);
                this.cmd.Parameters[11].Value = PRO_SUBGRUPO.SGP_CODIGO;

                this.cmd.Parameters.Add("@PRO_PRECO_VENDA", SqlDbType.Float);
                this.cmd.Parameters[12].Value = PRO_PRECO_VENDA;

                this.cmd.Parameters.Add("@PRO_PRECO_VALOR", SqlDbType.Float);
                this.cmd.Parameters[13].Value = PRO_PRECO_VALOR;

                this.cmd.Parameters.Add("@PRO_PERCENTUAL_GANHO", SqlDbType.Float);
                this.cmd.Parameters[14].Value = PRO_PERCENTUAL_GANHO;

                this.cmd.Parameters.Add("@PRO_PERCENTUAL_IND_FABRICA", SqlDbType.Float);
                this.cmd.Parameters[15].Value = PRO_PERCENTUAL_IND_FABRICA;

                this.cmd.Parameters.Add("@PRO_PRECO_TABELA", SqlDbType.Float);
                this.cmd.Parameters[16].Value = PRO_PRECO_TABELA;

                this.cmd.Parameters.Add("@PRO_PERCENTUAL_ABATE", SqlDbType.Float);
                this.cmd.Parameters[17].Value = PRO_PERCENTUAL_ABATE;

                this.cmd.Parameters.Add("@PRO_CODIGO_ORIGINAL1", SqlDbType.VarChar);
                this.cmd.Parameters[18].Value = PRO_CODIGO_ORIGINAL1;

                this.cmd.Parameters.Add("@PRO_CODIGO_ORIGINAL", SqlDbType.VarChar);
                this.cmd.Parameters[19].Value = PRO_CODIGO_ORIGINAL;

                this.cmd.Parameters.Add("@PRO_QTDADE_ULT_ENTR", SqlDbType.VarChar);
                this.cmd.Parameters[20].Value = PRO_QTDADE_ULT_ENTR;

                this.cmd.Parameters.Add("@PRO_DESCRICAO_LOCAL", SqlDbType.VarChar);
                this.cmd.Parameters[21].Value = PRO_DESCRICAO_LOCAL;

                this.cmd.Parameters.Add("@PRO_ULTIMO_FORNECEDOR", SqlDbType.Int);
                this.cmd.Parameters[22].Value = PRO_ULTIMO_FORNECEDOR;

                this.con.Open();                                                  
                if (cmd.ExecuteNonQuery() > 0)
                {
                    this._PRO_CODIGO = int.Parse(cmd.Parameters[0].Value.ToString());
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

        public void Deletar(int PRO_CODIGO)
        {
            try
            {
                this.cmd = new SqlCommand("DELETE FROM Produto WHERE PRO_CODIGO = @PRO_CODIGO", this.con);
                this.cmd.CommandType = CommandType.Text;

                this.cmd.Parameters.Add("@PRO_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = PRO_CODIGO;

                this.con.Open();
                this.cmd.ExecuteNonQuery();
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

        private void Load()
        {
            try
            {
                switch (this._typeLoad)
                {

                    case ProdutoLoadType.LoadById:
                        this.cmd = new SqlCommand("SELECT PRO_CODIGO, PRO_GRUPO,PRO_INATIVO,PRO_ULT_COMPRA,PRO_NOME,PRO_REFERENCIA,PRO_UNIDADE,PRO_OBS,PRO_PRECO_COMPRA ,PRO_ESTOQUE,PRO_EST_MINIMO,PRO_SUBGRUPO,PRO_PRECO_VENDA,PRO_PRECO_VALOR,PRO_PERCENTUAL_GANHO,PRO_PERCENTUAL_IND_FABRICA,PRO_PRECO_TABELA,PRO_PERCENTUAL_ABATE,PRO_CODIGO_ORIGINAL1,PRO_CODIGO_ORIGINAL,PRO_QTDADE_ULT_ENTR,PRO_DESCRICAO_LOCAL,PRO_ULTIMO_FORNECEDOR FROM Produto WHERE PRO_CODIGO = @PRO_CODIGO", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@PRO_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._PRO_CODIGO;
                        break;
                   
                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                  this._PRO_CODIGO        = dr.GetSqlInt32(0).Value;
                  try
                  {
                      this._PRO_GRUPO = new GrupoProduto(dr.GetSqlInt32(1).Value);
                  }
                  catch (Exception)
                  {
                      this._PRO_GRUPO = new GrupoProduto();
                  }
                    this._PRO_INATIVO       = dr.IsDBNull(2) ? 0 : dr.GetSqlInt32(2).Value;                     
                    this._PRO_ULT_COMPRA    = dr.IsDBNull(3) ? 0 : dr.GetSqlInt32(3).Value;                     
                    this._PRO_NOME          = dr.IsDBNull(4) ? "" : dr.GetSqlString(4).Value;                    
                    this._PRO_REFERENCIA    = dr.IsDBNull(5) ? "" : dr.GetSqlString(5).Value;                    
                    this._PRO_UNIDADE       = dr.IsDBNull(6) ? "" : dr.GetSqlString(6).Value;                    
                    this._PRO_OBS           = dr.IsDBNull(7) ? "" : dr.GetSqlString(7).Value;                    
                    this._PRO_PRECO_COMPRA  = dr.IsDBNull(8) ? 0 : float.Parse(dr.GetSqlDouble(8).ToString());  
                    this._PRO_ESTOQUE       = dr.IsDBNull(9) ? 0 : float.Parse(dr.GetSqlDouble(9).ToString());
                    this._PRO_EST_MINIMO    = dr.IsDBNull(10) ? 0 : float.Parse(dr.GetSqlDouble(10).ToString());
                  try
                  {
                      this._PRO_SUBGRUPO = new SubGrupo_Produtos(dr.GetSqlInt32(11).Value, dr.GetSqlInt32(1).Value);
                  }
                  catch (Exception)
                  {
                      this._PRO_SUBGRUPO = new SubGrupo_Produtos();
                  }
                   
                    this._PRO_PRECO_VENDA              = dr.IsDBNull(12) ? 0 : float.Parse(dr.GetSqlDouble(12).ToString());
                    this._PRO_PRECO_VALOR              = dr.IsDBNull(13) ? 0 : float.Parse(dr.GetSqlDouble(13).ToString());
                    this._PRO_PERCENTUAL_GANHO              = dr.IsDBNull(14) ? 0 : float.Parse(dr.GetSqlDouble(14).ToString());
                    this._PRO_PERCENTUAL_IND_FABRICA        = dr.IsDBNull(15) ? 0 : float.Parse(dr.GetSqlDouble(15).ToString());
                    this._PRO_PRECO_TABELA             = dr.IsDBNull(16) ? 0 : float.Parse(dr.GetSqlDouble(16).ToString());
                    this._PRO_PERCENTUAL_ABATE              = dr.IsDBNull(17) ? 0 : float.Parse(dr.GetSqlDouble(17).ToString());                    
                    this._PRO_CODIGO_ORIGINAL1              = dr.IsDBNull(18) ? "" : dr.GetSqlString(18).Value;                    
                    this._PRO_CODIGO_ORIGINAL               = dr.IsDBNull(19) ? "" : dr.GetSqlString(19).Value;
                    this._PRO_QTDADE_ULT_ENTR               = dr.IsDBNull(20) ? 0 : float.Parse(dr.GetSqlDouble(20).ToString());                     
                    this._PRO_DESCRICAO_LOCAL               = dr.IsDBNull(21) ? "" : dr.GetSqlString(21).Value;
                    this._PRO_ULTIMO_FORNECEDOR             = dr.IsDBNull(22) ? 0 :dr.GetSqlInt32(22).Value;

           //  0 - PRO_CODIGO, 1 - PRO_GRUPO, 2 - PRO_INATIVO, 3 - PRO_ULT_COMPRA, 4 - PRO_NOME, 5 - PRO_REFERENCIA, 6 - PRO_UNIDADE, 7 - PRO_OBS, 8 - PRO_PRECO_COMPRA ,
           //  9 - PRO_ESTOQUE , 10 - PRO_EST_MINIMO, 11 - PRO_SUBGRUPO, 12 - PRO_PERCENTUAL_VENDA, 13 - PRO_PERCENTUAL_VALOR, 14 - PRO_PERCENTUAL_GANHO, 15 - PRO_PERCENTUAL_IND_FABRICA,
           // 16 - PRO_PRECO_TABELA, 17 - PRO_PERCENTUAL_ABATE, 18 - PRO_CODIGO_ORIGINAL1, 19 - PRO_CODIGO_ORIGINAL,
           // 20 - PRO_QTDADE_ULT_ENTR, 21 - PRO_DESCRICAO_LOCAL, 22 - PRO_ULTIMO_FORNECEDOR 
                }
                else
                    this._PRO_CODIGO = 0;
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
/*    
          0  this._PRO_CODIGO      = PRO_CODIGO;
          1  this._PRO_GRUPO       = new GrupoProduto(PRO_GRUPO);
          2  this._PRO_INATIVO     = PRO_INATIVO;
          3  this._PRO_ULT_COMPRA  = PRO_ULT_COMPRA;
          4  this._PRO_NOME        = PRO_NOME;
          5  this._PRO_REFERENCIA  = PRO_REFERENCIA;
          6  this._PRO_UNIDADE     = PRO_UNIDADE;
          7  this._PRO_OBS         = PRO_OBS;
          8  this._PRO_PRECO_COMPRA= PRO_PRECO_COMPRA;
          9  this._PRO_ESTOQUE     = PRO_ESTOQUE;
          10  this._PRO_EST_ATUAL   = PRO_ESTOQUE;
          11  this._PRO_EST_MINIMO  = PRO_EST_MINIMO;
          12  this._PRO_SUBGRUPO = new SubGrupo_Produtos(PRO_SUBGRUPO, PRO_GRUPO);
          13 this._COM_DATA = COM_DATA;
float  PRO_PERCENTUAL_VENDA,          14  this._PRO_PRECO_VENDA = PRO_PERCENTUAL_VENDA;
float  PRO_PERCENTUAL_VALOR,          15  this._PRO_PRECO_VALOR = PRO_PERCENTUAL_VALOR;
float  PRO_PERCENTUAL_GANHO,          16  this._PRO_PERCENTUAL_GANHO = PRO_PERCENTUAL_GANHO;
float  PRO_PERCENTUAL_IND_FABRICA,    17  this._PRO_PERCENTUAL_IND_FABRICA = PRO_PERCENTUAL_IND_FABRICA;
float  PRO_PRECO_TABELA,         18 this._PRO_PRECO_TABELA = PRO_PRECO_TABELA;
float  PRO_PERCENTUAL_ABATE,          19  this._PRO_PERCENTUAL_ABATE = PRO_PERCENTUAL_ABATE;
string PRO_CODIGO_ORIGINAL1,          20  this._PRO_CODIGO_ORIGINAL1 = PRO_CODIGO_ORIGINAL1;
string PRO_CODIGO_ORIGINAL,           21  this._PRO_CODIGO_ORIGINAL = PRO_CODIGO_ORIGINAL;
float  PRO_QTDADE_ULT_ENTR,           22  this._PRO_QTDADE_ULT_ENTR = PRO_QTDADE_ULT_ENTR;
string PRO_DESCRICAO_LOCAL,           23 this._PRO_DESCRICAO_LOCAL = PRO_DESCRICAO_LOCAL;
int    PRO_ULTIMO_FORNECEDOR)         24  this._PRO_ULTIMO_FORNECEDOR = PRO_ULTIMO_FORNECEDOR;
*/