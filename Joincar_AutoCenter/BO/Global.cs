using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
    public static class Global
    {
        #region Fields
        private static int _FUN_CODIGO = 0;
        private static bool _CAD_CIDADE = false;
        private static bool _CAD_PRODUTO = false;
        private static bool _CAD_GRUPO = false;
        private static bool _CAD_SUBGRUPO = false;
        private static bool _CAD_HISTORICO = false;
        private static bool _CAD_CLIENTE = false;
        private static bool _CAD_FORNECEDOR = false;
        private static bool _CAD_HIST_LANCAMENTO = false;
        private static bool _CAD_ESTOQUE = false;
        private static bool _MOV_CONTAS_PAGAR = false;
        private static bool _MOV_CHEQUE_PAGAR = false;
        private static bool _MOV_PAGAMENTO = false;
        private static bool _MOV_COMPRA = false;
        private static bool _REL_PRODUTO = false;
        private static bool _REL_CONTAS_PAGAR = false;
        private static bool _REL_COMPRA = false;
        private static bool _REL_LOG = false;
        private static bool _UTI_FUNCIONARIO = false;
        private static string _FUN_NOME = "";
        private static int _PRO_CODIGO = 0;
        private static int _FOR_CODIGO = 0;
        private static int _CLI_CODIGO = 0;
        private static int _PC_PRODUTO = 0;
        private static int _HEP_PRODUTO = 0;
        #endregion

        #region Properties
        public static int PC_PRODUTO
        {
            get { return _PC_PRODUTO; }
            set { _PC_PRODUTO = value; }
        }

        public static bool CAD_ESTOQUE
        {
            get { return _CAD_ESTOQUE; }
            set { _CAD_ESTOQUE = value; }
        }

        public static int HEP_PRODUTO
        {
            get { return _HEP_PRODUTO; }
            set { _HEP_PRODUTO = value; }
        }

        public static int CLI_CODIGO
        {
            get { return _CLI_CODIGO; }
            set { _CLI_CODIGO = value; }
        }

        public static int PRO_CODIGO
        {
            get { return _PRO_CODIGO; }
            set { _PRO_CODIGO = value; }
        }

        public static int FOR_CODIGO
        {
            get { return _FOR_CODIGO; }
            set { _FOR_CODIGO = value; }
        }

        public static int FUN_CODIGO
        {
            get { return _FUN_CODIGO; }
            set { _FUN_CODIGO = value; }
        }

        public static bool CAD_CIDADE
        {
            get { return _CAD_CIDADE; }
            set { _CAD_CIDADE = value; }
        }

        public static bool CAD_PRODUTO
        {
            get { return _CAD_PRODUTO; }
            set { _CAD_PRODUTO = value; }
        }

        public static bool CAD_GRUPO
        {
            get { return _CAD_GRUPO; }
            set { _CAD_GRUPO = value; }
        }

        public static bool CAD_SUBGRUPO
        {
            get { return _CAD_SUBGRUPO; }
            set { _CAD_SUBGRUPO = value; }
        }

        public static bool CAD_HISTORICO
        {
            get { return _CAD_HISTORICO; }
            set { _CAD_HISTORICO = value; }
        }

        public static bool CAD_CLIENTE
        {
            get { return _CAD_CLIENTE; }
            set { _CAD_CLIENTE = value; }
        }

        public static bool CAD_FORNECEDOR
        {
            get { return _CAD_FORNECEDOR; }
            set { _CAD_FORNECEDOR = value; }
        }

        public static bool CAD_HIST_LANCAMENTO
        {
            get { return _CAD_HIST_LANCAMENTO; }
            set { _CAD_HIST_LANCAMENTO = value; }
        }

        public static bool MOV_CONTAS_PAGAR
        {
            get { return _MOV_CONTAS_PAGAR; }
            set { _MOV_CONTAS_PAGAR = value; }
        }

        public static bool MOV_CHEQUE_PAGAR
        {
            get { return _MOV_CHEQUE_PAGAR; }
            set { _MOV_CHEQUE_PAGAR = value; }
        }

        public static bool MOV_PAGAMENTO
        {
            get { return _MOV_PAGAMENTO; }
            set { _MOV_PAGAMENTO = value; }
        }

        public static bool MOV_COMPRA
        {
            get { return _MOV_COMPRA; }
            set { _MOV_COMPRA = value; }
        }

        public static bool REL_PRODUTO
        {
            get { return _REL_PRODUTO; }
            set { _REL_PRODUTO = value; }
        }

        public static bool REL_CONTAS_PAGAR
        {
            get { return _REL_CONTAS_PAGAR; }
            set { _REL_CONTAS_PAGAR = value; }
        }

        public static bool REL_COMPRA
        {
            get { return _REL_COMPRA; }
            set { _REL_COMPRA = value; }
        }

        public static bool REL_LOG
        {
            get { return _REL_LOG; }
            set { _REL_LOG = value; }
        }

        public static bool UTI_FUNCIONARIO
        {
            get { return _UTI_FUNCIONARIO; }
            set { _UTI_FUNCIONARIO = value; }
        }

        public static string FUN_NOME
        {
            get { return _FUN_NOME; }
            set { _FUN_NOME = value; }
        }
        #endregion
    }
}
