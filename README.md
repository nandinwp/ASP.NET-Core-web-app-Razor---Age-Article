# ASP.NET Core Web App Razor - Age Article
Este projeto é uma aplicação web simples desenvolvida com ASP.NET Core, Razor Pages, Entity Framework (EF), e SQLite3. A aplicação simula um artigo que explora a influência da idade na tomada de decisões e no respeito, particularmente no contexto de aceitar conselhos de pessoas mais jovens.

# Funcionalidades
* Pesquisa de Opinião:
   Usuários podem participar de uma pesquisa onde informam sua idade, se concordam ou não com a afirmação proposta, e têm a opção de argumentar sua resposta.
* Banco de Dados:
  Utiliza Entity Framework com SQLite para armazenar os dados das respostas dos usuários.
* Interface de Usuário:
    Desenvolvida com Bootstrap para proporcionar uma experiência amigável e responsiva.
* Notificação de Sucesso:
   Após a votação, o usuário recebe uma mensagem de sucesso via modal, agradecendo pela participação.
# Tecnologias Utilizadas
* ASP.NET Core:
  Framework para construção de aplicações web.
* Razor Pages:
   Para a criação de interfaces de usuário dinâmicas.
* Entity Framework Core:
   ORM para interagir com o banco de dados SQLite.
* SQLite:
   Banco de dados leve e eficiente para armazenar as respostas da pesquisa.
* Bootstrap:
   Framework de front-end para um design moderno e responsivo.
# Como Executar
### Clone o repositório:

exemplo:

* git bash
  ```sh
  git clone https://github.com/nandinwp/ASP.NET-Core-web-app-Razor---Age-Article.git
  ```

### Navegue até o diretório do projeto:

 ```sh
  cd ASP.NET-Core-web-app-Razor---Age-Article
  ```

### Restaure as dependências:
* No terminal do visual studio

 ```sh
  dotnet restore
  ```

### Execute as migrações para configurar o banco de dados:

* No terminal do visual studio

 ```sh
  dotnet ef database update
  ```

### Inicie a aplicação:

* No terminal do visual studio

 ```sh
  dotnet run
  ```
