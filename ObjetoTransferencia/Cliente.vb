Public Class Cliente : Inherits Pessoa

    '//Variáveis
    Private cep As String
    Private rua As String
    Private num As String
    Private bairro As String
    Private cidade As String
    Private uf As String
    Private telefone As String
    Private celular As String
    Private observ As String
    Private ativo As String
    Private taxaent As String

    '//GET = Pegar, SET = Setar
    Public Property cep_cli
        Get
            Return cep
        End Get
        Set(ByVal value)
            cep = value
        End Set
    End Property
    Public Property rua_cli
        Get
            Return rua
        End Get
        Set(ByVal value)
            rua = value
        End Set
    End Property
    Public Property num_cli
        Get
            Return num
        End Get
        Set(ByVal value)
            num = value
        End Set
    End Property
    Public Property bairro_cli
        Get
            Return bairro
        End Get
        Set(ByVal value)
            bairro = value
        End Set
    End Property
    Public Property cidade_cli
        Get
            Return cidade
        End Get
        Set(ByVal value)
            cidade = value
        End Set
    End Property
    Public Property uf_cli
        Get
            Return uf
        End Get
        Set(ByVal value)
            uf = value
        End Set
    End Property
    Public Property telefone_cli
        Get
            Return telefone
        End Get
        Set(ByVal value)
            Dim valor As String
            valor = value
            valor = valor.Remove(9, 1)
            valor = valor.Remove(3, 2)
            valor = valor.Remove(0, 1)
            telefone = valor
        End Set
    End Property
    Public Property celular_cli
        Get
            Return celular
        End Get
        Set(ByVal value)
            Dim valor As String
            valor = value
            valor = valor.Remove(10, 1)
            valor = valor.Remove(5, 1)
            valor = valor.Remove(3, 1)
            valor = valor.Remove(0, 1)
            celular = valor
        End Set
    End Property
    Public Property observ_cli
        Get
            Return observ
        End Get
        Set(ByVal value)
            observ = value
        End Set
    End Property
    Public Property ativo_cli
        Get
            Return ativo
        End Get
        Set(ByVal value)
            ativo = value
        End Set
    End Property
    Public Property taxaent_cli
        Get
            Return taxaent
        End Get
        Set(ByVal value)
            taxaent = value
        End Set
    End Property

End Class