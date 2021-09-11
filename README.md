# 🔐 API ASP.NET Core segura com autenticação JWT
## A Necessidade de proteger APIs

Como os WebApis não têm estado, a proteção deles não pode depender das sessões do servidor. Cada solicitação ao terminal da API em questão deve conter credenciais como dados que autenticam / autorizam especificamente os usuários a acessar os dados da API. Essas credenciais, como dados, geralmente são colocadas nos cabeçalhos HTTP da mensagem de solicitação. Existem várias maneiras de autenticar a API ASP.NET Core. Neste guia, vamos construir uma API ASP.NET Core segura com autenticação JWT.

 vamos gerar nosso banco de dados. Execute os seguintes comandos no console do gerenciador de pacotes para aplicar as migrações.
 
 ``` 
 update-database
 ```

Este repositório foi criado com proposito de implementar e testar o exemplo do artigo . Segue o link do artigo https://codewithmukesh.com/blog/aspnet-core-api-with-jwt-authentication/

![cover](https://codewithmukesh.com/wp-content/uploads/2020/05/jwt-token-postman.png?ezimgfmt=ng:webp/ngcb32?style=flat)
