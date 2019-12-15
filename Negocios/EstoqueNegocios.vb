Imports AcessoBD
Imports ObjetoTransferencia
Imports System.Data

Public Class EstoqueNegocios
    '//Instânciar = criar um novo objeto baseado em um modelo
    Dim AcessoSql As New AcessoDadosSql

    Public Function Inserir(ByVal vestoque As Estoque) As String
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@codprod_est", vestoque.codprod_est)
            AcessoDadosSql.AdicionarParmetros("@qtde_est", vestoque.qtde_est)
            AcessoDadosSql.AdicionarParmetros("@data_est", vestoque.data_est)
            AcessoDadosSql.AdicionarParmetros("@venc_est", vestoque.venc_est)

            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspEstoqueInserir").ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Alterar(ByVal vestoque As Estoque) As String
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@cod_est", vestoque.cod_est)
            AcessoDadosSql.AdicionarParmetros("@codprod_est", vestoque.codprod_est)
            AcessoDadosSql.AdicionarParmetros("@qtde_est", vestoque.qtde_est)
            AcessoDadosSql.AdicionarParmetros("@data_est", vestoque.data_est)
            AcessoDadosSql.AdicionarParmetros("@venc_est", vestoque.venc_est)

            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspEstoqueAlterar").ToString
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Function Excluir(ByVal vestoque As Integer) As String
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@cod_est", vestoque)
            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspEstoqueExcluir").ToString()
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function TotalEstoque(ByVal qtde_estoque As Integer) As String
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@produto", qtde_estoque)

            Try
                Dim dataTableCliente As String = AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspEstoqueSoma")
                Return dataTableCliente
            Catch ex As Exception
                Return 0
            End Try
        Catch ex As Exception
            Throw New Exception("Não foi possível consultar o cliente. Detalhes: " & ex.Message)
        End Try
    End Function

End Class