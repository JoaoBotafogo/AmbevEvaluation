# AmbevEvaluation - Developer Technical Test

Este projeto é uma API desenvolvida em .NET 8.0 para gerenciar registros de vendas, criada como parte de um desafio técnico para avaliação de desenvolvedores.

## 📋 Requisitos do Desafio

A API deve ser capaz de:

- Informar o número da venda
- Data da venda
- Cliente
- Valor total da venda
- Filial
- Produtos vendidos
- Quantidades
- Preços unitários
- Descontos aplicados por item
- Total por item
- Status de cancelamento

### 🧾 Regras de Negócio

- **1 a 3 unidades**: sem desconto
- **4 a 9 unidades**: 10% de desconto
- **10 a 20 unidades**: 20% de desconto
- **Mais de 20 unidades**: venda inválida

### Diferenciais (implementados ou previstos)

- Eventos como `SaleCreated`, `SaleCancelled` logados no sistema
- Postgre como armazenamento de leitura com dados desnormalizados
- Camadas separadas seguindo princípios de DDD
- Uso de MediatR, AutoMapper, EF Core, FluentValidation, xUnit, NSubstitute

---

## 🏗️ Tecnologias Utilizadas

- **.NET 8.0**
- **C#**
- **PostgreSQL** – Banco de dados relacional principal
- **MongoDB** – Banco de dados não relacional para leitura (diferencial)
- **Entity Framework Core** – ORM para PostgreSQL
- **AutoMapper** – Mapeamento de objetos
- **MediatR** – Aplicação do padrão Mediator
- **FluentValidation** – Validações fluentes
- **xUnit** – Testes unitários
- **NSubstitute** – Mocking nos testes
- **Bogus** – Geração de dados fake
- **Docker (futuramente opcional)** – Para facilitar a orquestração dos bancos

---

## 📁 Estrutura do Projeto

\`\`\`
src/
├── Ambev.DeveloperEvaluation.WebApi/         # Camada de apresentação (API)
├── Ambev.DeveloperEvaluation.Application/    # Casos de uso, validações, handlers
├── Ambev.DeveloperEvaluation.Domain/         # Entidades, enums e regras de domínio
├── Ambev.DeveloperEvaluation.Infrastructure/ # Persistência, repositórios e contexto
tests/
└── Ambev.DeveloperEvaluation.UnitTests/      # Testes unitários com xUnit
\`\`\`

---

## 🚀 Como Executar o Projeto

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [PostgreSQL](https://www.postgresql.org/)
- [MongoDB](https://www.mongodb.com/) (opcional)

### Configuração do Banco

1. Crie o banco PostgreSQL com o nome desejado (por exemplo `AmbevDb`)
2. Configure sua connection string no `appsettings.Development.json`:

\`\`\`json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=AmbevDb;Username=postgres;Password=senha"
}
\`\`\`

3. Aplique as migrations com o seguinte comando:

\`\`\`bash
cd src/Ambev.DeveloperEvaluation.WebApi
dotnet ef database update
\`\`\`

---

### Executar a API

\`\`\`bash
cd src/Ambev.DeveloperEvaluation.WebApi
dotnet run
\`\`\`

A API estará disponível em:  
📍 \`https://localhost:5001\` ou \`http://localhost:5000\`

---

## ✅ Funcionalidades Disponíveis

- [x] Criar venda (CreateSale)
- [x] Obter venda por ID (GetSale)
- [x] Listar todas as vendas (GetAllSales)
- [x] Atualizar venda (UpdateSale)
- [x] Cancelar venda (CancelSale)
- [x] Testes unitários com xUnit (em progresso)

---

## 🔍 Exemplos de Requisições

### Criar uma venda

\`\`\`http
POST /api/sales
Content-Type: application/json

{
  "saleNumber": "SALE-123",
  "saleDate": "2025-04-10T12:30:00",
  "customerId": "c6a8a4a5-8a6a-4e83-9c2a-624e4d9171e7",
  "branch": "São Paulo",
  "items": [
    {
      "productId": "b1f77e33-6d41-447f-9d23-9b2e14d6c9e7",
      "quantity": 5,
      "unitPrice": 100.0
    }
  ]
}
\`\`\`

---

## 🧪 Rodando os Testes

\`\`\`bash
cd tests/Ambev.DeveloperEvaluation.UnitTests
dotnet test
\`\`\`

---

## 📌 Autor

Feito por [João Botafogo](https://github.com/JoaoBotafogo)

---

## 🧠 Observações

- Este projeto é parte de um desafio técnico para a Ambev Tech.
- Feedbacks são bem-vindos para melhorias.