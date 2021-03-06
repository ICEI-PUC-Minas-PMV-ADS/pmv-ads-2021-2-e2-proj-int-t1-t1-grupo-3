
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

A metodologia escolhidas contempladas são scrum com kanban

## Controle de Versão
 
Para gestão do código fonte do software desenvolvido pela equipe, o grupo utiliza um processo  mostrado na figura 3. Desta forma, todas as manutenções no código são realizadas em Branches separadas e depois entram em uma branch de DEV e depois  Merge com a Master 

![CF](img/CF.png)

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

## Gerenciamento de Projeto

A equipe opera por meio de metodologias ágeis, tendo escolhido o Scrum como principal base para definição do processo de desenvolvimento.

### Divisão de Papéis

A equipe está organizada da seguinte maneira:

- Scrum Master: Emerson Alves
- Product Owner: Vinicius Soares
- Equipe de Desenvolvimento 
  - Emerson Alves 
  - Nilce Maria
  - Vinicius Soares
  - Carlos Roberto
  - Gabriel Costa
  - Paula Milanes
- Equipe de Design 
  - Gabriel Costa

### Processo

Para a organização e distribuição das tarefas do projeto, a equipe está utilizando o Jira estruturado com as seguintes listas:

- **Recursos:** esta lista mantém um template de tarefas recorrentes com as configurações padronizadas que todos devem seguir. O objetivo é permitir a cópia destes templates para agilizar a criação de novos cartões. 
- **Backlog:** recebe as tarefas a serem trabalhadas e representa o Product Backlog. Todas as atividades identificadas no decorrer do projeto também devem ser incorporadas a esta lista. 
- **To do:** esta lista representa o Sprint Backlog. Este é o Sprint atual que estamos trabalhando. 
- **Doing:** quando uma tarefa tiver sido iniciada, ela é movida para cá. 
- **Test:** Testes e Checagem de Qualidade. Quando as tarefas são concluídas, são movidas para o “Done”. 
- **Done:** nesta lista são colocadas as tarefas que passaram pelos testes e checagem de qualidade e estão prontos para serem entregues ao usuário. Não há mais edições ou revisões necessárias, ele está agendado e pronto para a ação. 
- **Locked:** quando alguma coisa impede a conclusão da tarefa, ela é movida para esta lista juntamente com um comentário sobre o que está travando a tarefa. 

![MG](img/MG.png)

### Ferramentas

Os artefatos do projeto são desenvolvidos a partir de diversas plataformas e a relação dos ambientes com seu respectivo propósito é apresentada na tabela a seguir.

|Ambiente|Plataforma|Link de Acesso|
|:---:|:---:|:---:|
|Repositório de código fonte |GitHub|[GITHUB](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-3)|
|Documentos do projeto|Office 365|[DOCS](https://docs.google.com/document/d/15WiGObq-aI9pFzYIn8-BUzzUKB3h9HGG/edit#)|
|Projeto de Interface e Wireframes|Figma|[FIGMA](https://www.figma.com/file/w5UEMCMARn3uf3s2s9z8tD/Untitled?node-id=0%3A1)|
|Gerenciamento do Projeto|Jira|[JIRA](https://projbadge.atlassian.net/jira/software/projects/GRUP/boards/20/backlog)|
|Ferramenta de Comunicação|Slack, Teams, Whatsapp||
