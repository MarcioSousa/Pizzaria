Imports AcessoBD
Imports ObjetoTransferencia
Imports System.Data

Public Class FuncionarioNegocios
    Dim AcessoSql As New AcessoDadosSql

    Public Function Inserir(ByVal vfuncionario As Funcionario) As String
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@nome_fun", vfuncionario.nome_fun)
            AcessoDadosSql.AdicionarParmetros("@senha_fun", vfuncionario.senha_fun)
            AcessoDadosSql.AdicionarParmetros("@entrada_fun", vfuncionario.entrada_fun)
            AcessoDadosSql.AdicionarParmetros("@mensal_fun", vfuncionario.mensal_fun)
            AcessoDadosSql.AdicionarParmetros("@tipo_fun", vfuncionario.tipo_fun)
            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioInserir").ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Alterar(ByVal vfuncionario As Funcionario) As String
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@cod_fun", vfuncionario.cod_fun)
            AcessoDadosSql.AdicionarParmetros("@nome_fun", vfuncionario.nome_fun)
            AcessoDadosSql.AdicionarParmetros("@senha_fun", vfuncionario.senha_fun)
            AcessoDadosSql.AdicionarParmetros("@entrada_fun", vfuncionario.entrada_fun)
            AcessoDadosSql.AdicionarParmetros("@mensal_fun", vfuncionario.mensal_fun)
            AcessoDadosSql.AdicionarParmetros("@tipo_fun", vfuncionario.tipo_fun)
            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioAlterar").ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Excluir(ByVal vfuncionario As Integer) As String
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@cod_fun", vfuncionario)
            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioExcluir").ToString()
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function ConsulaCompleta() As DataTable
        Try
            AcessoDadosSql.LimparParametros()
            Dim dataTableFuncionario As DataTable = AcessoDadosSql.ExecutarConsulta(CommandType.StoredProcedure, "uspFuncionarioConsultar")
            Return dataTableFuncionario
        Catch ex As Exception
            Throw New Exception("Não foi possível carregar os cadastros de seus Funcionários. Detalhes: " & ex.Message)
        End Try
    End Function


End Class
