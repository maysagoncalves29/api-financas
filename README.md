# Entendendo sobre DDD

## O que é DDD?
DDD (Domain-Driven Design) não é uma arquitetura, mas uma abordagem focada em modelar os problemas do mundo real dentro do código. Ele serve como um guia para organização do código e auxilia na estruturação do projeto. Criado por Eric Evans, recomenda-se a leitura **Domain-Driven Design: Atacando as Complexidades no Coração do Software** (também preciso ler rs) 

## Principais Influências
- Impacta diretamente na estrutura do projeto.
- Facilita a comunicação entre a equipe técnica e o negócio.
- Promove um design mais alinhado ao domínio do problema.
- Simples e tranquila a expansão do projeto.

## Ideias Chaves:
- **Linguagem Ubíqua:**
  - Desenvolver uma linguagem clara, deixando os objetivos compreensíveis para todos os membros da equipe.
- **Contextos delimitados:**
  - Se baseia em: construção do projetos em diferentes áreas;
  - Cada área, uma responsabilidade
  - Evita mal entendidos
  - Melhor gerenciamento

# Estrutura do projeto:
Exemplo do professor:
![image](https://github.com/user-attachments/assets/1ac32b78-aea4-446c-88d9-ae4d54c4db34)

Cada uma das caixas tem uma responsabilidade. 

## O project API é um projeto específico:

**Project API:**
- Responsável por receber uma requisição e devolver uma resposta.

## Os demais projetos são uma class libary (biblioteca de classes)

**Project Application:**
- Todas as regras de negócio (tudo o que precisamos validar. E-mails válidos, senhas corretas...)
  
**Communication:**
- Classes de Request e Response.
- Recebe e devolve informações
- Resquest: terá um nome, e-mail ou senha. Essas informações são passadas no body da requisição. Criamos uma classe de RequestRegisterUser, que terá um nome, e-mail ou senha. Quando chega esses valores, o .Net coloca nas propriedades corretas da classe.
- Response: entidade que espelha as informações salvas no banco de dados, pegamos algumas dessas informações e devolver. Com propriedades que façam sentido, que precisa desevolver no endpoint.

**Domain**
- Coisas que são comuns.
- Criação de linguagem comum
- Entidade User é de conhecimento comum saber que cada entidade User terá um e-mail, senha, data. Não precisa saber de programação pra ter esse tipo de informação.
- Valores mais abstratos, por exemplo, não precisa saber O TIPO do banco de dados, se é SQL ou MySQL.

**Infra**
- Tudo que está externo da API.

