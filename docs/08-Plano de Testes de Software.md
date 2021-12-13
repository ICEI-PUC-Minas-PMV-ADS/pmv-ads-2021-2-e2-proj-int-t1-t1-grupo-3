# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

|Teste|T01 - Fazer Cadastro|
|:---:|---|
|Requisitos|RF-08 - O site deve possuir cadastro intuitivo facilitando para o usuário.|
||RF-18 - A plataforma deve possuir opção de cadastro para os clientes e as empresas.|
|Objetivo do Teste|Verificar se o banco de dados está registrando as informações dos clientes corretamente.|
|Passos|1-Acessar o navegador|
||2-Informar a url do site|
||3-Abrir a página inicial|
||4-Selecionar a opção de cadastro|
||5-Inserir as informações pessoais|
||6-Clicar em “Cadastrar”|
|Critérios de Êxito|O site deve carregar a página inicial sem falhas, projetando a tela corretamente.|
||O botão de cadastro deve redirecionar ao formulário corretamente.|
||Quando há a inserção de todas as informações obrigatórias, o sistema registra os dados do usuário com sucesso.|
|Observações|

|Teste|T02- Inserir Produtos (Empresa).|
|:---:|---|
|Requisitos|RF010 - A plataforma deve dispor de campo para adição de produtos.|
|Objetivo do Teste|Analisar a funcionalidade de adicionar produtos e serviços. Verificar o registro das informações no banco de dados.|
|Passos|1-Entrar no endereço do site.|
||2-Acessar a opção de login na página inicial.|
||3-Realizar o login com o usuário e senha.|
||4-Selecione a opção de “Inserir produtos”|
||5-Preencha o formulário, inserindo descrição e imagens do respectivo produto ou serviço.|
|Critérios de Êxito|A plataforma deve registrar corretamente as informações inseridas em um novo box de produto.|
||O site deve guardar esse produto no catálogo de ofertas da empresa.|
|Observações|

|Teste|T03 - Pesquisar serviços e produtos (Cliente).|
|:---:|---|
|Requisitos|RF-04 - O site deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar um empreendedor, projeto e serviços.|
||RF-05 - O site deve permitir visualizar as informações de empreendedores: produtos e serviços oferecidos.|
|Objetivo do Teste|Testar a barra de pesquisa. O funcionamento da tabela de categoria das empresas.|
|Passos|1-Entrar no endereço do site.|
||2-Acessar a opção de login na página inicial.|
||3-Realizar o login com o usuário e senha.|
||4-Acessar o feed de empreendedores.|
||5-Selecionar o campo de pesquisa.|
||6-Digitar a categoria desejada.|
|Critérios de Êxito|Deve haver uma requisição dos controlers para o model, processando e retornando as empresas da respectiva categoria.|
||As empresas da categoria solicitada devem ser apresentadas na interface do usuário.|
|Observações|

|Teste|T04 - Editar informações de perfil|
|:---:|---|
|Requisitos|RF07 O sistema deve possuir a opção de remover informações.|
||RF08 O sistema deve possuir opção de edição de informações na conta.|
|Objetivo do Teste|Analisar a função de edição e alteração de informações. Verificar a requisição de update no banco de dados.|
|Passos|1-Entrar no endereço do site.|
||2-Acessar a opção de login na página inicial.|
||3-Realizar o login com o usuário e senha.|
||4-Abrir o campo de “minha conta”|
||5-Selecionar a opção de editar informações pessoais.|
||6-Realizar as alterações desejadas clicando em cima do campo, deletando e adicionando a nova informação.|
||7-Clique em salvar para concluir a ação.|
|Critérios de Êxito|O controler deve requisitar uma alteração na tabela de cadastro.|
||Os dados devem ser atualizados de acordo com a alteração feita pelo usuário.|
|Observações|


