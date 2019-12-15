Imports ObjetoTransferencia
Imports Negocios

Public Class frm_Cliente

    Private Sub atualizarGrid()
        Dim cliNegocio As New ClienteNegocios

        dgvCliente.DataSource = Nothing
        dgvCliente.DataSource = cliNegocio.ConsularPorNome(txtPesquisa.Text)

        dgvCliente.Update()
        dgvCliente.Refresh()
    End Sub

    Public Sub abre_campos()
        txtNome.ReadOnly = False
        mtbCep.ReadOnly = False
        txtRua.ReadOnly = False
        txtNum.ReadOnly = False
        txtBairro.ReadOnly = False
        txtCidade.ReadOnly = False
        cbxUf.Enabled = True
        mtbTelefone.ReadOnly = False
        mtbCelular.ReadOnly = False
        txtObserv.ReadOnly = False
        txtTaxaEntrega.ReadOnly = False

        btnConfirmar.Visible = True
        btnCancelar.Visible = True

        txtNome.TabStop = True
        mtbCep.TabStop = True
        txtRua.TabStop = True
        txtNum.TabStop = True
        txtBairro.TabStop = True
        txtCidade.TabStop = True
        cbxUf.TabStop = True
        mtbTelefone.TabStop = True
        mtbCelular.TabStop = True
        txtObserv.TabStop = True
        txtTaxaEntrega.TabStop = True

        btnConfirmar.TabStop = True
        btnCancelar.TabStop = True

        txtNome.Focus()
        dgvCliente.Enabled = False

        cbxUf.Text = "SP"
        txtCidade.Text = "Itu"
        txtPesquisa.Enabled = False
        btnPesquisa.Enabled = False
        btnProcura.Enabled = True
        btnProcura.TabStop = True

        btnAdicionar.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub limpa_campos()
        txtCodigo.Text = ""
        txtNome.Text = ""
        mtbCep.Text = ""
        txtRua.Text = ""
        txtNum.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        cbxUf.Text = ""
        mtbTelefone.Text = ""
        mtbCelular.Text = ""
        txtObserv.Text = ""
        txtTaxaEntrega.Text = ""
    End Sub

    Private Sub fecha_campos()
        txtNome.ReadOnly = True
        txtNome.TabStop = False
        mtbCep.ReadOnly = True
        mtbCep.TabStop = False
        txtRua.ReadOnly = True
        txtRua.TabStop = False
        txtNum.ReadOnly = True
        txtNum.TabStop = False
        txtBairro.ReadOnly = True
        txtBairro.TabStop = False
        txtCidade.ReadOnly = True
        txtCidade.TabStop = False
        cbxUf.Enabled = False
        cbxUf.TabStop = False
        mtbTelefone.ReadOnly = True
        mtbTelefone.TabStop = False
        mtbCelular.ReadOnly = True
        mtbCelular.TabStop = False
        txtObserv.ReadOnly = True
        txtObserv.TabStop = False
        txtTaxaEntrega.ReadOnly = True
        txtTaxaEntrega.TabStop = False

        btnConfirmar.Visible = False
        btnConfirmar.TabStop = False
        btnCancelar.Visible = False
        btnCancelar.TabStop = False

        txtPesquisa.Enabled = True
        btnPesquisa.Enabled = True
        txtPesquisa.Focus()
        dgvCliente.Enabled = True

        btnProcura.Enabled = False
        btnAdicionar.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True

        lblAnotacao.Text = "Cadastro Completo"
    End Sub

    Private Sub carrega_campos()
        Dim valor As Decimal

        txtCodigo.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(0).Value
        txtNome.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(1).Value
        mtbCep.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(2).Value
        txtRua.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(3).Value
        txtNum.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(4).Value
        txtBairro.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(5).Value
        txtCidade.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(6).Value
        cbxUf.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(7).Value
        mtbTelefone.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(8).Value
        mtbCelular.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(9).Value
        txtObserv.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(10).Value
        valor = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(12).Value
        txtTaxaEntrega.Text = String.Format("{0:F}", valor)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        AtualizarGrid()
    End Sub

    Private Sub frm_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCliente.AutoGenerateColumns = False
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        abre_campos()
        limpa_campos()

        cbxUf.Text = "SP"
        txtCidade.Text = "Itu"

        lblAnotacao.Text = "Adicionar Cliente"

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        fecha_campos()

        If dgvCliente.SelectedRows.Count <> 0 Then
            carrega_campos()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        '//Verificar se tem algum registro selecionado
        If dgvCliente.SelectedRows.Count = 0 Then
            MessageBox.Show("Nenhum cliente selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            lblAnotacao.Text = "Editar Cliente"
            abre_campos()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If dgvCliente.SelectedRows.Count = 0 Then
            MessageBox.Show("Nenhum cliente selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            If MessageBox.Show("Deseja excluir o cliente selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim clienteNegocio As New ClienteNegocios
                Dim retorno As String = clienteNegocio.Excluir(txtCodigo.Text)

                Try
                    Dim idCliente As Integer = Convert.ToInt32(retorno)
                    MessageBox.Show("Cliente excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                Dim vCliente As New Cliente
                vCliente.nome_cli = txtNome.Text
                vCliente.cep_cli = mtbCep.Text
                vCliente.rua_cli = txtRua.Text
                vCliente.num_cli = txtNum.Text
                vCliente.bairro_cli = txtBairro.Text
                vCliente.cidade_cli = txtCidade.Text
                vCliente.uf_cli = cbxUf.Text
                vCliente.telefone_cli = mtbTelefone.Text
                vCliente.celular_cli = mtbCelular.Text
                vCliente.observ_cli = txtObserv.Text
                vCliente.ativo_cli = "s"
                vCliente.taxaent_cli = txtTaxaEntrega.Text.Replace(",", ".")

                Dim vClienteNegocio As New ClienteNegocios
                Dim retorno As String = vClienteNegocio.Inserir(vCliente)

                Try
                    Dim idCliente As Integer = Convert.ToInt32(retorno)
                    MessageBox.Show("Cliente inserido com sucesso. Código: " & idCliente.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    atualizarGrid()
                    fecha_campos()
                Catch ex As Exception
                    MessageBox.Show("Não foi possível Inserir. Detalhes: " & retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Dim vCliente As New Cliente
                vCliente.cod_cli = txtCodigo.Text
                vCliente.nome_cli = txtNome.Text
                vCliente.cep_cli = mtbCep.Text
                vCliente.rua_cli = txtRua.Text
                vCliente.num_cli = txtNum.Text
                vCliente.bairro_cli = txtBairro.Text
                vCliente.cidade_cli = txtCidade.Text
                vCliente.uf_cli = cbxUf.Text
                vCliente.telefone_cli = mtbTelefone.Text
                vCliente.celular_cli = mtbCelular.Text
                vCliente.observ_cli = txtObserv.Text
                vCliente.ativo_cli = "s"
                vCliente.taxaent_cli = txtTaxaEntrega.Text.Replace(",", ".")

                Dim vClienteNegocio As New ClienteNegocios
                Dim retorno As String = vClienteNegocio.Alterar(vCliente)

                Try
                    Dim idCliente As Integer = Convert.ToInt32(retorno)
                    MessageBox.Show("Cliente alterado com sucesso. Código: " & idCliente.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub txtTaxaEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTaxaEntrega.KeyPress
        If e.KeyChar = "," Then
            e.Handled = False
            Return
        End If
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnProcura_Click(sender As Object, e As EventArgs) Handles btnProcura.Click
        Try
            Dim vClienteNegocio As New ClienteNegocios
            Dim vCliente As New Cliente
            vClienteNegocio.VerificaCep(mtbCep.Text, vCliente)
            txtRua.Text = vCliente.rua_cli
            txtBairro.Text = vCliente.bairro_cli
            txtCidade.Text = vCliente.cidade_cli
            cbxUf.Text = vCliente.uf_cli
        Catch ex As Exception
            MessageBox.Show("Cep não encontrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub dgvCliente_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCliente.SelectionChanged
        If dgvCliente.SelectedRows.Count <> 0 Then
            carrega_campos()
        Else
            limpa_campos()
        End If
    End Sub

End Class