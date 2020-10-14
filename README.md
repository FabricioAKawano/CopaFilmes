# CopaFilmes
Projeto desenvolvido para a competição entre filmes.

## Back-end
O back-end é uma API para fornecer filmes (16) pré selecionados e efetuar a competição entre oito deles selecionados pelo usuário. Toda a regra de classificação
dos filmes até a final conforme documento de requisitos está no back-end.

### Tecnologias

-Asp.Net Core versão 3.1

-OOP

-SOLID
  
### Execução

-Abrir o prompt de comando e acessar o diretorio `Source/FAK.CopaFilmes.Api`

-Executar o comando `dotnet run`

-A API estará disponível em `http://localhost:5000`

## Front-end
Na página "Home" apresentará dezesseis filmes para o usuário selecionar. Ele poderá escolher somente oito filmes para participar da Copa, sendo assim, para garantir a seleção
de somente oito filmes o botão "GERAR MEU CAMPEONATO" fica desabilitado no carregamento da página. Após a seleção de oito filmes o ba
otão é habilitado e o demais filmes que não foram selecionados serão
desabilitados para seleção. Caso o usuário tenha cometido algum equivoco em sua seleção ele poderá deselecionar um dos filmes e dar continuidade a sua seleção. Após clicar no botão
o usuário será direcionado para tela de resultado onde é aparesentado o campeão e o vice campeão.

### Tecnologias

-Angular versão 9.1.6

### Execução
-Abrir o prompt de comando e acessar o diretorio `Source/WebApp`

-Executar o comando `npm install` para baixar as dependências do projeto

-Executar o comando `npm start`

-A aplicação estará disponível em `http://localhost:4200`

## Testes
O projeto contempla testes de unidade e de integração somente para o **back-end** somando ao todo doze testes.

### Tecnologias

-XUnit

### Execução
-Abrir o prompt de comando e acessar o diretorio `Tests/FAK.CopaFilmes.Testes`

-Executar o comando `dotnet test`

Obs.: para o funcionamento correto da aplicação deverá primeiro ser iniciado a **back-end** e depois **front-end**
