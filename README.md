# techchallenge-microservico-cancelamento-dados

Repositório relacionado a fase 5 do techChallenge FIAP. Criação de uma API para solicitação de cancelamento dos dados do cliente;

Repositório bloqueado para push na main, é necessário abrir um PullRequest;

Este microsserviço tem como objetivo permitir que seja aberta uma solicitação de exclusão dos dados do cliente;


Considerando a LGPD foi solicitado:
A criação de um relatório de impacto dos dados pessoais (RIPD) que terá seu link disponibilizado abaixo;
A criação de uma api para que o cliente possa solicitar a exclusão ou inativação de seus dados pessoais. Contendo os seguntes campos:
Nome
Endereço
Número de telefone
Informações de Pagamento (caso seja armazenado em algum local)

- Relatório RIPD: https://fiap-docs.s3.amazonaws.com/RIPD/Relatorio-RIPD-GRUPO-45.pdf

## Estrutura

- Banco de dados = MongoDB
- Containers = Docker + Docker-Compose
- Orquestração de containers = Kubernetes
- Testes unitários 
- Pipeline = Github Actions
- Deploy = Terraform


## Links para repositórios relacionados:

- techchallenge-microservico-pedido (Microsserviço de Pedido):
https://github.com/WillianViegas/techchallenge-microservico-pedido
- techchallenge-microservico-pagamento (Microsserviço de Pagamento):
https://github.com/WillianViegas/techchallenge-microservico-pagamento
- techchallenge-microservico-producao (Microsserviço de Producao):
https://github.com/WillianViegas/techchallenge-microservico-producao
- TechChallenge-LanchoneteTotem (Repositório com o projeto que originou os microsserviços e histórico das fases):
https://github.com/WillianViegas/TechChallenge-LanchoneteTotem


## Rodando ambiente com Docker

### Pré-Requisitos
* Possuir o docker instalado:
    https://www.docker.com/products/docker-desktop/

Acesse o diretório em que o repositório foi clonado através do terminal e
execute os comandos:
 - `docker-compose build` para compilar imagens, criar containers etc.
 - `docker-compose up` para criar os containers do banco de dados e do projeto

### Iniciando e finalizando containers
Para inicializar execute o comando `docker-compose start` e
para finalizar `docker-compose stop`

Lembrando que se você for rodar pelo visual studio fica bem mais simplificado, basta estar com o docker desktop aberto na máquina e escolher a opção abaixo:

![image](https://github.com/user-attachments/assets/6b77d29b-975c-494e-a222-5b4e0de8b866)



