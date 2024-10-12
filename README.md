# CadSystem

# Instalação

## Requisitos:

- Visual Studio
- SQLServer Express

## Steps

Primeiro clone o repositório:
```sh
git clone https://github.com/matheussegre/CadSystem.git
```

Após clonar, para relizar a conexão com a base de dados, é necessário alterar a connectionString do aquivo ConnectionDb.vb

```vb
ConnectionString = "Data Source={SEU_SERVIDOR};Initial Catalog={NOME_DA_BASE_DE_DADOS};User ID={USUARIO_SQLSERVER};Password={SENHA_DE_ACESSO}}"
```

Feito isso já será possível usar a aplicação
