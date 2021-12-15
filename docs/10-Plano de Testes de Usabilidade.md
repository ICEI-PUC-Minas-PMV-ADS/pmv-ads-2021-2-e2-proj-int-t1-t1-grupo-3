# Plano de Testes de Usabilidade

|Teste|T01 - Acesso aos produtos da empresa|
|:---:|---|
|Requisitos|RF05 O site deve permitir visualizar as informações de empreendedores: produtos e serviços oferecidos.|
|Objetivo do Teste|Analisar a projeção correta da interface da empresa, seus dados e produtos.|
|Passos|1-Entrar no endereço do site.|
||2-Acessar a opção de login na página inicial.|
||3-Realizar o login com o usuário e senha.|
||4-Selecionar o box de empresas associadas.|
|Critérios de Êxito|A plataforma deve apresentar de forma coerente e organizada a página da empresa com os respectivos produtos e informações dos mesmos.|
|Observações|

|Teste|T02 - Acesso a tela inicial da plataforma|
|:---:|---|
|Requisitos|RF01 O site deve apresentar na página principal com a identificação do usuário do sistema e senha de acesso.|
|Objetivo do Teste|Analisar a projeção correta da interface da empresa (home), contendo descrição do que consiste o negócio e os botões de registro e login.|
|Passos|1-Entrar no endereço do site.|
|Critérios de Êxito|A plataforma deve apresentar de forma coerente e organizada a página home do projeto, contendo informações relevantes do que consiste e as opções de cadastro e login para quem já é cadastrado.|
|Observações|

|Teste|T03 - Fazer cadastro|
|:---:|---|
|Requisitos|RF02 O site deve apresentar visão dos dados relevantes para cadastro de clientes.|
||RF01	O site deve apresentar na página principal com a identificação do usuário do sistema e senha de acesso.|
|Objetivo do Teste|Verificar a usabilidade e projeção do sistema de cadastro da plataforma.|
|Passos|1-Acessar o navegador|
||2-Informar a url do site|
||3-Abrir a página inicial|
||4-Selecionar a opção de cadastro|
||5-Inserir as informações pessoais|
||6-Clicar em “Cadastrar”|
|Critérios de Êxito|A plataforma deve retornar uma pop-up de confirmação do cadastro. Sendo assim, o cliente já pode realizar o login na plataforma com as informações inseridas no cadastro.|
|Observações|

|Teste|T04 - Fazer login|
|:---:|---|
|Requisitos|RF02 O site deve apresentar visão dos dados relevantes para cadastro de clientes.|
||RF01	O site deve apresentar na página principal com a identificação do usuário do sistema e senha de acesso.|
|Objetivo do Teste|Verificar a usabilidade e projeção do sistema de login da plataforma. |
|Passos|1-Acessar o navegador|
||2-Informar a url do site|
||3-Abrir a página inicial|
||4-Selecionar a opção de login|
||5-Inserir usuário e senha|
||6-Clicar em “Entrar”|
|Critérios de Êxito|O sistema retorna a página da empresa ou a página de pesquisa de empresas, a depender do tipo de usuário, podendo ser empresa ou cliente.|
|Observações|

|Teste|T05- Inserir Produtos (Empresa).|
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

|Teste|T06 - Pesquisar serviços e produtos (Cliente).|
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

|Teste|T07 - Editar informações de perfil|
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


O teste de usabilidade permite avaliar a qualidade da interface com o usuário da aplicação interativa. O Plano de Testes de Software é gerado a partir da especificação do sistema e consiste em casos de testes que deverão ser executados quando a implementação estiver parcial ou totalmente pronta.
