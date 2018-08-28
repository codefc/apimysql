# Api Mysql

Repositório que demonstra a criação de um projeto asp.net core através do CLI e conectando a um banco de dados My SQl utilizando Dapper e .net Core.

Repositório base para o seguinte artigo: [aqui](https://wp.me/p7SQs9-9B).

## Requisitos

- .Net Core 2.1
- Visual Studio Code / Visual Studio 2017
- Docker/Docker-compose (Instruções de instalação)
  - [Windows](https://docs.docker.com/docker-for-windows/install/#start-docker-for-windows)
  - Linux
    - [Ubuntu](https://docs.docker.com/install/linux/docker-ce/ubuntu/#prerequisites)
    - [Fedora](https://docs.docker.com/install/linux/docker-ce/fedora/)
 	- [Debian](https://docs.docker.com/install/linux/docker-ce/debian/)
 	- [CentOs](https://docs.docker.com/install/linux/docker-ce/centos/)
  - [MacOs](https://docs.docker.com/docker-for-mac/install/)

# O que você vai encontrar neste projeto

Visando as melhores práticas para desenvolvimento de uma API, este projeto conta com as seguintes tecnologias:
- **Dapper** - Biblioteca do StackOverflow que possui um mecanismo simples de execução de comandos em um banco de dados, mapeando, de forma otimizada, objetos do banco em classes no projeto;
- **Swagger** - Biblioteca que gera um site, com capacidade de testar a API online e exibe a documentação de cada método dos controllers;
- **MySqlConnector** - Library utilzada para conexão com uma base de dados MySql

## Detalhe do uso do docker

Para facilitar a execução da API de forma independente de instalações de base de dados, foi adicionao ao repositório um pasta denominada **Database** e um arquivo **docker-compose-mysql.yml**.
- **Database** - esta pasta contém um arquivo, script_inicial.sql, que será executado quando o container da imagem MySql for isntanciado. Neste aquivo apenas existe um script para criação de uma tabela e alguns registros.
- **docker-compose-mysql.json** - Arquivo de composição docker para facilitar orquestrar a execução do container do MySQl com alguns parâmetros(variáveis de ambiente), contendo informações como usuário, senha e volumes.

## Execução da aplicação

Para executar a aplicação é necessário a execução do container MySql. 

Primeiramente execute o seguinte comando:

```bash
docker-compose -f docker-compose-mysql.yml up -d
```

Este comando executan um container com base no descritivo do arquvo de composição.

Após o container iniciado, execute o comando:

```bash
dotnet run
```
Se desejar fechar o container após a execução, digite o comando:

```bash
docker-compose -f docker-compose-mysql.yml down
```

## String de conexão do banco

Se já possuir um banco de dados MySql e deseja utilizá-lo na aplicação, modifique a string de conexão no arquivo **appsettings.json**, no trecho indicado:

```json
...
"ConnectionStrings": {
    "MySqlDbConnection": "server=localhost;database=MyFirstAPI;user id=root;password=p@ssw0rd"
  },
...

```

O script para criação da tabela do exemplo e alguns dados iniciais encontra-se na pasta **Database**.

Maiores informações consultar o artigo: 
[https://wp.me/p7SQs9-9B](https://wp.me/p7SQs9-9B)