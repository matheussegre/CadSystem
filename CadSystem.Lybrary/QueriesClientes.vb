Public Class QueriesClientes
    Public Property Inserir = "INSERT INTO dbo.cliente(nome,cpf,endereco,uf,cidade,ativo,idCorretor) VALUES"

    Public Property GetCidadeByUf = "SELECT cidade.nome, cidade.id FROM cidade INNER JOIN uf ON cidade.uf = uf.id"
End Class
