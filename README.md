PT-BR - Esse projeto foi feito primeiramente acompanhando uma aula da udemy, depois continuei fazendo alterações e criando coisas nele sozinho pra aprender. O maior objetivo aqui foi aprender mais sobre a arquitetura MVC usando C#.
Eu parei de desenvolver nele para usar o escopo dele em um novo projeto integrado com o angular, a versão da sdk e do aspnet que usei aqui não são compatíveis.

EN - This project was initially created while following a Udemy course. Later, I continued making modifications and adding things to it on my own to learn. The main goal here was to learn more about the MVC architecture using C#. I stopped developing it to use its scope in a new project integrated with Angular. The versions of the SDK and ASP.NET that I used here are not compatible.

--PACKAGES USED: / PACOTES USADOS:
EN - INDENTITY FOR USER LOGIN, REGISTER AND RECOVERY. ENTITY FOR THE DATABASE SCHEMA AND QUERIES, SENDGRID FOR PASS RECOVERY AND SERILOG TO TRACE 
THE ERRORS AND BUGS. THE DATABASE USED WAS MYSQL. 

PT-BR - IDENTITY PRO LOGIN, REGISTRO E RECUPERAÇÃO DE SENHA DOS USUÁRIOS. ENTITY FOI USADO PARA FAZER TODAS AS QUERIES E RELAÇÕES
ENTRE AS TABELAS. SENDGRID FOI USADO PRA RECUPERAÇÃO DE SENHA VIA EMAIL E SERILOG PARA INCLUIR LOGS NO PROJETO.

<img width="349" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/f291c324-9146-4bac-831e-558e36981b95">

LOGIN PAGE: / PÁGINA DE LOGIN:

<img width="960" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/bf91b494-90d7-4df2-9304-e5d2fea7ea0f">

PT-BR -ESSA PÁGINA POSSUI VALIDAÇÃO DO LADO CLIENT, E O CHECKBOX "LEMBRAR" SE FOR SELECIONADA ESTABELECE UMA SESSÃO DE 3 DIAS, MANTENDO O USUÁRIO CONECTADO, SE ASSIM O DESEJAR.

EN - This page has client-side validation, and the 'Remember' checkbox, when selected, establishes a session for 3 days, keeping the user logged in if they wish.

REGISTER PAGE: / PÁGINA DE REGISTRO:

<img width="960" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/9f482280-743c-42ea-8ddb-93bdfb9d2caf">

PASS RECOVERY: / RECUPERAÇÃO DE SENHA:

<img width="960" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/580add73-c880-4c9a-9c72-1239b698da8a">

PT-BR- ESSA PÁGINA CONFERIA SE O E-MAIL ESTAVA REGISTRADO NO BANCO DE DADOS, E DEPOIS CRIAVA UMA CHAVE TEMPORÁRIA DE RECUPERAÇÃO DE SENHA QUE REDIRECIONAVA PRA TELA DE ALTERAÇÃO. PARA ISSO, FOI USADO A API GRÁTIS SENDGRID.

EN - This page checked if the email was registered in the database and then created a temporary password recovery key that redirected to the password change screen. For this, the free SendGrid API was used.

SALES RECORDS: / REGISTRO DE VENDAS:

<img width="960" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/bdc999a7-00a6-4076-8243-4080ea9bd3bc">

PT-BR - ESSA PÁGINA CONTÉM O REGISTRO DE TODAS AS VENDAS. EXISTEM DOIS FILTROS: FILTRO SIMPLES POR DATA, E FILTRO AGRUPADO QUE FILTRA AS VENDAS POR DEPARTAMENTO/LOJA.
TODA VENDA POSSUI STATUS, COLEÇÃO DE PRODUTOS E O VALOR É COMPOSTO PELO PREÇO TOTAL DE TODOS OS PRODUTOS.

EN - This page contains the record of all sales. There are two filters: a simple filter by date and a grouped filter that filters sales by department/store. Every sale has a status, a collection of products, and the value is composed of the total price of all products.

GROUPED FILTER: / FILTRO AGRUPADO:

<img width="960" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/253f72c0-ea34-4c4c-936b-cf7b585a6b26">

SIMPLE FILTER: / FILTRO SIMPLES:

<img width="960" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/d4a71460-92b9-41b0-8bc0-aad140d90f71">

CREATE SALES RECORDS / CREATE REGISTRO DE VENDAS

<img width="960" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/4f556396-d2ab-404b-9a66-40a4536c7a58">

PT-BR - EU USEI REGEX PARA FAZER UMA BUSCA SIMPLES NOS PRODUTOS, QUANDO SELECIONADOS ELES VÃO PARA UMA LISTA DE SELEÇÃO, QUE FAZ A COMPOSIÇÃO DA VENDA. AO TIRAR A SELEÇÃO, O PRODUTO É REMOVIDO, E O PREÇO TAMBÉM É ALTERADO. O DEPARTAMENTO DA VENDA É DEFINIDO PARA O MESMO QUE O VENDEDOR QUE FEZ A VENDA.

EN - I used regex to perform a simple search in the products. When selected, they are added to a selection list, which constitutes the sale. When deselected, the product is removed, and the price is also updated. The department of the sale is set to the same as the seller who made the sale.

EDIT: / EDITAR:

<img width="959" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/5a75595f-333e-43ec-8c10-733dece813ef">

DELETE: / DELETAR:

<img width="960" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/78ac7363-7674-4f4a-8c95-8f319275d6df">

**PT-BR - NÃO VOU COLOCAR TODOS OS EDITAR, CRIAR E DELETAR POIS SÃO TODOS IGUAIS.
**EN - I WON'T SHOW ALL THE EDIT, CREATE AND DELETE PAGES BECAUSE THEY'RE ALL EQUAL.

CATEGORIES: / CATEGORIAS:

<img width="959" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/6abc131b-ffe7-44a6-8798-69da1add60dd">

DEPARTMENTS: / DEPARTAMENTOS:

<img width="960" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/7553c687-e374-4ff9-b62a-671a73326cff">

PRODUCTS: / PRODUTOS:

<img width="959" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/4b1a5e07-e08d-4d28-b80e-a29cf9536c22">

SELLERS: / VENDEDORES

<img width="960" alt="image" src="https://github.com/gstx2000/WebSalesMvc/assets/103541526/94e9fe23-99e1-4e71-ab9b-944ed8148104">

/


