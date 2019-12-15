<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Cliente))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtbCep = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxUf = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtbTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtObserv = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTaxaEntrega = New System.Windows.Forms.TextBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnProcura = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAnotacao = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAIRRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CELULAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ATIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAXA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código/Nome:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(55, 37)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(60, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(55, 64)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.ReadOnly = True
        Me.txtNome.Size = New System.Drawing.Size(241, 20)
        Me.txtNome.TabIndex = 1
        Me.txtNome.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cep:"
        '
        'mtbCep
        '
        Me.mtbCep.Location = New System.Drawing.Point(55, 93)
        Me.mtbCep.Mask = "00000-000"
        Me.mtbCep.Name = "mtbCep"
        Me.mtbCep.ReadOnly = True
        Me.mtbCep.Size = New System.Drawing.Size(60, 20)
        Me.mtbCep.TabIndex = 2
        Me.mtbCep.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rua:"
        '
        'txtRua
        '
        Me.txtRua.Location = New System.Drawing.Point(55, 122)
        Me.txtRua.MaxLength = 50
        Me.txtRua.Name = "txtRua"
        Me.txtRua.ReadOnly = True
        Me.txtRua.Size = New System.Drawing.Size(241, 20)
        Me.txtRua.TabIndex = 4
        Me.txtRua.TabStop = False
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(55, 151)
        Me.txtNum.MaxLength = 50
        Me.txtNum.Name = "txtNum"
        Me.txtNum.ReadOnly = True
        Me.txtNum.Size = New System.Drawing.Size(110, 20)
        Me.txtNum.TabIndex = 5
        Me.txtNum.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nº:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(55, 180)
        Me.txtBairro.MaxLength = 50
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.ReadOnly = True
        Me.txtBairro.Size = New System.Drawing.Size(241, 20)
        Me.txtBairro.TabIndex = 6
        Me.txtBairro.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Bairro:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(55, 209)
        Me.txtCidade.MaxLength = 30
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.ReadOnly = True
        Me.txtCidade.Size = New System.Drawing.Size(183, 20)
        Me.txtCidade.TabIndex = 7
        Me.txtCidade.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cidade:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Uf:"
        '
        'cbxUf
        '
        Me.cbxUf.Enabled = False
        Me.cbxUf.FormattingEnabled = True
        Me.cbxUf.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cbxUf.Location = New System.Drawing.Point(55, 237)
        Me.cbxUf.Name = "cbxUf"
        Me.cbxUf.Size = New System.Drawing.Size(47, 21)
        Me.cbxUf.TabIndex = 8
        Me.cbxUf.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Tel:"
        '
        'mtbTelefone
        '
        Me.mtbTelefone.Location = New System.Drawing.Point(55, 267)
        Me.mtbTelefone.Mask = "(99) 0000-0000"
        Me.mtbTelefone.Name = "mtbTelefone"
        Me.mtbTelefone.ReadOnly = True
        Me.mtbTelefone.Size = New System.Drawing.Size(83, 20)
        Me.mtbTelefone.TabIndex = 9
        Me.mtbTelefone.TabStop = False
        '
        'mtbCelular
        '
        Me.mtbCelular.Location = New System.Drawing.Point(208, 267)
        Me.mtbCelular.Mask = "(99)0 0000-0000"
        Me.mtbCelular.Name = "mtbCelular"
        Me.mtbCelular.ReadOnly = True
        Me.mtbCelular.Size = New System.Drawing.Size(88, 20)
        Me.mtbCelular.TabIndex = 10
        Me.mtbCelular.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(178, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Cel:"
        '
        'txtObserv
        '
        Me.txtObserv.Location = New System.Drawing.Point(55, 300)
        Me.txtObserv.MaxLength = 50
        Me.txtObserv.Multiline = True
        Me.txtObserv.Name = "txtObserv"
        Me.txtObserv.ReadOnly = True
        Me.txtObserv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObserv.Size = New System.Drawing.Size(241, 57)
        Me.txtObserv.TabIndex = 11
        Me.txtObserv.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Obs:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(125, 380)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Taxa Entrega: R$"
        '
        'txtTaxaEntrega
        '
        Me.txtTaxaEntrega.Location = New System.Drawing.Point(222, 373)
        Me.txtTaxaEntrega.MaxLength = 12
        Me.txtTaxaEntrega.Name = "txtTaxaEntrega"
        Me.txtTaxaEntrega.ReadOnly = True
        Me.txtTaxaEntrega.Size = New System.Drawing.Size(74, 20)
        Me.txtTaxaEntrega.TabIndex = 12
        Me.txtTaxaEntrega.TabStop = False
        Me.txtTaxaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(93, 453)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 3
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(12, 453)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 6
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(252, 453)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(172, 453)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'txtPesquisa
        '
        Me.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisa.Location = New System.Drawing.Point(87, 12)
        Me.txtPesquisa.MaxLength = 40
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(211, 20)
        Me.txtPesquisa.TabIndex = 0
        Me.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Cod:"
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Image = CType(resources.GetObject("btnPesquisa.Image"), System.Drawing.Image)
        Me.btnPesquisa.Location = New System.Drawing.Point(302, 9)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(25, 24)
        Me.btnPesquisa.TabIndex = 1
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnProcura)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblAnotacao)
        Me.Panel1.Controls.Add(Me.btnConfirmar)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNome)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.mtbCep)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRua)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtTaxaEntrega)
        Me.Panel1.Controls.Add(Me.txtNum)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtBairro)
        Me.Panel1.Controls.Add(Me.txtObserv)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.mtbCelular)
        Me.Panel1.Controls.Add(Me.txtCidade)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.mtbTelefone)
        Me.Panel1.Controls.Add(Me.cbxUf)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(335, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 467)
        Me.Panel1.TabIndex = 6
        '
        'btnProcura
        '
        Me.btnProcura.Enabled = False
        Me.btnProcura.Image = CType(resources.GetObject("btnProcura.Image"), System.Drawing.Image)
        Me.btnProcura.Location = New System.Drawing.Point(121, 89)
        Me.btnProcura.Name = "btnProcura"
        Me.btnProcura.Size = New System.Drawing.Size(25, 24)
        Me.btnProcura.TabIndex = 3
        Me.btnProcura.TabStop = False
        Me.btnProcura.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(215, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 42)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'lblAnotacao
        '
        Me.lblAnotacao.AutoSize = True
        Me.lblAnotacao.Location = New System.Drawing.Point(92, 9)
        Me.lblAnotacao.Name = "lblAnotacao"
        Me.lblAnotacao.Size = New System.Drawing.Size(96, 13)
        Me.lblAnotacao.TabIndex = 33
        Me.lblAnotacao.Text = "Cadastro Completo"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(192, 413)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 13
        Me.btnConfirmar.TabStop = False
        Me.btnConfirmar.Text = "&Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        Me.btnConfirmar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(43, 413)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.AllowUserToResizeColumns = False
        Me.dgvCliente.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCliente.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD, Me.NOME, Me.CEP, Me.RUA, Me.NUMERO, Me.BAIRRO, Me.CIDADE, Me.UF, Me.TELEFONE, Me.CELULAR, Me.OBSERV, Me.ATIVO, Me.TAXA})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCliente.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCliente.Location = New System.Drawing.Point(12, 38)
        Me.dgvCliente.MultiSelect = False
        Me.dgvCliente.Name = "dgvCliente"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCliente.RowHeadersVisible = False
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(315, 408)
        Me.dgvCliente.TabIndex = 7
        '
        'COD
        '
        Me.COD.DataPropertyName = "cod_cli"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Red
        Me.COD.DefaultCellStyle = DataGridViewCellStyle8
        Me.COD.HeaderText = "cod"
        Me.COD.Name = "COD"
        Me.COD.ReadOnly = True
        Me.COD.Width = 65
        '
        'NOME
        '
        Me.NOME.DataPropertyName = "nome_cli"
        Me.NOME.HeaderText = "nome"
        Me.NOME.Name = "NOME"
        Me.NOME.ReadOnly = True
        Me.NOME.Width = 225
        '
        'CEP
        '
        Me.CEP.DataPropertyName = "cep_cli"
        Me.CEP.HeaderText = "cep"
        Me.CEP.Name = "CEP"
        Me.CEP.ReadOnly = True
        Me.CEP.Visible = False
        '
        'RUA
        '
        Me.RUA.DataPropertyName = "rua_cli"
        Me.RUA.HeaderText = "rua"
        Me.RUA.Name = "RUA"
        Me.RUA.ReadOnly = True
        Me.RUA.Visible = False
        '
        'NUMERO
        '
        Me.NUMERO.DataPropertyName = "num_cli"
        Me.NUMERO.HeaderText = "num"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        Me.NUMERO.Visible = False
        '
        'BAIRRO
        '
        Me.BAIRRO.DataPropertyName = "bairro_cli"
        Me.BAIRRO.HeaderText = "bairro"
        Me.BAIRRO.Name = "BAIRRO"
        Me.BAIRRO.ReadOnly = True
        Me.BAIRRO.Visible = False
        '
        'CIDADE
        '
        Me.CIDADE.DataPropertyName = "cidade_cli"
        Me.CIDADE.HeaderText = "cidade"
        Me.CIDADE.Name = "CIDADE"
        Me.CIDADE.ReadOnly = True
        Me.CIDADE.Visible = False
        '
        'UF
        '
        Me.UF.DataPropertyName = "uf_cli"
        Me.UF.HeaderText = "uf"
        Me.UF.Name = "UF"
        Me.UF.ReadOnly = True
        Me.UF.Visible = False
        '
        'TELEFONE
        '
        Me.TELEFONE.DataPropertyName = "telefone_cli"
        Me.TELEFONE.HeaderText = "telefone"
        Me.TELEFONE.Name = "TELEFONE"
        Me.TELEFONE.ReadOnly = True
        Me.TELEFONE.Visible = False
        '
        'CELULAR
        '
        Me.CELULAR.DataPropertyName = "celular_cli"
        Me.CELULAR.HeaderText = "celular"
        Me.CELULAR.Name = "CELULAR"
        Me.CELULAR.ReadOnly = True
        Me.CELULAR.Visible = False
        '
        'OBSERV
        '
        Me.OBSERV.DataPropertyName = "observ_cli"
        Me.OBSERV.HeaderText = "observ"
        Me.OBSERV.Name = "OBSERV"
        Me.OBSERV.ReadOnly = True
        Me.OBSERV.Visible = False
        '
        'ATIVO
        '
        Me.ATIVO.DataPropertyName = "ativo_cli"
        Me.ATIVO.HeaderText = "ativo"
        Me.ATIVO.Name = "ATIVO"
        Me.ATIVO.ReadOnly = True
        Me.ATIVO.Visible = False
        '
        'TAXA
        '
        Me.TAXA.DataPropertyName = "taxaent_cli"
        Me.TAXA.HeaderText = "taxa"
        Me.TAXA.Name = "TAXA"
        Me.TAXA.ReadOnly = True
        Me.TAXA.Visible = False
        '
        'frm_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPesquisa)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mtbCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRua As System.Windows.Forms.TextBox
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxUf As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mtbTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtObserv As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTaxaEntrega As System.Windows.Forms.TextBox
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnPesquisa As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblAnotacao As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnProcura As System.Windows.Forms.Button
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents COD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BAIRRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIDADE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEFONE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CELULAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ATIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TAXA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
