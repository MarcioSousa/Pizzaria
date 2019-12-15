Public Class Funcionario
    '//Variáveis
    Private cod As Integer
    Private nome As String
    Private senha As String
    Private entrada As Date
    Private mensal As String
    Private tipo As String

    '//GET = Pegar, SET = Setar
    Public Property cod_fun
        Get
            Return cod
        End Get
        Set(value)
            cod = value
        End Set
    End Property
    Public Property nome_fun
        Get
            Return nome.ToUpper
        End Get
        Set(value)
            nome = value
        End Set
    End Property
    Public Property senha_fun
        Get
            Return senha.ToLower
        End Get
        Set(value)
            senha = value
        End Set
    End Property
    Public Property entrada_fun
        Get
            Return entrada
        End Get
        Set(value)
            entrada = value
        End Set
    End Property
    Public Property mensal_fun
        Get
            Return mensal
        End Get
        Set(value)
            mensal = value
        End Set
    End Property
    Public Property tipo_fun
        Get
            Return tipo
        End Get
        Set(value)
            tipo = value
        End Set
    End Property

End Class
