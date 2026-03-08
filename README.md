# 📚 CP1 - Sistema de Biblioteca (MER + WebAPI em .NET 10)

## 👥 Integrantes do Grupo
* **Enzo Vaz** - RM: 561702
* **Lucas Ryuji Fukuda** - RM: 562152
* **Pietro Donella Salomão** - RM: 561722

## 🧭 Domínio do Projeto
Escolhemos o domínio de um **Sistema de Gestão de Biblioteca**. O objetivo principal é gerenciar o acervo físico de livros, categorizá-los por gênero, controlar os funcionários e registrar os empréstimos realizados pelos clientes.

## 🧱 Entidades Modeladas
Optamos por utilizar `Guid` como estratégia de chave primária (PK) em todas as classes, garantindo que cada identificador seja único e seguro. Nossas 6 entidades são:
1. **Biblioteca** (`IdBiblioteca`)
2. **Funcionario** (`IdFuncionario`)
3. **Cliente** (`IdCliente`)
4. **Livro** (`IdLivro`)
5. **Genero** (`IdGenero`)
6. **Emprestimo** (`IdEmprestimo`)

## 🔗 Relacionamentos
* **1:N (Biblioteca ↔ Funcionario):** Uma biblioteca possui vários funcionários, e cada funcionário trabalha em uma biblioteca específica.
* **1:N (Biblioteca ↔ Cliente):** Uma biblioteca possui vários clientes cadastrados.
* **1:N (Biblioteca ↔ Livro):** Uma biblioteca mantém vários livros em seu acervo.
* **1:N (Cliente ↔ Emprestimo):** Um cliente pode realizar diversos empréstimos ao longo do tempo.
* **N:N (Livro ↔ Genero):** Um livro pode pertencer a múltiplos gêneros, e um gênero pode classificar diversos livros.
* **N:N (Livro ↔ Emprestimo):** Um empréstimo registra a saída de um ou mais livros. Um livro, por sua vez, pode participar de vários empréstimos *(com opcionalidade (0,n) para acomodar livros recém-adquiridos que ainda não possuem histórico de empréstimo)*.

## 🛠️ Estrutura do Código (Clean Architecture)
Organizamos o projeto com foco na separação de responsabilidades e na aplicação de conceitos de DDD (Domain-Driven Design). Implementamos entidades ricas, com construtores e validações de negócio, e cumprimos integralmente as restrições do CP ao não utilizar Entity Framework, migrations ou banco de dados.

* `/docs/mer.png`: Imagem do nosso Diagrama MER.
* `/src/Biblioteca.API`: Ponto de entrada do projeto com a solução WebAPI configurada.
* `/src/Biblioteca.Application`: Camada destinada aos casos de uso.
* `/src/Biblioteca.Domain`: O núcleo do projeto, contendo as Entidades e as regras de negócio puras em C#.
