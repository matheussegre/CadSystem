Public Class Queries
	Public Property Consulta = "SELECT c.id cons_id, c.nome cons_nomeCliente, c.cpf cons_cpf, IIF(c.ativo = 1, 'Sim', 'Não') cons_ativo, 
									   cor.nome cons_nomeCorretor, cor.codigo cons_codigo, uf.nome cons_uf, 
									   cid.nome cons_cidade 
								  FROM cliente c LEFT JOIN corretor cor ON cor.id = c.idCorretor
												 INNER JOIN uf ON c.uf = uf.id
												 INNER JOIN cidade cid ON c.cidade = cid.id "

	Public Property DELETE = "DELETE FROM dbo.cliente"

	Public Property GetCidade = "SELECT * FROM cidade"
	Public Property GetEstado = "SELECT * FROM uf"
End Class
