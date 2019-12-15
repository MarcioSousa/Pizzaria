<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Principal))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.labelVersao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.menuCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuProduto = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFuncionário = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMotoboy = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCliente = New System.Windows.Forms.ToolStripButton()
        Me.btnFuncionario = New System.Windows.Forms.ToolStripButton()
        Me.btnProduto = New System.Windows.Forms.ToolStripButton()
        Me.btnEntrega = New System.Windows.Forms.ToolStripButton()
        Me.btnVenda = New System.Windows.Forms.ToolStripButton()
        Me.btnLigacao = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEstoque = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.menuPrincipal.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelVersao})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 457)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(794, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'labelVersao
        '
        Me.labelVersao.Name = "labelVersao"
        Me.labelVersao.Size = New System.Drawing.Size(59, 17)
        Me.labelVersao.Text = "Versão 1.0"
        '
        'menuPrincipal
        '
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCadastro, Me.menuSair})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(794, 24)
        Me.menuPrincipal.TabIndex = 2
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'menuCadastro
        '
        Me.menuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCliente, Me.menuProduto, Me.menuFuncionário, Me.menuMotoboy})
        Me.menuCadastro.Name = "menuCadastro"
        Me.menuCadastro.Size = New System.Drawing.Size(66, 20)
        Me.menuCadastro.Text = "&Cadastro"
        '
        'menuCliente
        '
        Me.menuCliente.Name = "menuCliente"
        Me.menuCliente.Size = New System.Drawing.Size(137, 22)
        Me.menuCliente.Text = "C&liente"
        '
        'menuProduto
        '
        Me.menuProduto.Name = "menuProduto"
        Me.menuProduto.Size = New System.Drawing.Size(137, 22)
        Me.menuProduto.Text = "&Produto"
        '
        'menuFuncionário
        '
        Me.menuFuncionário.Name = "menuFuncionário"
        Me.menuFuncionário.Size = New System.Drawing.Size(137, 22)
        Me.menuFuncionário.Text = "&Funcionário"
        '
        'menuMotoboy
        '
        Me.menuMotoboy.Name = "menuMotoboy"
        Me.menuMotoboy.Size = New System.Drawing.Size(137, 22)
        Me.menuMotoboy.Text = "&Motoboy"
        '
        'menuSair
        '
        Me.menuSair.Name = "menuSair"
        Me.menuSair.Size = New System.Drawing.Size(38, 20)
        Me.menuSair.Text = "Sair"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 16)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCliente, Me.btnFuncionario, Me.btnProduto, Me.btnEntrega, Me.btnVenda, Me.btnEstoque, Me.btnLigacao})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(794, 64)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCliente
        '
        Me.btnCliente.AutoSize = False
        Me.btnCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(60, 60)
        Me.btnCliente.Text = "ToolStripButton1"
        Me.btnCliente.ToolTipText = "Clientes"
        '
        'btnFuncionario
        '
        Me.btnFuncionario.AutoSize = False
        Me.btnFuncionario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFuncionario.Image = CType(resources.GetObject("btnFuncionario.Image"), System.Drawing.Image)
        Me.btnFuncionario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFuncionario.Name = "btnFuncionario"
        Me.btnFuncionario.Size = New System.Drawing.Size(60, 60)
        Me.btnFuncionario.Text = "ToolStripButton1"
        Me.btnFuncionario.ToolTipText = "Funcionários"
        '
        'btnProduto
        '
        Me.btnProduto.AutoSize = False
        Me.btnProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnProduto.Image = CType(resources.GetObject("btnProduto.Image"), System.Drawing.Image)
        Me.btnProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnProduto.Name = "btnProduto"
        Me.btnProduto.Size = New System.Drawing.Size(60, 60)
        Me.btnProduto.Text = "ToolStripButton1"
        Me.btnProduto.ToolTipText = "Produtos"
        '
        'btnEntrega
        '
        Me.btnEntrega.AutoSize = False
        Me.btnEntrega.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEntrega.Image = CType(resources.GetObject("btnEntrega.Image"), System.Drawing.Image)
        Me.btnEntrega.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEntrega.Name = "btnEntrega"
        Me.btnEntrega.Size = New System.Drawing.Size(60, 60)
        Me.btnEntrega.Text = "ToolStripButton1"
        Me.btnEntrega.ToolTipText = "Entragas"
        '
        'btnVenda
        '
        Me.btnVenda.AutoSize = False
        Me.btnVenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnVenda.Image = CType(resources.GetObject("btnVenda.Image"), System.Drawing.Image)
        Me.btnVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnVenda.Name = "btnVenda"
        Me.btnVenda.Size = New System.Drawing.Size(60, 60)
        Me.btnVenda.Text = "ToolStripButton1"
        Me.btnVenda.ToolTipText = "Vendas"
        '
        'btnLigacao
        '
        Me.btnLigacao.AutoSize = False
        Me.btnLigacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLigacao.Image = CType(resources.GetObject("btnLigacao.Image"), System.Drawing.Image)
        Me.btnLigacao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLigacao.Name = "btnLigacao"
        Me.btnLigacao.Size = New System.Drawing.Size(60, 60)
        Me.btnLigacao.ToolTipText = "Ligação"
        '
        'btnEstoque
        '
        Me.btnEstoque.AutoSize = False
        Me.btnEstoque.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEstoque.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEstoque.Name = "btnEstoque"
        Me.btnEstoque.Size = New System.Drawing.Size(60, 60)
        Me.btnEstoque.ToolTipText = "Ligação"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(275, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Para fazer o estoque amanha"
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 479)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.menuPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuPrincipal
        Me.MinimizeBox = False
        Me.Name = "frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADFácil Sistemas - Janela Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents menuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents labelVersao As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menuCadastro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuProduto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFuncionário As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMotoboy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLigacao As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFuncionario As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProduto As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEntrega As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnVenda As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEstoque As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
