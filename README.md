# API de controle de itens de um Hospital

## Como rodar?

1. De um `git clone` no repositório
2. Rode as migrations por meio do comando `Update-Database`
3. Starte o servidor e acesse o swagger para testar as rotas.

## Rotas da API
### Rotas de itens (`/api/Item`)

| Método | Rota | Descrição |
| :--- | :--- | :--- |
| `POST` | `/api/Item` | Cria um item |
| `GET` | `/api/Item/FindAll` | Lista todos os itens cadastrados |
| `GET` | `/api/Item/{id}` | Encontra um item específico pelo ID |
| `GET` | `/api/Item/FindByDescription` | Encontra um item específico pela descrição |
| `PUT` | `/api/Item/Update Quantity Item - Add` | Adiciona a quantidade de um item passando um ID como parâmetro |
| `PUT` | `/api/Item/Update Quantity Item - Remove` | Remove a quantidade de um item passando um ID como parâmetro |
| `PUT` | `/api/Item/Update Item` | Atualiza os dados de um item passando um ID como parâmetro |
| `DELETE` | `/api/Item` | Exclui um item passando um ID como parâmetro |

---

## Banco de Dados
### Tabela
<img width="1807" height="960" alt="image" src="https://github.com/user-attachments/assets/9d8813ba-bbf5-4ac2-9357-a53d738659e6" />

---

## Swagger
<img width="1908" height="1018" alt="image" src="https://github.com/user-attachments/assets/fad0779c-e624-4501-a0cf-7a4f4b8ec7a6" />
