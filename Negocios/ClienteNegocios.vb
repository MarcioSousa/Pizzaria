Imports AcessoBD
Imports ObjetoTransferencia
Imports System.Data

Public Class ClienteNegocios
    '//Instânciar = criar um novo objeto baseado em um modelo
    Dim AcessoSql As New AcessoDadosSql

    Public Function Inserir(ByVal vcliente As Cliente) As String

        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@nome_cli", vcliente.nome_cli)
            AcessoDadosSql.AdicionarParmetros("@cep_cli", vcliente.cep_cli)
            AcessoDadosSql.AdicionarParmetros("@rua_cli", vcliente.rua_cli)
            AcessoDadosSql.AdicionarParmetros("@num_cli", vcliente.num_cli)
            AcessoDadosSql.AdicionarParmetros("@bairro_cli", vcliente.bairro_cli)
            AcessoDadosSql.AdicionarParmetros("@cidade_cli", vcliente.cidade_cli)
            AcessoDadosSql.AdicionarParmetros("@uf_cli", vcliente.uf_cli)
            AcessoDadosSql.AdicionarParmetros("@telefone_cli", vcliente.telefone_cli)
            AcessoDadosSql.AdicionarParmetros("@celular_cli", vcliente.celular_cli)
            AcessoDadosSql.AdicionarParmetros("@observ_cli", vcliente.observ_cli)
            AcessoDadosSql.AdicionarParmetros("@ativo_cli", vcliente.ativo_cli)
            AcessoDadosSql.AdicionarParmetros("@taxaent_cli", vcliente.taxaent_cli)
            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Function Alterar(ByVal vcliente As Cliente) As String

        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@cod_cli", vcliente.cod_cli)
            AcessoDadosSql.AdicionarParmetros("@nome_cli", vcliente.nome_cli)
            AcessoDadosSql.AdicionarParmetros("@cep_cli", vcliente.cep_cli)
            AcessoDadosSql.AdicionarParmetros("@rua_cli", vcliente.rua_cli)
            AcessoDadosSql.AdicionarParmetros("@num_cli", vcliente.num_cli)
            AcessoDadosSql.AdicionarParmetros("@bairro_cli", vcliente.bairro_cli)
            AcessoDadosSql.AdicionarParmetros("@cidade_cli", vcliente.cidade_cli)
            AcessoDadosSql.AdicionarParmetros("@uf_cli", vcliente.uf_cli)
            AcessoDadosSql.AdicionarParmetros("@telefone_cli", vcliente.telefone_cli)
            AcessoDadosSql.AdicionarParmetros("@celular_cli", vcliente.celular_cli)
            AcessoDadosSql.AdicionarParmetros("@observ_cli", vcliente.observ_cli)
            AcessoDadosSql.AdicionarParmetros("@ativo_cli", vcliente.ativo_cli)
            AcessoDadosSql.AdicionarParmetros("@taxaent_cli", vcliente.taxaent_cli)
            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Function Excluir(ByVal vcliente As Integer) As String
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@cod_cli", vcliente)
            Return AcessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString()
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function ConsularPorNome(ByVal nome As String) As DataTable
        Try
            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@consulta", nome)

            Dim dataTableCliente As DataTable = AcessoDadosSql.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultar")

            Return dataTableCliente
        Catch ex As Exception
            Throw New Exception("Não foi possível consultar o cliente. Detalhes: " & ex.Message)
        End Try
    End Function

    Public Function ConsultarPorTelefone(ByVal nTelefone As String) As ClienteColecao
        Try
            Dim cliColecao As New ClienteColecao

            AcessoDadosSql.LimparParametros()
            AcessoDadosSql.AdicionarParmetros("@contato", nTelefone)

            Dim dataTableCliente As DataTable = AcessoDadosSql.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorTelefone")

            For Each dataRowLinha As DataRow In dataTableCliente.Rows
                Dim vCliente As New Cliente

                vCliente.cod_cli = dataRowLinha("cod_cli")
                vCliente.nome_cli = dataRowLinha("nome_cli")
                vCliente.cep_cli = dataRowLinha("cep_cli")
                vCliente.rua_cli = dataRowLinha("rua_cli")
                vCliente.num_cli = dataRowLinha("num_cli")
                vCliente.bairro_cli = dataRowLinha("bairro_cli")
                vCliente.cidade_cli = dataRowLinha("cidade_cli")
                vCliente.uf_cli = dataRowLinha("uf_cli")
                vCliente.observ_cli = dataRowLinha("observ_cli")
                vCliente.ativo_cli = dataRowLinha("ativo_cli")
                vCliente.taxaent_cli = dataRowLinha("taxaent_cli")

                cliColecao.Add(vCliente)
            Next

            Return cliColecao
        Catch ex As Exception
            Throw New Exception("Não foi possível consultar o cliente por código. Detalhes: " & ex.Message)
        End Try
    End Function

    Public Function VerificaCep(ByVal vcep As String, ByVal vCliente As Cliente)
        Try
            Dim ds As New DataSet
            Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", vcep)

            ds.ReadXml(xml)

            If ds.Tables(0).Rows(0)("resultado") Then
                vCliente.rua_cli = ds.Tables(0).Rows(0)("tipo_logradouro") & " " & ds.Tables(0).Rows(0)("logradouro")
                vCliente.bairro_cli = ds.Tables(0).Rows(0)("bairro")
                vCliente.cidade_cli = ds.Tables(0).Rows(0)("cidade")
                vCliente.uf_cli = ds.Tables(0).Rows(0)("uf")
                Return vCliente
            Else
                Return MsgBox("Cep não localizado, tente novamente...")
            End If

        Catch ex As Exception
            Throw New Exception("Cep não encontrado! Detalhes: " & ex.Message)
        End Try
    End Function

End Class