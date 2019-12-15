Public Class frm_Principal

    Private Sub menuSair_Click(sender As Object, e As EventArgs) Handles menuSair.Click
        Application.Exit()
    End Sub

    Private Sub menuCliente_Click(sender As Object, e As EventArgs) Handles menuCliente.Click
        frm_Cliente.MdiParent = Me
        frm_Cliente.Show()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        frm_Cliente.MdiParent = Me
        frm_Cliente.Show()
    End Sub

    Private Sub btnLigacao_Click(sender As Object, e As EventArgs) Handles btnLigacao.Click
        frm_Ligacao.MdiParent = Me
        frm_Ligacao.Show()
    End Sub

    Private Sub btnFuncionario_Click(sender As Object, e As EventArgs) Handles btnFuncionario.Click
        frm_Funcionario.MdiParent = Me
        frm_Funcionario.Show()
    End Sub

    Private Sub btnProduto_Click(sender As Object, e As EventArgs) Handles btnProduto.Click
        frm_Produto.MdiParent = Me
        frm_Produto.Show()
    End Sub


End Class