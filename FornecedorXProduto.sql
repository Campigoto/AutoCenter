SELECT     Produto.PRO_CODIGO, Produto.PRO_GRUPO, Produto.PRO_SUBGRUPO, Produto.PRO_NOME, Fornecedor.FOR_CODIGO, Fornecedor.FOR_NOME, 
                      Produtos_Compra.PC_QTDE, Produtos_Compra.PC_PRECO_COMPRA, Historico_Estoque_Preco.HEP_DATA, Subgrupo_Produto.SGP_NOME, 
                      Grupo_Produto.GRP_NOME
FROM         Fornecedor INNER JOIN
                      Compra ON Fornecedor.FOR_CODIGO = Compra.COM_FORNECEDOR INNER JOIN
                      Grupo_Produto INNER JOIN
                      Produto ON Grupo_Produto.GRP_CODIGO = Produto.PRO_GRUPO INNER JOIN
                      Subgrupo_Produto ON Produto.PRO_SUBGRUPO = Subgrupo_Produto.SGP_CODIGO AND Produto.PRO_GRUPO = Subgrupo_Produto.SGP_GRUPO INNER JOIN
                      Produtos_Compra ON Produto.PRO_CODIGO = Produtos_Compra.PC_PRODUTO INNER JOIN
                      Historico_Estoque_Preco ON Produto.PRO_CODIGO = Historico_Estoque_Preco.HEP_PRODUTO AND 
                      Produtos_Compra.PC_COMPRA = Historico_Estoque_Preco.HEP_COMPRA ON Compra.COM_CODIGO = Produtos_Compra.PC_COMPRA