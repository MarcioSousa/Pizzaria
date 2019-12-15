Imports AcessoBD
Imports ObjetoTransferencia
Imports System.Data

Public Class ProdutoNegocios
    Dim AcessoSql As New AcessoDadosSql

    Public Function Inserir(ByVal vproduto As Produto) As String
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@nome_prod", vproduto.nome_prod)
            AcessoDadosSql.AdicionarParmetros("@preco_prod", vproduto.preco_prod)
            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoInserir").ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Alterar(ByVal vproduto As Produto) As String
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@cod_prod", vproduto.cod_prod)
            AcessoDadosSql.AdicionarParmetros("@nome_prod", vproduto.nome_prod)
            AcessoDadosSql.AdicionarParmetros("@preco_prod", vproduto.preco_prod)
            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoAlterar").ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Excluir(ByVal vproduto As Integer) As String
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@cod_prod", vproduto)
            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoExcluir").ToString()
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function ConsulaCompleta() As DataTable
        Try
            AcessoDadosSql.LimparParametros()
            Dim dataTableProduto As DataTable = AcessoDadosSql.ExecutarConsulta(CommandType.StoredProcedure, "uspProdutoConsultar")
            Return dataTableProduto
        Catch ex As Exception
            Throw New Exception("Não foi possível carregar seus Produtos. Detalhes: " & ex.Message)
        End Try
    End Function

End Class
