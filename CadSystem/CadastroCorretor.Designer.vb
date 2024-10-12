<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroCorretor
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
        txtNome = New TextBox()
        txtCodigo = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        mskCPF = New MaskedTextBox()
        btnConfirmar = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(68, 41)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(120, 23)
        txtNome.TabIndex = 19
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(68, 12)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(120, 23)
        txtCodigo.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 17
        Label2.Text = "Nome:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 16
        Label1.Text = "Código:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 20
        Label3.Text = "CPF:"
        ' 
        ' mskCPF
        ' 
        mskCPF.Location = New Point(68, 70)
        mskCPF.Mask = "000.000.000.00"
        mskCPF.Name = "mskCPF"
        mskCPF.Size = New Size(120, 23)
        mskCPF.TabIndex = 21
        ' 
        ' btnConfirmar
        ' 
        btnConfirmar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnConfirmar.Location = New Point(211, 14)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(75, 23)
        btnConfirmar.TabIndex = 22
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(211, 56)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 23
        btnClose.Text = "Cancelar"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' CadastroCorretor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(301, 109)
        Controls.Add(btnClose)
        Controls.Add(btnConfirmar)
        Controls.Add(mskCPF)
        Controls.Add(Label3)
        Controls.Add(txtNome)
        Controls.Add(txtCodigo)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "CadastroCorretor"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastro Corretor..."
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mskCPF As MaskedTextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnClose As Button
End Class
