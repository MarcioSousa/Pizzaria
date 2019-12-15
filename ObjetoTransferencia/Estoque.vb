Public Class Estoque
    '//Variáveis
    Private cod As Integer
    Private codprod As Integer
    Private qtde As Integer
    Private dataest As Date
    Private vencimento As Date

    '//GET = Pegar, SET = Setar
    Public Property cod_est
        Get
            Return cod
        End Get
        Set(ByVal value)
            cod = value
        End Set
    End Property
    Public Property codprod_est
        Get
            Return codprod
        End Get
        Set(ByVal value)
            codprod = value
        End Set
    End Property
    Public Property qtde_est
        Get
            Return qtde
        End Get
        Set(ByVal value)
            qtde = value
        End Set
    End Property
    Public Property data_est
        Get
            Return dataest
        End Get
        Set(ByVal value)
            dataest = value
        End Set
    End Property
    Public Property venc_est
        Get
            Return vencimento
        End Get
        Set(ByVal value)
            vencimento = value
        End Set
    End Property
 
End Class
