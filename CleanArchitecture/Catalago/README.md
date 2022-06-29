# Introdução
Projeto de apresentação do Clean Architecture. Consiste em uma API de Catalago e Produtos com CRUD básico.

# Especificação técnica
## Linguagem
C#
## Banco de dados
Microsoft SQL Server
### Comandos do EF Tools por CLI
```
dotnet ef migrations add Initial -s Catalogo.API -p Catalogo.Infrastructure
dotnet ef database update -s Catalogo.API -p Catalogo.Infrastructure
```
## Framework
ASP.NET Core 6.0 Web API