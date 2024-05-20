# PeakInvestAPI

Esta API permite calcular resultados.

## Endpoints

### 1. Buscar Nome por ID

**POST** `/api/Cadastro/calcular`

- Retorna o nome associado ao ID fornecido.
- Exemplo: `POST https://localhost:44352/api/Cadastro/calcular`

**Resposta de Sucesso:**
```json
{
  "parcelas": 2,
  "valor": 230
}
{
    "resultado": 483.00
}
