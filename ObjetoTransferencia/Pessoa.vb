Public Class Pessoa
    Private cod As Integer
    Private nome As String

    Public Property cod_cli
        Get
            Return cod
        End Get
        Set(ByVal value)
            cod = value
        End Set
    End Property
    Public Property nome_cli
        Get
            Return nome.ToUpper
        End Get
        Set(ByVal value)
            nome = value
        End Set
    End Property

End Class