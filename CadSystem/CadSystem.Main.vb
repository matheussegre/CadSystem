Imports System.Data.SqlClient
Imports CadSystem.Lybrary

Public Class CadSystem

    Private ReadOnly _querie = New Queries
    Private ReadOnly _connection As New SqlConnection(New ConnectionDb().ConnectionString)
    Private cidade = New DataTable
    Private estado = New DataTable
    Dim dt As New DataTable()

    Public Sub New()
        InitializeComponent()
        Consultas()

        dgvConsulta.AllowUserToAddRows = False
    End Sub

    Private Sub Consultas()
        Try
            _connection.Open()

            GetCidade(dt)
            GetEstado(dt)

            _connection.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CadSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cboCidade.DataSource = cidade
            cboCidade.DisplayMember = "nome"
            cboCidade.ValueMember = "id"
            cboCidade.SelectedIndex = -1

            cboEstado.DataSource = estado
            cboEstado.DisplayMember = "nome"
            cboEstado.ValueMember = "id"
            cboEstado.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GetCidade(dt As DataTable)
        Dim cidades As New SqlDataAdapter(_querie.GetCidade, _connection)
        cidades.Fill(cidade)
        cidade.Rows.InsertAt(cidade.NewRow(), 0)
    End Sub

    Private Sub GetEstado(dt As DataTable)
        Dim estados As New SqlDataAdapter(_querie.GetEstado, _connection)
        estados.Fill(estado)
        estado.Rows.InsertAt(estado.NewRow(), 0)
    End Sub

    Private Sub btnCadastroCorretor_Click(sender As Object, e As EventArgs) Handles btnCadastroCorretor.Click
        Try
            Dim cadastroCorretor = New CadastroCorretor()

            cadastroCorretor.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cadastroCliente = New CadastroCliente()
        cadastroCliente.Show()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Try
            Dim query As String = _querie.Consulta

            query = Filtros(query)

            _connection.Open()

            Dim consulta As New SqlDataAdapter(query, _connection)

            Dim dataTable As New DataTable()

            consulta.Fill(dataTable)

            dgvConsulta.DataSource = dataTable

            _connection.Close()
        Catch ex As Exception
            MessageBox.Show("Não foi possível realizar a conexão com o banco de dados.", "Aviso (T-T)", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Function Filtros(query As String) As String
        If String.IsNullOrWhiteSpace(txtCodCorretor.Text) = False Then
            query += If(LCase(query) Like "*where*",
                $" AND cor.codigo = {txtCodCorretor.Text}",
                $"WHERE cor.codigo = {txtCodCorretor.Text}")
        End If

        If String.IsNullOrWhiteSpace(txtNomeCorretor.Text) = False Then
            query += If(LCase(query) Like "*where*",
               $" AND cor.nome = {txtNomeCorretor.Text}",
               $"WHERE cor.nome = {txtNomeCorretor.Text}")
        End If

        If String.IsNullOrWhiteSpace(txtNomeCliente.Text) = False Then
            query += If(LCase(query) Like "*where*",
                $" AND c.nome = {txtNomeCliente.Text}",
                $"WHERE c.nome = {txtNomeCliente.Text}")
        End If

        If String.IsNullOrWhiteSpace(txtCpfCliente.Text) = False Then
            query += If(LCase(query) Like "*where*",
                $" AND c.cpf = {txtCpfCliente.Text.Replace(",", ".")}",
                $"WHERE c.cpf = {txtCpfCliente.Text.Replace(",", ".")}")
        End If

        If String.IsNullOrWhiteSpace(cboCidade.Text) = False Then
            query += If(LCase(query) Like "*where*",
                $" AND cid.id = {cboCidade.SelectedValue}",
                $"WHERE cid.id = {cboCidade.SelectedValue}")
        End If

        If String.IsNullOrWhiteSpace(cboEstado.Text) = False Then
            query += If(LCase(query) Like "*where*",
                $" AND uf.id = {cboEstado.SelectedValue}",
                $"WHERE uf.id = {cboEstado.SelectedValue}")
        End If

        If chkAtivo.Checked Then
            query += If(LCase(query) Like "*where*",
                $" AND c.ativo = {1}",
                $"WHERE c.ativo = {1}")
        End If

        Filtros = query
    End Function

    Private Sub dgvConsulta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellClick
        If e.ColumnIndex = dgvConsulta.Columns("delete").Index Then
            Dim delete As String = _querie.DELETE
            delete += $" WHERE id = {dgvConsulta.Rows(e.RowIndex).Cells("cons_id").Value}"

            _connection.Open()
            Using commit As New SqlCommand(delete, _connection)
                commit.ExecuteNonQuery()
            End Using
            _connection.Close()

            dgvConsulta.Rows.RemoveAt(e.RowIndex)

        End If
    End Sub
End Class
