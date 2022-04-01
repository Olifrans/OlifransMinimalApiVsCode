# Minimal Api .NET 6.0
## VS Code e Dapper e Sql Server --> SqlClient



### Comando basicos dotenet

dotnet --version
dotnet new --list


# criando o projeto via linha de comando:
dotnet new webapi -minimal -o .


## Instalaçao de pacotes Nuget usado no projeto:

Swashbuckle.AspNetCore (*)

### Dapper
dotnet add package Dapper

### Dapper.Contrib
dotnet add package Dapper.Contrib

### System.Data.SqlClient
dotnet add package System.Data.SqlClient


# Sobre  o DB

## Criando o DB
create database CadastroDB

## Única tabela



CREATE TABLE Tarefas( 
Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Atividade nvarchar(150) NULL,
Status nvarchar(150) NULL
)
GO


# Resetar a tabela
truncate table Tarefas