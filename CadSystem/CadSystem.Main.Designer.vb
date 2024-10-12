<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvConsulta = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnCadastroCorretor = New Button()
        Button2 = New Button()
        btnConsulta = New Button()
        txtCodCorretor = New TextBox()
        txtNomeCliente = New TextBox()
        txtNomeCorretor = New TextBox()
        txtCpfCliente = New TextBox()
        chkAtivo = New CheckBox()
        cboEstado = New ComboBox()
        cboCidade = New ComboBox()
        cons_id = New DataGridViewTextBoxColumn()
        cons_nomeCliente = New DataGridViewTextBoxColumn()
        cons_cpf = New DataGridViewTextBoxColumn()
        cons_ativo = New DataGridViewTextBoxColumn()
        cons_nomeCorretor = New DataGridViewTextBoxColumn()
        cons_codigo = New DataGridViewTextBoxColumn()
        cons_uf = New DataGridViewTextBoxColumn()
        cons_cidade = New DataGridViewTextBoxColumn()
        delete = New DataGridViewButtonColumn()
        CType(dgvConsulta, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvConsulta
        ' 
        dgvConsulta.AllowUserToAddRows = False
        dgvConsulta.AllowUserToOrderColumns = True
        dgvConsulta.AllowUserToResizeColumns = False
        dgvConsulta.AllowUserToResizeRows = False
        dgvConsulta.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvConsulta.Columns.AddRange(New DataGridViewColumn() {cons_id, cons_nomeCliente, cons_cpf, cons_ativo, cons_nomeCorretor, cons_codigo, cons_uf, cons_cidade, delete})
        dgvConsulta.Location = New Point(12, 129)
        dgvConsulta.Name = "dgvConsulta"
        dgvConsulta.RowHeadersVisible = False
        dgvConsulta.Size = New Size(818, 476)
        dgvConsulta.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 15)
        Label1.TabIndex = 1
        Label1.Text = "Código Corretor:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(294, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nome Corretor:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 15)
        Label3.TabIndex = 3
        Label3.Text = "Nome Cliente:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(294, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 4
        Label4.Text = "CPF Cliente:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(525, 39)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 15)
        Label5.TabIndex = 5
        Label5.Text = "Ativo?"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 68)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 6
        Label6.Text = "Estado:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(294, 70)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 15)
        Label7.TabIndex = 7
        Label7.Text = "Cidade:"
        ' 
        ' btnCadastroCorretor
        ' 
        btnCadastroCorretor.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCadastroCorretor.Location = New Point(694, 11)
        btnCadastroCorretor.Name = "btnCadastroCorretor"
        btnCadastroCorretor.Size = New Size(136, 23)
        btnCadastroCorretor.TabIndex = 8
        btnCadastroCorretor.Text = "Cadastrar Corretor"
        btnCadastroCorretor.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.Location = New Point(724, 35)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 23)
        Button2.TabIndex = 9
        Button2.Text = "Cadastrar Cliente"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnConsulta
        ' 
        btnConsulta.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnConsulta.Location = New Point(755, 100)
        btnConsulta.Name = "btnConsulta"
        btnConsulta.Size = New Size(75, 23)
        btnConsulta.TabIndex = 10
        btnConsulta.Text = "Consultar"
        btnConsulta.UseVisualStyleBackColor = True
        ' 
        ' txtCodCorretor
        ' 
        txtCodCorretor.Location = New Point(114, 7)
        txtCodCorretor.Name = "txtCodCorretor"
        txtCodCorretor.Size = New Size(121, 23)
        txtCodCorretor.TabIndex = 11
        ' 
        ' txtNomeCliente
        ' 
        txtNomeCliente.Location = New Point(101, 35)
        txtNomeCliente.Name = "txtNomeCliente"
        txtNomeCliente.Size = New Size(134, 23)
        txtNomeCliente.TabIndex = 12
        ' 
        ' txtNomeCorretor
        ' 
        txtNomeCorretor.Location = New Point(390, 7)
        txtNomeCorretor.Name = "txtNomeCorretor"
        txtNomeCorretor.Size = New Size(126, 23)
        txtNomeCorretor.TabIndex = 15
        ' 
        ' txtCpfCliente
        ' 
        txtCpfCliente.Location = New Point(371, 35)
        txtCpfCliente.Name = "txtCpfCliente"
        txtCpfCliente.Size = New Size(145, 23)
        txtCpfCliente.TabIndex = 16
        ' 
        ' chkAtivo
        ' 
        chkAtivo.AutoSize = True
        chkAtivo.Location = New Point(566, 40)
        chkAtivo.Name = "chkAtivo"
        chkAtivo.Size = New Size(15, 14)
        chkAtivo.TabIndex = 17
        chkAtivo.UseVisualStyleBackColor = True
        ' 
        ' cboEstado
        ' 
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cboEstado.FormattingEnabled = True
        cboEstado.Location = New Point(63, 64)
        cboEstado.Name = "cboEstado"
        cboEstado.Size = New Size(172, 23)
        cboEstado.TabIndex = 18
        ' 
        ' cboCidade
        ' 
        cboCidade.DropDownStyle = ComboBoxStyle.DropDownList
        cboCidade.FormattingEnabled = True
        cboCidade.Location = New Point(347, 64)
        cboCidade.Name = "cboCidade"
        cboCidade.Size = New Size(169, 23)
        cboCidade.TabIndex = 19
        ' 
        ' cons_id
        ' 
        cons_id.DataPropertyName = "cons_id"
        cons_id.HeaderText = "id"
        cons_id.Name = "cons_id"
        cons_id.Visible = False
        ' 
        ' cons_nomeCliente
        ' 
        cons_nomeCliente.DataPropertyName = "cons_nomeCliente"
        cons_nomeCliente.HeaderText = "Nome Cliente"
        cons_nomeCliente.MinimumWidth = 20
        cons_nomeCliente.Name = "cons_nomeCliente"
        cons_nomeCliente.Width = 120
        ' 
        ' cons_cpf
        ' 
        cons_cpf.DataPropertyName = "cons_cpf"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight
        cons_cpf.DefaultCellStyle = DataGridViewCellStyle1
        cons_cpf.HeaderText = "CPF"
        cons_cpf.MinimumWidth = 20
        cons_cpf.Name = "cons_cpf"
        cons_cpf.Width = 110
        ' 
        ' cons_ativo
        ' 
        cons_ativo.DataPropertyName = "cons_ativo"
        cons_ativo.HeaderText = "Ativo?"
        cons_ativo.Name = "cons_ativo"
        ' 
        ' cons_nomeCorretor
        ' 
        cons_nomeCorretor.DataPropertyName = "cons_nomeCorretor"
        cons_nomeCorretor.HeaderText = "Nome Corretor"
        cons_nomeCorretor.MinimumWidth = 20
        cons_nomeCorretor.Name = "cons_nomeCorretor"
        cons_nomeCorretor.Width = 120
        ' 
        ' cons_codigo
        ' 
        cons_codigo.DataPropertyName = "cons_codigo"
        cons_codigo.HeaderText = "Cod. Corretor"
        cons_codigo.MinimumWidth = 20
        cons_codigo.Name = "cons_codigo"
        cons_codigo.Width = 120
        ' 
        ' cons_uf
        ' 
        cons_uf.DataPropertyName = "cons_uf"
        cons_uf.HeaderText = "UF"
        cons_uf.Name = "cons_uf"
        ' 
        ' cons_cidade
        ' 
        cons_cidade.DataPropertyName = "cons_cidade"
        cons_cidade.HeaderText = "Cidade"
        cons_cidade.Name = "cons_cidade"
        cons_cidade.Width = 95
        ' 
        ' delete
        ' 
        delete.DataPropertyName = "delete"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Red
        delete.DefaultCellStyle = DataGridViewCellStyle2
        delete.FlatStyle = FlatStyle.Flat
        delete.HeaderText = "Delete"
        delete.Name = "delete"
        delete.Resizable = DataGridViewTriState.True
        delete.SortMode = DataGridViewColumnSortMode.Automatic
        delete.Text = "X"
        delete.ToolTipText = "Click here to delete the row"
        delete.UseColumnTextForButtonValue = True
        delete.Width = 50
        ' 
        ' CadSystem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(842, 617)
        Controls.Add(cboCidade)
        Controls.Add(cboEstado)
        Controls.Add(chkAtivo)
        Controls.Add(txtCpfCliente)
        Controls.Add(txtNomeCorretor)
        Controls.Add(txtNomeCliente)
        Controls.Add(txtCodCorretor)
        Controls.Add(btnConsulta)
        Controls.Add(Button2)
        Controls.Add(btnCadastroCorretor)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvConsulta)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "CadSystem"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consulta..."
        CType(dgvConsulta, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvConsulta As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCadastroCorretor As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnConsulta As Button
    Friend WithEvents txtCodCorretor As TextBox
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents txtNomeCorretor As TextBox
    Friend WithEvents txtCpfCliente As TextBox
    Friend WithEvents chkAtivo As CheckBox
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents cboCidade As ComboBox
    Friend WithEvents cons_id As DataGridViewTextBoxColumn
    Friend WithEvents cons_nomeCliente As DataGridViewTextBoxColumn
    Friend WithEvents cons_cpf As DataGridViewTextBoxColumn
    Friend WithEvents cons_ativo As DataGridViewTextBoxColumn
    Friend WithEvents cons_nomeCorretor As DataGridViewTextBoxColumn
    Friend WithEvents cons_codigo As DataGridViewTextBoxColumn
    Friend WithEvents cons_uf As DataGridViewTextBoxColumn
    Friend WithEvents cons_cidade As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewButtonColumn

End Class
