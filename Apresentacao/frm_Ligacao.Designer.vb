<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ligacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Ligacao))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLigacao = New System.Windows.Forms.TextBox()
        Me.btnNovoCliente = New System.Windows.Forms.Button()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TAXAENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAvanca = New System.Windows.Forms.Button()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ligação:"
        '
        'txtLigacao
        '
        Me.txtLigacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLigacao.Location = New System.Drawing.Point(213, 12)
        Me.txtLigacao.MaxLength = 11
        Me.txtLigacao.Name = "txtLigacao"
        Me.txtLigacao.Size = New System.Drawing.Size(115, 26)
        Me.txtLigacao.TabIndex = 1
        Me.txtLigacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNovoCliente
        '
        Me.btnNovoCliente.Image = CType(resources.GetObject("btnNovoCliente.Image"), System.Drawing.Image)
        Me.btnNovoCliente.Location = New System.Drawing.Point(12, 337)
        Me.btnNovoCliente.Name = "btnNovoCliente"
        Me.btnNovoCliente.Size = New System.Drawing.Size(42, 42)
        Me.btnNovoCliente.TabIndex = 28
        Me.btnNovoCliente.UseVisualStyleBackColor = True
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.AllowUserToResizeColumns = False
        Me.dgvCliente.AllowUserToResizeRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.NOME, Me.CEP, Me.RUA, Me.NUMERO, Me.BAIRRO, Me.CIDADE, Me.UF, Me.TELEFONE, Me.CELULAR, Me.OBSERV, Me.ATIVO, Me.TAXAENT})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCliente.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvCliente.Location = New System.Drawing.Point(12, 46)
        Me.dgvCliente.MultiSelect = False
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.RowHeadersVisible = False
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(316, 283)
        Me.dgvCliente.TabIndex = 29
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "cod_cli"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle10.Format = "#,##0"
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Red
        Me.CODIGO.DefaultCellStyle = DataGridViewCellStyle10
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        Me.CODIGO.Width = 65
        '
        'NOME
        '
        Me.NOME.DataPropertyName = "nome_cli"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.NOME.DefaultCellStyle = DataGridViewCellStyle11
        Me.NOME.HeaderText = "Nome"
        Me.NOME.Name = "NOME"
        Me.NOME.ReadOnly = True
        Me.NOME.Width = 220
        '
        'CEP
        '
        Me.CEP.DataPropertyName = "cep_cli"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CEP.DefaultCellStyle = DataGridViewCellStyle12
        Me.CEP.HeaderText = "Cep"
        Me.CEP.Name = "CEP"
        Me.CEP.ReadOnly = True
        Me.CEP.Visible = False
        '
        'RUA
        '
        Me.RUA.DataPropertyName = "rua_cli"
        Me.RUA.HeaderText = "Rua"
        Me.RUA.Name = "RUA"
        Me.RUA.ReadOnly = True
        Me.RUA.Visible = False
        '
        'NUMERO
        '
        Me.NUMERO.DataPropertyName = "num_cli"
        Me.NUMERO.HeaderText = "Numero"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        Me.NUMERO.Visible = False
        '
        'BAIRRO
        '
        Me.BAIRRO.DataPropertyName = "bairro_cli"
        Me.BAIRRO.HeaderText = "Bairro"
        Me.BAIRRO.Name = "BAIRRO"
        Me.BAIRRO.ReadOnly = True
        Me.BAIRRO.Visible = False
        '
        'CIDADE
        '
        Me.CIDADE.DataPropertyName = "cidade_cli"
        Me.CIDADE.HeaderText = "Cidade"
        Me.CIDADE.Name = "CIDADE"
        Me.CIDADE.ReadOnly = True
        Me.CIDADE.Visible = False
        '
        'UF
        '
        Me.UF.DataPropertyName = "uf_cli"
        Me.UF.HeaderText = "Uf"
        Me.UF.Name = "UF"
        Me.UF.ReadOnly = True
        Me.UF.Visible = False
        '
        'TELEFONE
        '
        Me.TELEFONE.DataPropertyName = "telefone_cli"
        Me.TELEFONE.HeaderText = "Telefone"
        Me.TELEFONE.Name = "TELEFONE"
        Me.TELEFONE.ReadOnly = True
        Me.TELEFONE.Visible = False
        '
        'CELULAR
        '
        Me.CELULAR.DataPropertyName = "celular_cli"
        Me.CELULAR.HeaderText = "Celular"
        Me.CELULAR.Name = "CELULAR"
        Me.CELULAR.ReadOnly = True
        Me.CELULAR.Visible = False
        '
        'OBSERV
        '
        Me.OBSERV.DataPropertyName = "observ_cli"
        Me.OBSERV.HeaderText = "Observ"
        Me.OBSERV.Name = "OBSERV"
        Me.OBSERV.ReadOnly = True
        Me.OBSERV.Visible = False
        '
        'ATIVO
        '
        Me.ATIVO.DataPropertyName = "ativo_cli"
        Me.ATIVO.HeaderText = "Ativo"
        Me.ATIVO.Name = "ATIVO"
        Me.ATIVO.ReadOnly = True
        Me.ATIVO.Visible = False
        '
        'TAXAENT
        '
        Me.TAXAENT.DataPropertyName = "taxaent_cli"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "#,##0.00"
        Me.TAXAENT.DefaultCellStyle = DataGridViewCellStyle13
        Me.TAXAENT.HeaderText = "Taxa Entrega"
        Me.TAXAENT.Name = "TAXAENT"
        Me.TAXAENT.ReadOnly = True
        Me.TAXAENT.Visible = False
        '
        'btnAvanca
        '
        Me.btnAvanca.AutoSize = True
        Me.btnAvanca.Image = CType(resources.GetObject("btnAvanca.Image"), System.Drawing.Image)
        Me.btnAvanca.Location = New System.Drawing.Point(286, 337)
        Me.btnAvanca.Name = "btnAvanca"
        Me.btnAvanca.Size = New System.Drawing.Size(42, 42)
        Me.btnAvanca.TabIndex = 30
        Me.btnAvanca.UseVisualStyleBackColor = True
        '
        'frm_Ligacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 388)
        Me.Controls.Add(Me.btnAvanca)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.btnNovoCliente)
        Me.Controls.Add(Me.txtLigacao)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Ligacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recebendo Ligação"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLigacao As System.Windows.Forms.TextBox
    Friend WithEvents btnNovoCliente As System.Windows.Forms.Button
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents TAXAENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAvanca As System.Windows.Forms.Button
End Class
