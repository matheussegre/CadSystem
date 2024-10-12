Imports CadSystem.Lybrary
Imports System.Data.SqlClient

Public Class CadastroCliente
    Private ReadOnly _connection As New SqlConnection(New ConnectionDb().ConnectionString)
    Private ReadOnly _dbCorretor As New QueriesCorretor
    Private ReadOnly _querie = New Queries
    Private ReadOnly _dbClientes = New QueriesClientes
    Private cidade = New DataTable
    Private estado = New DataTable
    Private corretor = New DataTable
    Dim dt As New DataTable()
    Dim dialog

    Public Sub New()
        InitializeComponent()
        Consultas()
    End Sub

    Private Sub CadastroCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboEstado.DataSource = estado
        cboEstado.DisplayMember = "nome"
        cboEstado.ValueMember = "id"
        cboEstado.SelectedIndex = -1

        cboCorretor.DataSource = corretor
        cboCorretor.DisplayMember = "nome"
        cboCorretor.ValueMember = "id"
        cboCorretor.SelectedIndex = -1
    End Sub

    Private Sub Consultas()
        _connection.Open()

        GetEstado(dt)
        GetCorretor(dt)

        _connection.Close()
    End Sub
    Private Sub GetCidade(dt As DataTable, query As String)
        Dim cidades As New SqlDataAdapter(query, _connection)
        cidades.Fill(cidade)
    End Sub

    Private Sub GetEstado(dt As DataTable)
        Dim estados As New SqlDataAdapter(_querie.GetEstado, _connection)
        estados.Fill(estado)
    End Sub

    Private Sub GetCorretor(dt As DataTable)
        Dim corretores As New SqlDataAdapter(_dbCorretor.Consultar, _connection)
        corretores.Fill(corretor)
    End Sub

    Private Sub IsControlEmpty()
        If String.IsNullOrWhiteSpace(cboCorretor.Text) Or
           String.IsNullOrWhiteSpace(txtNome.Text) Or
           String.IsNullOrWhiteSpace(mskCPF.Text) Or
           String.IsNullOrWhiteSpace(txtEndereco.Text) Or
           String.IsNullOrWhiteSpace(cboCidade.Text) Or
           String.IsNullOrWhiteSpace(cboEstado.Text) Then
            MessageBox.Show("Campo obrigatório, Todos os campos devem estar preenchidos.", "Aviso (T-T)", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        Else
            dialog = DialogResult.OK
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            IsControlEmpty()

            Dim Ativo = 0

            If chkAtivo.Checked Then
                Ativo = 1
            End If

            _connection.Open()
            Dim inserir = _dbClientes.Inserir

            inserir += $"('{txtNome.Text}','{mskCPF.Text.Replace(",", ".")}','{txtEndereco.Text}','{cboEstado.SelectedValue}','{cboCidade.SelectedValue}',{Ativo}, {cboCorretor.SelectedValue})"

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

    Private Sub CadastroCliente_TextChanged(sender As Object, e As EventArgs) Handles MyBase.Leave, cboEstado.Leave
        cidade.Clear()

        Dim query = _dbClientes.GetCidadeByUf
        query += $" WHERE cidade.uf = {cboEstado.SelectedValue}"

        _connection.Open()
        GetCidade(dt, query)
        _connection.Close()

        cboCidade.DataSource = cidade
        cboCidade.DisplayMember = "nome"
        cboCidade.ValueMember = "id"
        cboCidade.SelectedIndex = -1
    End Sub
End Class