Imports System.Data.SqlClient
Imports CadSystem.Lybrary

Public Class CadastroCorretor
    Private ReadOnly _connection As New SqlConnection(New ConnectionDb().ConnectionString)
    Private ReadOnly _insert As New QueriesCorretor
    Dim dialog
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub IsControlEmpty()
        If String.IsNullOrWhiteSpace(txtCodigo.Text) Or
           String.IsNullOrWhiteSpace(txtNome.Text) Or
           String.IsNullOrWhiteSpace(mskCPF.Text) Then
            MessageBox.Show("Campo obrigatório, Todos os campos devem estar preenchidos.", "Aviso (T-T)", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        Else
            dialog = DialogResult.OK
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            IsControlEmpty()

            _connection.Open()
            Dim inserir = _insert.Inserir

            inserir += $"('{txtCodigo.Text}','{txtNome.Text}','{mskCPF.Text.Replace(",", ".")}')"

            Using commit As New SqlCommand(inserir, _connection)
                commit.ExecuteNonQuery()
            End Using
            _connection.Close()

        Catch ex As Exception

        Finally
            If dialog = DialogResult.OK Then
                Close()
            End If
        End Try
    End Sub
End Class