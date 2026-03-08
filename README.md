# 📚 CP1 - Sistema de Biblioteca (MER + WebAPI em .NET 10)

## 👥 O Grupo
* **Enzo Vaz** - RM: 561702
* **Lucas Ryuji Fukuda** - RM: 562152
* **Pietro Donella Salomão** - RM: 561722

## 🧭 O que a gente fez (Domínio)
Escolhemos o domínio de um **Sistema de Gestão de Biblioteca**. A ideia principal é gerenciar o acervo físico, organizar os livros por gênero, controlar os funcionários e, claro, registrar os empréstimos da galera (os clientes).

## 🧱 Nossas Entidades
Para as chaves primárias (PK), optamos por usar `Guid` em tudo, garantindo que cada ID seja único e seguro. Nossas 6 entidades ficaram assim:
1. **Biblioteca** (`IdBiblioteca`)
2. **Funcionario** (`IdFuncionario`)
3. **Cliente** (`IdCliente`)
4. **Livro** (`IdLivro`)
5. **Genero** (`IdGenero`)
6. **Emprestimo** (`IdEmprestimo`)

## 🔗 Como as coisas se conectam (Relacionamentos)
* **1:N (Biblioteca ↔ Funcionario):** A biblioteca tem vários funcionários, e cada funcionário trabalha em uma biblioteca específica.
* **1:N (Biblioteca ↔ Cliente):** A biblioteca tem vários clientes cadastrados.
* **1:N (Biblioteca ↔ Livro):** A biblioteca guarda vários livros no acervo.
* **1:N (Cliente ↔ Emprestimo):** Um cliente pode pegar vários livros emprestados ao longo do tempo.
* **N:N (Livro ↔ Genero):** Um livro pode ter vários gêneros misturados, e um gênero classifica vários livros.
* **N:N (Livro ↔ Emprestimo):** Um empréstimo registra a saída de um ou mais livros. Já o livro pode passar por vários empréstimos *(com aquele detalhe da opcionalidade (0,n) pros livros novinhos que ainda não saíram da prateleira)*.

## 🛠️ Como organizamos o código (Clean Architecture)
Montamos a estrutura separando muito bem as responsabilidades (numa pegada DDD). Deixamos as entidades ricas (com construtores e validações de negócio reais) e passamos longe de Entity Framework, migrations ou banco de dados, cumprindo 100% das restrições do CP!

* `/docs/mer.png`: A imagem do nosso Diagrama MER.
* `/src/Biblioteca.API`: A porta de entrada do projeto com a WebAPI configurada.
* `/src/Biblioteca.Application`: Nossa camada para os casos de uso.
* `/src/Biblioteca.Domain`: O coração do projeto, onde moram as Entidades e as regras de negócio puras em C#.

---
