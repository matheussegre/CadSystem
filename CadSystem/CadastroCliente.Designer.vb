<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroCliente
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
        cboCorretor = New ComboBox()
        Label1 = New Label()
        mskCPF = New MaskedTextBox()
        Label3 = New Label()
        txtNome = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        cboEstado = New ComboBox()
        Label5 = New Label()
        cboCidade = New ComboBox()
        btnClose = New Button()
        btnConfirmar = New Button()
        txtEndereco = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        chkAtivo = New CheckBox()
        SuspendLayout()
        ' 
        ' cboCorretor
        ' 
        cboCorretor.DropDownStyle = ComboBoxStyle.DropDownList
        cboCorretor.FormattingEnabled = True
        cboCorretor.Location = New Point(72, 12)
        cboCorretor.Name = "cboCorretor"
        cboCorretor.Size = New Size(305, 23)
        cboCorretor.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 1
        Label1.Text = "Corretor:"
        ' 
        ' mskCPF
        ' 
        mskCPF.Location = New Point(72, 75)
        mskCPF.Mask = "000.000.000.00"
        mskCPF.Name = "mskCPF"
        mskCPF.Size = New Size(121, 23)
        mskCPF.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 24
        Label3.Text = "CPF:"
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(72, 46)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(121, 23)
        txtNome.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 22
        Label2.Text = "Nome:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(226, 49)
        Label4.Name = "Label4"
        Label4.Size = New Size(24, 15)
        Label4.TabIndex = 27
        Label4.Text = "UF:"
        ' 
        ' cboEstado
        ' 
        cboEstado.FormattingEnabled = True
        cboEstado.Location = New Point(256, 46)
        cboEstado.Name = "cboEstado"
        cboEstado.Size = New Size(121, 23)
        cboEstado.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(203, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 15)
        Label5.TabIndex = 29
        Label5.Text = "Cidade:"
        ' 
        ' cboCidade
        ' 
        cboCidade.FormattingEnabled = True
        cboCidade.Location = New Point(256, 78)
        cboCidade.Name = "cboCidade"
        cboCidade.Size = New Size(121, 23)
        cboCidade.TabIndex = 28
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(256, 159)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 31
        btnClose.Text = "Cancelar"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnConfirmar
        ' 
        btnConfirmar.Location = New Point(81, 159)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(75, 23)
        btnConfirmar.TabIndex = 30
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.UseVisualStyleBackColor = True
        ' 
        ' txtEndereco
        ' 
        txtEndereco.Location = New Point(72, 107)
        txtEndereco.Name = "txtEndereco"
        txtEndereco.Size = New Size(178, 23)
        txtEndereco.TabIndex = 33
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(4, 110)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 15)
        Label6.TabIndex = 32
        Label6.Text = "Endereço: "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(256, 112)
        Label7.Name = "Label7"
        Label7.Size = New Size(40, 15)
        Label7.TabIndex = 34
        Label7.Text = "Ativo?"
        ' 
        ' chkAtivo
        ' 
        chkAtivo.AutoSize = True
        chkAtivo.Location = New Point(298, 113)
        chkAtivo.Name = "chkAtivo"
        chkAtivo.Size = New Size(15, 14)
        chkAtivo.TabIndex = 35
        chkAtivo.UseVisualStyleBackColor = True
        ' 
        ' CadastroCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(396, 203)
        Controls.Add(chkAtivo)
        Controls.Add(Label7)
        Controls.Add(txtEndereco)
        Controls.Add(Label6)
        Controls.Add(btnClose)
        Controls.Add(btnConfirmar)
        Controls.Add(Label5)
        Controls.Add(cboCidade)
        Controls.Add(Label4)
        Controls.Add(cboEstado)
        Controls.Add(mskCPF)
        Controls.Add(Label3)
        Controls.Add(txtNome)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cboCorretor)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "CadastroCliente"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastrar Cliente..."
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboCorretor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mskCPF As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboCidade As ComboBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chkAtivo As CheckBox
End Class
