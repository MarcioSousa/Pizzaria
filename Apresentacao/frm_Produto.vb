Imports ObjetoTransferencia
Imports Negocios

Public Class frm_Produto

    Private Sub atualizarGrid()
        Dim prodNegocio As New ProdutoNegocios

        dgvProdutos.DataSource = Nothing
        dgvProdutos.DataSource = prodNegocio.ConsulaCompleta()

        dgvProdutos.Update()
        dgvProdutos.Refresh()
    End Sub

    Private Sub abre_campos()
        txtNome.ReadOnly = False
        txtPreco.ReadOnly = False

        btnConfirmar.Visible = True
        btnCancelar.Visible = True

        txtNome.TabStop = True
        txtPreco.TabStop = True

        btnConfirmar.TabStop = True
        btnCancelar.TabStop = True

        txtNome.Focus()

        btnAdicionar.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub limpa_campos()
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtPreco.Text = ""
        txtQtdeTotal.Text = 0
    End Sub

    Private Sub fecha_campos()
        txtNome.ReadOnly = True
        txtPreco.ReadOnly = True

        txtNome.TabStop = False
        txtPreco.TabStop = False

        dgvProdutos.Enabled = True

        btnAdicionar.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True

        btnConfirmar.Visible = False
        btnCancelar.Visible = False

        lblAnotacao.Text = "Cadastro Completo"
    End Sub

    Private Sub carrega_campos()
        Dim qtdeTotalEstoque As New EstoqueNegocios
        Dim valor As Decimal

        txtCodigo.Text = dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(0).Value
        txtNome.Text = dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(1).Value
        valor = dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(2).Value
        txtPreco.Text = String.Format("{0:F}", valor)

        txtQtdeTotal.Text = Convert.ToString(qtdeTotalEstoque.TotalEstoque(txtCodigo.Text))
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub frm_Funcionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProdutos.AutoGenerateColumns = False
        atualizarGrid()
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        abre_campos()
        limpa_campos()
        lblAnotacao.Text = "Adicionar Produto"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        fecha_campos()
        If dgvProdutos.SelectedRows.Count <> 0 Then
            carrega_campos()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvProdutos.SelectedRows.Count = 0 Then
            MessageBox.Show("Nenhum funcionário selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            lblAnotacao.Text = "Editar Funcionário"
            abre_campos()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If dgvProdutos.SelectedRows.Count = 0 Then
            MessageBox.Show("Nenhum produto selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            If MessageBox.Show("Deseja excluir o Produto selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim produtoNegocio As New ProdutoNegocios
                Dim retorno As String = produtoNegocio.Excluir(txtCodigo.Text)

                Try
                    Dim idProduto As Integer = Convert.ToInt32(retorno)
                    MessageBox.Show("Produto excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                Dim vProduto As New Produto
                vProduto.nome_prod = txtNome.Text
                vProduto.preco_prod = txtPreco.Text.Replace(",", ".")

                Dim vProdutoNegocio As New ProdutoNegocios
                Dim retorno As String = vProdutoNegocio.Inserir(vProduto)

                Try
                    Dim idProduto As Integer = Convert.ToInt32(retorno)
                    MessageBox.Show("Produto inserido com sucesso. Código: " & idProduto.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    atualizarGrid()
                    fecha_campos()
                Catch ex As Exception
                    MessageBox.Show("Não foi possível Inserir. Detalhes: " & retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Dim vProduto As New Produto
                vProduto.cod_prod = txtCodigo.Text
                vProduto.nome_prod = txtNome.Text
                vProduto.preco_prod = txtPreco.Text.Replace(",", ".")

                Dim vProdutoNegocio As New ProdutoNegocios
                Dim retorno As String = vProdutoNegocio.Alterar(vProduto)

                Try
                    Dim idProduto As Integer = Convert.ToInt32(retorno)
                    MessageBox.Show("Produto alterado com sucesso. Código: " & idProduto.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub dgvProduto_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProdutos.SelectionChanged
        If dgvProdutos.SelectedRows.Count <> 0 Then
            carrega_campos()
        Else
            limpa_campos()
        End If
    End Sub

    Private Sub txtPreco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPreco.KeyPress
        If e.KeyChar = "," Then
            e.Handled = False
            Return
        End If
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

End Class