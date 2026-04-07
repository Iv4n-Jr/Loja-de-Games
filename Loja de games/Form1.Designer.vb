<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_categoria = New System.Windows.Forms.TextBox()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_custo = New System.Windows.Forms.TextBox()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.cmb_data_venda = New System.Windows.Forms.DateTimePicker()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Custo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_venda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btn_gravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_buscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_campo = New System.Windows.Forms.ToolStripComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.Label1.Location = New System.Drawing.Point(90, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(554, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.Label2.Location = New System.Drawing.Point(749, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 76)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.Label3.Location = New System.Drawing.Point(90, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(679, 76)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Empresa distribuídora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.Label4.Location = New System.Drawing.Point(664, 542)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(465, 76)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data da venda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.Label5.Location = New System.Drawing.Point(838, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(575, 76)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cliente comprador"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.Label6.Location = New System.Drawing.Point(90, 542)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 76)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Custo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.Label7.Location = New System.Drawing.Point(1382, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(510, 76)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Foto do Produto"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.txt_nome.Location = New System.Drawing.Point(91, 155)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(553, 83)
        Me.txt_nome.TabIndex = 9
        '
        'txt_categoria
        '
        Me.txt_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.txt_categoria.Location = New System.Drawing.Point(753, 155)
        Me.txt_categoria.Name = "txt_categoria"
        Me.txt_categoria.Size = New System.Drawing.Size(490, 83)
        Me.txt_categoria.TabIndex = 10
        '
        'txt_empresa
        '
        Me.txt_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.txt_empresa.Location = New System.Drawing.Point(91, 419)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(678, 83)
        Me.txt_empresa.TabIndex = 11
        '
        'txt_cliente
        '
        Me.txt_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.txt_cliente.Location = New System.Drawing.Point(835, 419)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(578, 83)
        Me.txt_cliente.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.Label8.Location = New System.Drawing.Point(393, 542)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 76)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Preço"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_custo
        '
        Me.txt_custo.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.txt_custo.Location = New System.Drawing.Point(91, 644)
        Me.txt_custo.Name = "txt_custo"
        Me.txt_custo.Size = New System.Drawing.Size(206, 83)
        Me.txt_custo.TabIndex = 14
        '
        'txt_preco
        '
        Me.txt_preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.txt_preco.Location = New System.Drawing.Point(391, 644)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(209, 83)
        Me.txt_preco.TabIndex = 15
        '
        'cmb_data_venda
        '
        Me.cmb_data_venda.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.cmb_data_venda.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.cmb_data_venda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_venda.Location = New System.Drawing.Point(665, 644)
        Me.cmb_data_venda.Name = "cmb_data_venda"
        Me.cmb_data_venda.Size = New System.Drawing.Size(464, 83)
        Me.cmb_data_venda.TabIndex = 16
        Me.cmb_data_venda.Value = New Date(2026, 4, 7, 0, 0, 0, 0)
        '
        'img_foto
        '
        Me.img_foto.BackgroundImage = Global.Loja_de_games.My.Resources.Resources.Pac_Man1
        Me.img_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_foto.Location = New System.Drawing.Point(1480, 152)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(350, 350)
        Me.img_foto.TabIndex = 17
        Me.img_foto.TabStop = False
        '
        'dgv_dados
        '
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nome, Me.Categoria, Me.Empresa, Me.Cliente, Me.Custo, Me.Preco, Me.Data_venda, Me.Editar, Me.Excluir})
        Me.dgv_dados.Location = New System.Drawing.Point(91, 764)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.Size = New System.Drawing.Size(1739, 256)
        Me.dgv_dados.TabIndex = 18
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'Empresa
        '
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'Custo
        '
        Me.Custo.HeaderText = "Custo"
        Me.Custo.Name = "Custo"
        '
        'Preco
        '
        Me.Preco.HeaderText = "Preco"
        Me.Preco.Name = "Preco"
        '
        'Data_venda
        '
        Me.Data_venda.HeaderText = "Data_venda"
        Me.Data_venda.Name = "Data_venda"
        '
        'Editar
        '
        Me.Editar.HeaderText = "Editar"
        Me.Editar.Name = "Editar"
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Name = "Excluir"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btn_gravar, Me.ToolStripLabel2, Me.txt_buscar, Me.ToolStripLabel3, Me.cmb_campo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1904, 25)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel1.Text = "GRAVAR"
        '
        'btn_gravar
        '
        Me.btn_gravar.BackgroundImage = Global.Loja_de_games.My.Resources.Resources.Gravar
        Me.btn_gravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), System.Drawing.Image)
        Me.btn_gravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(23, 22)
        Me.btn_gravar.Text = "ToolStripButton1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripLabel2.Text = "Parâmetro de Pesquisa"
        '
        'txt_buscar
        '
        Me.txt_buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripLabel3.Text = "Categoria"
        '
        'cmb_campo
        '
        Me.cmb_campo.Name = "cmb_campo"
        Me.cmb_campo.Size = New System.Drawing.Size(121, 25)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Loja_de_games.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.cmb_data_venda)
        Me.Controls.Add(Me.txt_preco)
        Me.Controls.Add(Me.txt_custo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.txt_empresa)
        Me.Controls.Add(Me.txt_categoria)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "MENU"
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_categoria As TextBox
    Friend WithEvents txt_empresa As TextBox
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_custo As TextBox
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents cmb_data_venda As DateTimePicker
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Empresa As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Custo As DataGridViewTextBoxColumn
    Friend WithEvents Preco As DataGridViewTextBoxColumn
    Friend WithEvents Data_venda As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewTextBoxColumn
    Friend WithEvents Excluir As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txt_buscar As ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents cmb_campo As ToolStripComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
