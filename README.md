# API Produtos

API RESTful em ASP.NET Core para gerenciamento de produtos utilizando Entity Framework Core.

## Descrição

Esta API oferece um serviço CRUD para manipulação de produtos, armazenados em um banco de dados relacional via Entity Framework Core.

### Estrutura do projeto

- **AppDbContext**: contexto do EF Core que representa a conexão com o banco e a tabela Produtos.  
- **Produto**: modelo que representa a entidade Produto com suas propriedades (`Id`, `Nome`, `Preco`, `Quantidade`).  
- **ProdutosController**: controller que expõe os endpoints REST para criar, ler, atualizar e deletar produtos.

## Tecnologias

- .NET 7 (ou sua versão)  
- ASP.NET Core Web API  
- Entity Framework Core  
- Banco de dados SQL Server (ou outro, conforme configuração)

## Como executar

1. Clone o repositório:  
```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio
```

2. Configure sua string de conexão no `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=DBProdutos;Trusted_Connection=True;"
}
```

3. Instale as migrations e atualize o banco:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

4. Rode a aplicação:
```bash
dotnet run
```

## Endpoints da API

| Método | URL                 | Descrição                   | Corpo (JSON)                         |
|--------|---------------------|-----------------------------|------------------------------------|
| GET    | `/api/produtos`      | Lista todos os produtos      | -                                  |
| GET    | `/api/produtos/{id}` | Obtém produto por ID         | -                                  |
| POST   | `/api/produtos`      | Cria um novo produto         | `{ "nome": "Produto A", "preco": 10.5, "quantidade": 100 }` |
| PUT    | `/api/produtos/{id}` | Atualiza produto existente   | `{ "id": 1, "nome": "Produto A", "preco": 12.0, "quantidade": 90 }` |
| DELETE | `/api/produtos/{id}` | Deleta produto por ID        | -                                  |

## Modelo Produto

```csharp
public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
}
```

## Contribuição

Contribuições são bem-vindas! Abra issues ou envie pull requests para melhorias.

## Licença

Este projeto está licenciado sob a MIT License.
