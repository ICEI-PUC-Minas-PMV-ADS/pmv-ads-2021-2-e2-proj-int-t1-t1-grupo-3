# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

|Teste|T01 - Fazer Cadastro|
|:---:|---|
|Requisitos|RF-08 - O site deve possuir cadastro intuitivo facilitando para o usuário.|
||RF-18 - A plataforma deve possuir opção de cadastro para os clientes e os empreendedores.|
|Objetivo do Teste|Analisar o sistema de cadastro da plataforma.|
|Passos|1-Acessar o navegador|
||2-Informar a url do site|
||3-Abrir a página inicial|
||4-Selecionar a opção de cadastro|
||5-Inserir as informações pessoais|
||6-Clicar em “Cadastrar”|
|Critérios de Êxito|O site deve carregar a página inicial sem falhas, projetando a tela corretamente.|
||O botão de cadastro deve redirecionar ao formulário corretamente.|
||Quando há a inserção de todas as informações obrigatórias, o sistema registra os dados do usuário com sucesso.|

|Teste|T02- Receber informações da empresa(Cliente)|
|:---:|---|
|Requisitos|RF-15 - O site deve possuir a opção de favoritar e desfavoritar uma empresa.|
||RF-17 - O cliente deve ter a opção de aceitar ou negar as mensagens e notificações por parte do empreendedor.|
|Objetivo do Teste|Testar a opção de receber mais informações da empresa.|
|Passos|1-Entrar no endereço do site.|
||2-Acessar a opção de login na página inicial.|
||3-Realizar o login com o usuário e senha.|
||4-Acessar o feed de empreendedores.|
||5-Selecionar o campo de pesquisa.|
||6-Digitar a categoria desejada.|
||7-Abrir a página da empresa.|
||8-Marcar o campo de receber informações.|
|Critérios de Êxito|A página retorna uma mensagem de ação concluída com sucesso.|
||O cliente recebe uma mensagem em seu email, confirmando a aceitação em receber mais informações.|

|Teste|T03- Acessar as empresas já associadas.|
|:---:|---|
|Requisitos|RF-20 - O sistema deve possuir um campo onde estão as empresas já aprovadas e associadas ao cliente.|
||RF-05 - O site deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar uma empresa, projeto e interações.|
|Objetivo do Teste|Analisar a funcionalidade de seleção das empresas já aprovadas.|
|Passos|1-Entrar no endereço do site.|
||2-Acessar a opção de login na página inicial.|
||3-Realizar o login com o usuário e senha.|
||4-Selecionar o box de empresas associadas.|
|Critérios de Êxito|A plataforma deve projetar uma lista com todos os empresas já associados em algum determinado período|

|Teste|T04- Inserir Produtos [Empresa].|
|:---:|---|
|Requisitos|RF-06 - O site deve permitir visualizar as informações de empreendedores: produtos e serviços oferecidos.|
||RF-21 - A plataforma deve dispor de campo para adição de produtos e serviços.|
|Objetivo do Teste|Analisar a funcionalidade de adicionar produtos e serviços.|
|Passos|1-Entrar no endereço do site.|
||2-Acessar a opção de login na página inicial.|
||3-Realizar o login com o usuário e senha.|
||4-Selecione a opção de “Inserir produtos”|
||5-Preencha o formulário, inserindo descrição e imagens do respectivo produto ou serviço.|
|Critérios de Êxito|A plataforma deve registrar corretamente as informações inseridas em um novo box de produto.|
||O site deve guardar esse produto no catálogo de ofertas da empresa.|
