# UltimateJogoDaOncinha

**Ultimate Jogo da Oncinha Premium Deluxe Edition** é um projeto acadêmico desenvolvido para a disciplina de **Programação Orientada a Objetos II**, do curso de Ciência da Computação da Universidade de Vila Velha (UVV), durante o 2º bimestre de 2025. O principal objetivo foi aplicar conceitos práticos de arquitetura de software, especialmente o uso do **Entity Framework** como ORM e a implementação dos **princípios SOLID**, em um projeto real utilizando C#.

## Objetivo do Projeto

O jogo consiste em uma simulação de apostas em partidas da tradicional “Jogo da Oncinha”, com regras lógicas de movimentação e controle de usuários. Ao longo do desenvolvimento, buscamos estruturar o código com camadas bem definidas, padronizar o acesso a dados com **repositórios genéricos** e aplicar boas práticas de engenharia de software voltadas à **manutenibilidade, reutilização e baixo acoplamento**.

## Tecnologias Utilizadas

- C#
- .NET Core / .NET 6
- Entity Framework Core (com banco SQLite)
- Visual Studio
- Camada de Repositório Genérico (GenericRepository)
- Princípios SOLID aplicados à estrutura de classes

## Aplicações Técnicas e Acadêmicas

Durante o desenvolvimento do projeto, aplicamos os seguintes conceitos:

- **Entity Framework Core**  
  
- **Repository Pattern**  
 
- **Princípios SOLID**  
  
## Estrutura Geral

O projeto está dividido em camadas:

- `Entities/` – Classes de domínio (`Usuario`, `Jogo`, `Aposta`);
- `Data/` – `AppDbContext` com configuração SQLite;
- `Repositories/` – Repositório genérico e implementações específicas;
- `Services/` – Camada de serviço com lógica de negócios;
- `Program.cs` – Inicialização e testes do sistema via console (ou GUI opcional).

## Autores

- Giseli Rosa Lourenço  
- Guilherme Sousa Fagundes  
- João Pedro Valladares Araújo  

---

## 🔗 Recursos adicionais

- [Vídeo explicativo da aplicação (YouTube)](https://youtu.be/uZFvqtD_RAU?si=zoatI3CMaaDevhYP)


