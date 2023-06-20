# Cadastro de Usuário App

### O projeto é uma página web construída com React JS que se comunica com um back-end através de uma Web API ASP.Net Core. As operações consistem em cadastrar, listar e pesquisar usuários em um servidor Postgres, rodando em um container docker. O padrão de projeto utilizado é o DDD..

<br/>

## Setup

### Para iniciar o container utilize o seguinte comando na pasta Presentation do projeto "\UserRegistration.Presentation":

``` run docker-compose up -d ``` 

### Para efetivar a primeira migration realize o comando abaixo em "\UserRegistration.Infrasctructure":

``` dotnet ef migrations add InitialCreate ``` 

### Em seguida abra o projeto no Visual Studio e rode a aplicação pelo IIS.

### Para iniciar a página localmente rode os comandos:

``` npm install ```
``` npm start ```

<br/>

## Escopo do projeto a partir do C4 model.
![User Registration C4 Model Architecture](/C4-Software-Architecture.drawio.png)

## O projeto está em sua primeira versão de desenvolvimento, necessitando ajustes de layout, testes unitários e revisão do código para refatorar para aplicar melhorias.





