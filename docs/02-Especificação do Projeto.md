# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

O grupo entendeu a importância da criação de uma ferramenta que suportasse de maneira prática e simples o acesso aos dados dos clientes. A partir de conversas entre as pessoas próximas aos integrantes do grupo entendemos a importância e relevância do tema, do desenvolvimento de uma ferramenta de controle de carteira de clientes.

Assim, com esta primeira verificação, decidimos criar este canal direto. As entrevistas ocorreram além do âmbito familiar, nas pessoas do convívio social. Apesar deste momento de isolamento por conta da pandemia, encontramos pessoas com interesse no tema abordado.

## Personas

As entrevistas foram feitas e as histórias contadas estão abaixo:

| ![foto 1](img/JLF.png) | **JOSÉ LUIZ FERREIRA** ||
|:---:|:---:|:---:|
||||
| **Idade:** | **Ocupação:** | **Aplicativos:** |
| 45 anos | Arquiteto e Fotógrafo | Instagram; Photoshop; Linkedin |
||||
| **Motivações:** | **Frustrações:** | **Hobbies, História:** |
| Melhorar o atendimento aos clientes; Centralizar informações de seus clientes. | Dificuldade em gerir seu banco de dados de clientes. | Formado em arquitetura, atualmente trabalhando como fotógrafo profissional. |

| ![foto 2](img/MS.png) | **MARÍLIA SANTOS** ||
|:---:|:---:|:---:|
||||
| **Idade:** | **Ocupação:** | **Aplicativos:** |
| 35 anos | Esteticista | Instagram; Photoshop; Spotify |
||||
| **Motivações:** | **Frustrações:** | **Hobbies, História:** |
| Criar carteira de clientes; Cadastrar clientes para gerar promoções. | Não saber o público alvo de seu negócio; Manter seus clientes. | Marília tem dificuldade em manter seus clientes antigos. |

| ![foto 3](img/TS.png) | **THIAGO SOUTO** ||
|:---:|:---:|:---:|
||||
| **Idade:** | **Ocupação:** | **Aplicativos:** |
| 35 anos | Contador | Instagram; Telegram; PicPay |
||||
| **Motivações:** | **Frustrações:** | **Hobbies, História:** |
| Melhorar o atendimento aos clientes; Encontrar novos clientes. | Dificuldade em encontrar Clientes. | Thiago acabou de se formar como contador e precisa de clientes novos. |

| ![foto 4](img/FA.png) | **FERNANDO ALEXANDER** ||
|:---:|:---:|:---:|
||||
| **Idade:** | **Ocupação:** | **Aplicativos:** |
| 38 anos | Barbeiro | Instagram; Twitter; Facebook |
||||
| **Motivações:** | **Frustrações:** | **Hobbies, História:** |
| Na área onde tem sua barbearia quer descobrir produtos e serviços que facilitem seu dia a dia. Como sempre faz suas refeições fora de casa, quer receber promoções de restaurantes e bares do entorno do seu local de trabalho. | Descobrir fornecedores com itens de seu interesse para receber promoções. | Tornou-se barbeiro muito novo e quer descobrir produtos e serviços na região onde atua, tem animais de estimação e adora bons restaurantes, ele é um cliente assíduo dos restaurantes da região onde trabalha. |

| ![foto 5](img/AS.png) | **ADRIANA SIQUEIRA** ||
|:---:|:---:|:---:|
||||
| **Idade:** | **Ocupação:** | **Aplicativos:** |
| 42 anos | Professora de inglês meio período. | Instagram; LInkedin; Facebook |
||||
| **Motivações:** | **Frustrações:** | **Hobbies, História:** |
| Conseguir aumentar sua renda; Conectar a fornecedores. | Conseguir dar aulas   particulares. | Cinéfila, organizada, tem 2 pets, seu tempo livre gosta de sair e conhecer pessoas, está deprimida com a pandemia. |

## Histórias de Usuários

As informações coletadas dos entrevistados:

| EU COMO... `PERSONA` | QUERO/PRECISO... `FUNCIONALIDADE` | DÚVIDAS | PARA... `MOTIVO/VALOR` |
|:--------:|-----------|---------|--------------|
| José Luiz Ferreira  ![foto 1](img/JLF.png)| Controle de clientes. | Como manter um banco de dados de clientes com fácil acesso e controle de informações relevantes para desenvolvimento do negócio de fotografias. | Melhorar o atendimento aos clientes. |
| Marília Santos  ![foto 2](img/MS.png)| Ter maior proximidade com os meus clientes. | Como manter um laço afetivo com meus clientes, de forma remota. | Fidelidade dos Clientes. |
| Thiago Souto  ![foto 3](img/TS.png)| Conquistar novos clientes. | Como conseguir mais clientes utilizando uma plataforma de gestão. | Que meus clientes atuais indiquem seus conhecidos. |
| Fernando Alexander  ![foto 4](img/FA.png)| Receber informações de seu interesse de compra ou serviço. | Através da interação com site definir os itens de serviços que tem interesse em receber informações via SMS. | Somente receber informações de produtos e serviços do seu interesse e encontrar fornecedores na região em que trabalha e mora. |
| Adriana Siqueira  ![foto 5](img/AS.png)| Ter maior controle dos meus clientes. | Como gerenciar seus horários de aulas com maior facilidade. | Conseguir manter os clientes que já possui. |



## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

| ID    | Descrição do Requisito | Prioridade | Provedor |
|:-----:|------------------------|:----------:|:--------:|
| RF001 | O site deve apresentar na página principal com a identificação do usuário do sistema e senha de acesso. | ALTA | Cliente-Empreendedor |
| RF002 | O site deve apresentar visão dos dados relevantes para cadastro de clientes. | MÉDIA | Empreendedor |
| RF003 | O site deve permitir ao usuário visualizar informações completas dos clientes. | MÉDIA | Empreendedor |
| RF004 |  O site deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar uma empresa, projeto e interações. | ALTA | Cliente |
| RF005 | O site deve permitir visualizar as informações de empreendedores: produtos e serviços oferecidos. | MÉDIA  | Cliente |
| RF006 | A plataforma deve apresentar os dados de forma organizada e estruturada para fácil entendimento. | ALTA | Cliente-Empreendedor |
| RF007 | O sistema deve possuir a opção de remover informações. | MÉDIA | Cliente-Empreendedor |
| RF008 | O sistema deve possuir opção de edição de informações na conta. | MÉDIA | Cliente-Empreendedor |
| RF009 | A plataforma deve possuir opção de cadastro para os clientes e os empreendedores. | ALTA | Cliente-Empreendedor |
| RF010 | A plataforma deve dispor de campo para adição de produtos. | ALTA | Empreendedor |

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito                    |Prioridade |
|:-----:|-------------------------------------------|:---------:|
| RNF001 | O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku).| ALTA |
| RNF002 | O site deverá ser responsivo permitindo a visualização de forma adequada.| ALTA |
| RNF003 | O site deve ter bom nível de contraste entre os elementos da tela.   | MÉDIA |
| RNF004 | O site deve ser compatível com os principais navegadores do mercado (Google, Chrome, Firefox, Microsoft Edge). | ALTA |
| RNF005 | Interface de fácil compreensão | MÉDIA  |
| RNF006 | Opções de acessibilidade | MÉDIA |

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID    | Restrição                                               |
|:----:|---------------------------------------------------------|
| RE001 | O projeto deverá ser entregue até o final do ano letivo |
| RE002 | O aplicativo deve se restringir às tecnologias básicas da Web-backend |
| RE003 | A equipe não pode subcontratar o desenvolvimento do  trabalho. |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

![DCU](img/Dcu.PNG)
