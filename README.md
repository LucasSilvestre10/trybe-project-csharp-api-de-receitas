
#  API de Receitas

## Descrição do Projeto

Este repositório contém a implementação do projeto API de Receitas, desenvolvido em ASP.NET. O objetivo é criar uma API funcional para um aplicativo de Receitas, permitindo operações como consulta, adição, remoção e atualização de receitas, bem como manipulação de dados de usuários e comentários.

### Requisitos Concluídos

1. **Endpoint GET /recipe**
   - Acessível através do URL /recipe.
   - Corpo da requisição vazio.
   - Manipulação de dados pela service /Services/RecipeService.cs.
   - Retorno esperado com status http 200 e lista de receitas.

2. **Endpoint GET /recipe/:name**
   - Acessível através do URL /recipe/:name.
   - Consulta de uma receita pelo nome.
   - Corpo da requisição vazio.
   - Retorno esperado com status http 200 se a receita for encontrada, ou http 404 se não encontrar.

3. **Endpoint POST /recipe**
   - Acessível através do URL /recipe.
   - Corpo da requisição seguindo o formato especificado.
   - Manipulação de dados pela service /Services/RecipeService.cs.
   - Retorno esperado com status http 201 e dados da receita adicionada.

4. **Endpoint PUT /recipe**
   - Acessível através do URL /recipe.
   - Corpo da requisição seguindo o formato especificado.
   - Manipulação de dados pela service /Services/RecipeService.cs.
   - Retorno esperado com status http 204 em caso de sucesso ou http 400 em caso de erro.

5. **Endpoint DEL /recipe/:name**
   - Acessível através do URL /recipe/:name.
   - Consulta de uma receita pelo nome.
   - Corpo da requisição vazio.
   - Manipulação de dados pela service /Services/RecipeService.cs.
   - Retorno esperado com status http 204 se a receita for removida, ou http 404 se não encontrar.

6. **Endpoint GET /user/:email**
   - Acessível através do URL /user/:email.
   - Consulta de uma pessoa usuária pelo e-mail.
   - Corpo da requisição vazio.
   - Manipulação de dados pela service /Services/UserService.cs.
   - Retorno esperado com status http 200 se a pessoa usuária for encontrada, ou http 404 se não encontrar.

7. **Endpoint POST /user**
   - Acessível através do URL /user.
   - Corpo da requisição seguindo o formato especificado.
   - Manipulação de dados pela service /Services/UserService.cs.
   - Retorno esperado com status http 201 e dados da pessoa usuária adicionada.

8. **Endpoint PUT /user/:email**
   - Acessível através do URL /user/:email.
   - Corpo da requisição seguindo o formato especificado.
   - Manipulação de dados pela service /Services/UserService.cs.
   - Retorno esperado com status http 200 em caso de sucesso, http 404 se não encontrar, ou http 400 se tentar atualizar o e-mail.

9. **Endpoint DEL /user/:email**
   - Acessível através do URL /recipe/:email.
   - Consulta de uma pessoa usuária pelo e-mail.
   - Corpo da requisição vazio.
   - Manipulação de dados pela service /Services/UserService.cs.
   - Retorno esperado com status http 204 se a pessoa usuária for removida, ou http 404 se não encontrar.

10. **Endpoint POST /comment**
    - Acessível através do URL /comment.
    - Corpo da requisição seguindo o formato especificado.
    - Manipulação de dados pela service /Services/CommentService.cs.
    - Retorno esperado com status http 201 e dados do comentário adicionado.

11. **Endpoint GET /comment/:recipeName**
    - Acessível através do URL /comment/:recipeName.
    - Consulta de comentários pelo nome da receita.
    - Corpo da requisição vazio.
    - Manipulação de dados pela service /Services/CommentService.cs.
    - Retorno esperado com status http 200 e lista de comentários.

## Habilidades Técnicas

- **Linguagem:**
  - C#

- **Framework:**
  - ASP.NET

- **Banco de Dados:**
  - Não especificado (conforme necessidade do projeto).

- **Outras Ferramentas:**
  - Git, Visual Studio, ASP.NET Core.
