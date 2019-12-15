Public Class Produto
    '//Variáveis
    Private cod As Integer
    Private nome As String
    Private preco As String

    '//GET = Pegar, SET = Setar
    Public Property cod_prod
        Get
            Return cod
        End Get
        Set(value)
            cod = value
        End Set
    End Property
    Public Property nome_prod
        Get
            Return nome.ToUpper
        End Get
        Set(value)
            nome = value
        End Set
    End Property
    Public Property preco_prod
        Get
            Return preco
        End Get
        Set(value)
            preco = value
        End Set
    End Property

End Class
