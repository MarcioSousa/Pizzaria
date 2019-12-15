'//Namespace´s que contém as classes que manipulam dados
Imports System.Data
Imports System.Data.SqlClient

Public Class AcessoDadosSql
    '//Cria e abre a conexão
    Private Shared Function AbreConexao() As SqlConnection
        Try
            Dim ConString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Marcio Sousa\Documents\Visual Studio 2013\Projects\Pizzaria\Apresentacao\Pizzaria.mdf';Integrated Security=True"
            Dim connection As SqlConnection = New SqlConnection(ConString)
            connection.Open()
            Return connection
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '//Parâmetros que vão para o banco
    Private Shared sqlColecaoParametro As SqlParameterCollection = New SqlCommand().Parameters
    Public Shared Sub LimparParametros()
        sqlColecaoParametro.Clear()
    End Sub
    Public Shared Sub AdicionarParmetros(ByVal nomeParametro As String, ByVal valorParametro As Object)
        sqlColecaoParametro.Add(New SqlParameter(nomeParametro, valorParametro))
    End Sub

    '//Persistência - Inserir, Alterar, Excluir
    Public Shared Function ExecutarManipulacao(ByVal tipoComando As CommandType, ByVal nomeStoreProcedureOuTextoSql As String) As Object
        Try
            '//Cria e abre a conexão
            Dim ConexaoSql As SqlConnection = AbreConexao()
            '//Cria o comando que vai levar a informaçõa para o banco.
            Dim sqlComando As SqlCommand = ConexaoSql.CreateCommand()
            '//Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão)
            sqlComando.CommandType = tipoComando
            sqlComando.CommandText = nomeStoreProcedureOuTextoSql
            sqlComando.CommandTimeout = 7200 '//Em segundos(7200 são 2 horas)

            '//Adicionar os parâmetros no comando
            For Each sqlParametro As SqlParameter In sqlColecaoParametro
                sqlComando.Parameters.Add(New SqlParameter(sqlParametro.ParameterName, sqlParametro.Value))
            Next

            '//Executar o comando, ou seja, mandar o comando ir até o banco de dados.
            Return sqlComando.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    '//Consultar registros do banco de dados
    Public Shared Function ExecutarConsulta(ByVal tipocomando As CommandType, ByVal nomeStoreProcedureOuTextoSql As String) As DataTable
        Try
            '//Cria e abre a conexão
            Dim ConexaoSql As SqlConnection = AbreConexao()
            '//Cria o comando que vai levar a informaçõa para o banco.
            Dim sqlComando As SqlCommand = ConexaoSql.CreateCommand()
            '//Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão)
            sqlComando.CommandType = tipocomando
            sqlComando.CommandText = nomeStoreProcedureOuTextoSql
            sqlComando.CommandTimeout = 7200 '//Em segundos(7200 são 2 horas)

            '//Adicionar os parâmetros no comando
            For Each sqlParametro As SqlParameter In sqlColecaoParametro
                sqlComando.Parameters.Add(New SqlParameter(sqlParametro.ParameterName, sqlParametro.Value))
            Next

            '//Criar um adaptador
            Dim SqlAdaptador As SqlDataAdapter = New SqlDataAdapter(sqlComando)

            '//Datatable = Tabela de Dados vazia onde vou colocar os dados que vem do banco
            Dim TabelaDados As DataTable = New DataTable()

            '//Mandar o comando ir até o banco buscar os dados e o adaptador preencher o datatable
            SqlAdaptador.Fill(TabelaDados)

            Return TabelaDados
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class