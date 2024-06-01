# ziuQuiz_Backend

Esta é a aplicação backend do projeto ziuQuiz, construída com .NET 8.0. O projeto inclui uma rotina de autenticação e está estruturado em várias camadas.

## Estrutura do Projeto

Abaixo está uma visão geral da estrutura do projeto:

ziuQuiz_Backend/

│

├── Domain/ # Contém as entidades de domínio

│

├── Infra/ # Contém a infraestrutura e configuração do banco de dados

│

├── Repository/ # Contém os repositórios para acesso aos dados

│

├── Service/ # Contém os serviços de aplicação

│

├── ziuQuiz_Backend.API/ # Contém os controladores e configurações da API

│

├── .gitignore # Arquivo para ignorar arquivos no git

│

└── ziuQuiz_Backend.sln # Arquivo de solução do Visual Studio



## Pré-requisitos

Antes de começar, certifique-se de ter o seguinte instalado em sua máquina:

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (ou versão mais recente)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Git](https://git-scm.com/)

## Instalação

1. Clone o repositório para sua máquina local:

```bash
git clone https://github.com/seu-usuario/ziuQuiz_Backend.git
cd ziuQuiz_Backend
```

Após clonar, basta executar o projeto.api que o swagger vai abrir com a documentação para executar as rotas.

Lembrando que precisa ter um banco de dados sqlserver configurado e as configurações para se conectar com o banco devem estar em

ziuQuiz_Backend.API/appsettings.json, na chave "SqlServer".
```bash
Exemplo: "Data Source=NOME_SERVIDOR_SQL_SERVER;Initial Catalog=NOME_BANCO_DADOS;User ID=NOME_USUARIO_SQL_SERVER;Password=SENHA_USUARIO_SQL_SERVER;Encrypt=False".
```
