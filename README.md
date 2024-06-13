# Suporte e Instalações

Este projeto utiliza a versão 8 do .NET e 12 do C#.

Nosso primeiro passo então é obter a imagem do SQL Server que será o molde para criarmos nossos containers. Para isto, executamos o comando abaixo.

* docker pull mcr.microsoft.com/mssql/server

## Rodando o SQL Server
Para executar esta imagem você pode usar a linha abaixo.

* docker run --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=PedroAdmin@0301" -p 1433:1433 -d mcr.microsoft.com/mssql/server

## Connection String
Se você utilizou as mesmas configurações deste projeto, sua Connection String será igual abaixo. Caso necessário, modifique as informações que alterou na execução dos containers.

Server=localhost,1433;Database=balta;User ID=sa;Password=PedroAdmin@0301;

### Erros comuns
- A connection was successfully established with the server, but then an error occurred during the pre-login handshake. (provider: SSL Provider
Nas novas versões da imagem do SQL Server, no Windows, tem ocorrido um problema de SSL. Para resolver este problema, primeiro execute os seguintes comandos:

* dotnet dev-certs https --clean
* dotnet dev-certs https --trust
  
Feito isto, os certificados HTTPS do .NET estarão atualizados e funcionais. Desta forma, adicione os parâmetros Trusted_Connection e TrustServerCertificate na sua Connection String como mostrado abaixo:

Server=localhost,1433;Database=balta;User ID=sa;Password=PedroAdmin@0301;Trusted_Connection=False; TrustServerCertificate=True;
