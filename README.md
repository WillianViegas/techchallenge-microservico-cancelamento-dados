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


