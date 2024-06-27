App Estacionamento Web

Descrição:

Este projeto tem como objetivo desenvolver uma aplicação web para a gestão de estacionamentos de veículos. A aplicação visa otimizar o controle de entrada e saída de veículos, proporcionar uma administração eficiente das vagas disponíveis e melhorar a experiência dos usuários.

Tecnologias Utilizadas:

* Front End: Angular
* Back End: ASP.NET Core
* Banco de Dados: MySQL
* Ferramenta de Gerenciamento de Banco de Dados: MySQL Workbench
* IDEs Utilizadas: Visual Studio Code (VS Code), Visual Studio 2022 (VS2022)

Funcionalidades:

* Cadastro de veículos e proprietários
* Monitoramento em tempo real da ocupação do estacionamento
* Geração de relatórios gerenciais
* Interface de usuário amigável e responsiva

Estrutura do Projeto:

app-estacionamento-web/
├── frontend/
│   └── angular-app/
├── backend/
│   └── aspnet-core-api/
├── database/
│   └── mysql-scripts/
└── docs/
    └── tcc-documentation/

    Como Executar

Pré-requisitos:

*  Node.js e npm (para o Angular)
*  .NET Core SDK (para o ASP.NET Core)
*  MySQL Server

Passos para Execução:

1. Clone o repositório:

git clone https://github.com/seuusuario/app-estacionamento-web.git
cd app-estacionamento-web

2. Configurar o Banco de Dados:

Use o MySQL Workbench para criar o banco de dados necessário e executar os scripts SQL encontrados em database/mysql-scripts/.

3. Executar o Front End:

cd frontend/angular-app
npm install
ng serve

O aplicativo Angular estará disponível em http://localhost:4200.

4. Executar o Back End:

cd backend/aspnet-core-api
dotnet restore
dotnet run

A API ASP.NET Core estará disponível em http://localhost:5000.

Contribuição

Faça um fork do projeto:

* Crie uma branch para sua feature (git checkout -b feature/nova-feature)
* Comite suas mudanças (git commit -m 'Adiciona nova feature')
* Faça o push para a branch (git push origin feature/nova-feature)
* Abra um Pull Request

Resultados Esperados:

Do Documento: Proporcionar uma compreensão clara e detalhada dos processos e decisões envolvidos no desenvolvimento da aplicação.

Do Sistema Desenvolvido: Melhorar a organização e eficiência dos serviços prestados pelos estacionamentos através de um sistema de gestão automatizado e intuitivo.

Licença
Este projeto está licenciado sob a licença MIT - veja o arquivo LICENSE para detalhes.

Contato
Para mais informações, entre em contato com Rafael Bonotto. -rafaelbonotto03@gmail.com-
