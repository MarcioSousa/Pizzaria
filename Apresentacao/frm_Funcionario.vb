Imports ObjetoTransferencia
Imports Negocios

Public Class frm_Funcionario

    Private Sub atualizarGrid()
        Dim funcNegocio As New FuncionarioNegocios

        dgvFuncionario.DataSource = Nothing
        dgvFuncionario.DataSource = funcNegocio.ConsulaCompleta()

        dgvFuncionario.Update()
        dgvFuncionario.Refresh()
    End Sub

    Private Sub abre_campos()
        txtNome.ReadOnly = False
        txtTipo.ReadOnly = False
        txtSenha.ReadOnly = False
        txtMensal.ReadOnly = False

        btnConfirmar.Visible = True
        btnCancelar.Visible = True

        txtNome.TabStop = True
        txtTipo.TabStop = True
        txtSenha.TabStop = True
        txtMensal.TabStop = True
        dtpEntrada.TabStop = True

        btnConfirmar.TabStop = True
        btnCancelar.TabStop = True

        txtNome.Focus()

        dtpEntrada.Enabled = True

        btnAdicionar.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub limpa_campos()
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtTipo.Text = ""
        txtSenha.Text = ""
        txtMensal.Text = ""
        dtpEntrada.Value = Today.Date
    End Sub

    Private Sub fecha_campos()
        txtNome.ReadOnly = True
        txtTipo.ReadOnly = True
        txtSenha.ReadOnly = True
        txtMensal.ReadOnly = True

        txtNome.TabStop = False
        txtTipo.TabStop = False
        txtSenha.TabStop = False
        txtMensal.TabStop = False

        dtpEntrada.Enabled = False

        dgvFuncionario.Enabled = True

        btnAdicionar.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True

        btnConfirmar.Visible = False
        btnCancelar.Visible = False

        lblAnotacao.Text = "Cadastro Completo"
    End Sub

    Private Sub carrega_campos()
        Dim valor As Decimal

        txtCodigo.Text = dgvFuncionario.Rows(dgvFuncionario.CurrentRow.Index).Cells(0).Value
        txtNome.Text = dgvFuncionario.Rows(dgvFuncionario.CurrentRow.Index).Cells(1).Value
        txtSenha.Text = dgvFuncionario.Rows(dgvFuncionario.CurrentRow.Index).Cells(2).Value
        dtpEntrada.Value = dgvFuncionario.Rows(dgvFuncionario.CurrentRow.Index).Cells(3).Value
        valor = dgvFuncionario.Rows(dgvFuncionario.CurrentRow.Index).Cells(4).Value
        txtMensal.Text = String.Format("{0:F}", valor)
        txtTipo.Text = dgvFuncionario.Rows(dgvFuncionario.CurrentRow.Index).Cells(5).Value
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub frm_Funcionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvFuncionario.AutoGenerateColumns = False
        atualizarGrid()
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        abre_campos()
        limpa_campos()
        lblAnotacao.Text = "Adicionar Funcionário"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        fecha_campos()
        If dgvFuncionario.SelectedRows.Count <> 0 Then
            carrega_campos()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvFuncionario.SelectedRows.Count = 0 Then
            MessageBox.Show("Nenhum funcionário selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            lblAnotacao.Text = "Editar Funcionário"
            abre_campos()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If dgvFuncionario.SelectedRows.Count = 0 Then
            MessageBox.Show("Nenhum funcionario selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            If MessageBox.Show("Deseja excluir o funcionário selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim funcionarioNegocio As New FuncionarioNegocios
                Dim retorno As String = funcionarioNegocio.Excluir(txtCodigo.Text)

                Try
                    Dim idFuncionario As Integer = Convert.ToInt32(retorno)
                    MessageBox.Show("Funcionário excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    atualizarGrid()
                Catch ex As Exception
                    MessageBox.Show("Não foi possível excluir. Detalhes: " & retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Return
            End If
        End If

    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            If txtCodigo.Text = "" Then
                Dim vFuncionario As New Funcionario
                vFuncionario.nome_fun = txtNome.Text
                vFuncionario.senha_fun = txtSenha.Text
                vFuncionario.entrada_fun = dtpEntrada.Value
                vFuncionario.mensal_fun = txtMensal.Text.Replace(",", ".")
                vFuncionario.tipo_fun = txtTipo.Text

                Dim vFuncionarioNegocio As New FuncionarioNegocios
                Dim retorno As String = vFuncionarioNegocio.Inserir(vFuncionario)

                Try
                    Dim idFuncionario As Integer = Convert.ToInt32(retorno)
                    MessageBox.Show("Funcionário inserido com sucesso. Código: " & idFuncionario.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    atualizarGrid()
                    fecha_campos()
                Catch ex As Exception
                    MessageBox.Show("Não foi possível Inserir. Detalhes: " & retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Dim vFuncionario As New Funcionario
                vFuncionario.cod_fun = txtCodigo.Text
                vFuncionario.nome_fun = txtNome.Text
                vFuncionario.senha_fun = txtSenha.Text
                vFuncionario.entrada_fun = dtpEntrada.Value
                vFuncionario.mensal_fun = txtMensal.Text.Replace(",", ".")
                vFuncionario.tipo_fun = txtTipo.Text

                Dim vFuncionarioNegocio As New FuncionarioNegocios
                Dim retorno As String = vFuncionarioNegocio.Alterar(vFuncionario)

                Try
                    Dim idFuncionario As Integer = Convert.ToInt32(retorno)
                    MessageBox.Show("Funcionário alterado com sucesso. Código: " & idFuncionario.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    atualizarGrid()
                    fecha_campos()
                Catch ex As Exception
                    MessageBox.Show("Não foi possível Alterar. Detalhes: " & retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Não foi possível Alterar ou Inserir. Detalhes: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtMensal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMensal.KeyPress
        If e.KeyChar = "," Then
            e.Handled = False
            Return
        End If
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvFuncionario_SelectionChanged(sender As Object, e As EventArgs) Handles dgvFuncionario.SelectionChanged
        If dgvFuncionario.SelectedRows.Count <> 0 Then
            carrega_campos()
        Else
            limpa_campos()
        End If
    End Sub

End Class