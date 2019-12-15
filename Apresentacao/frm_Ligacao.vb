Imports Negocios
Imports ObjetoTransferencia

Public Class frm_Ligacao

    Private Sub frm_Ligacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCliente.AutoGenerateColumns = False
    End Sub

    Private Sub txtLigacao_TextChanged(sender As Object, e As EventArgs) Handles txtLigacao.TextChanged

        If txtLigacao.Text <> "" Then
            Dim cliNegocio As New ClienteNegocios
            Dim cliColecao As New ClienteColecao

            cliColecao = cliNegocio.ConsultarPorTelefone(txtLigacao.Text)

            dgvCliente.DataSource = Nothing
            dgvCliente.DataSource = cliColecao

            dgvCliente.Update()
            dgvCliente.Refresh()
        Else
            dgvCliente.DataSource = Nothing
        End If

    End Sub

    Private Sub btnNovoCliente_Click(sender As Object, e As EventArgs) Handles btnNovoCliente.Click
        frm_Cliente.MdiParent = frm_Principal
        frm_Cliente.Show()
        frm_Cliente.abre_campos()
    End Sub

    Private Sub txtLigacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLigacao.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAvanca_Click(sender As Object, e As EventArgs) Handles btnAvanca.Click
        If dgvCliente.Rows.Count <> 0 Then


        Else
            If MessageBox.Show("Nenhum Cliente selecionado. Deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            End If
        End If
    End Sub

End Class