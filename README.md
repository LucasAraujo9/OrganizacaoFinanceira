# Organização Financeira Pessoal

Aplicação web desenvolvida em .NET para controle financeiro pessoal, com foco em organização de recebíveis, gastos e análise por período de pagamento.

## Objetivo
Centralizar entradas e saídas financeiras, permitindo visualizar:
- Quanto foi recebido em cada período
- Quais contas foram pagas em cada salário
- Onde houve maior gasto ou economia
- Saldo final de cada período

## Escopo inicial
- Uso pessoal (um único usuário) - Talvez: cadastro de usuarios
- Controle de recebíveis e gastos
- Separação mensal e por período de pagamento
- Histórico financeiro

## Domínios
- **Recebíveis**
  - Salário
  - Dividendos
  - Outras entradas
- **Gastos**
  - Despesas fixas (aluguel, cartão, contas)
  - Despesas variáveis (contas, compras, lazer)

## Casos de uso
- Registrar recebimento de salário por data
- Associar despesas ao salário/período correto
- Consultar gastos e recebíveis mensalmente
- Visualizar saldo, economia ou déficit por período

## Regras de negócio
- Ao iniciar um novo mês, o sistema solicita o valor do salário recebido
- O sistema pergunta se houve alteração nos valores das contas do período
- Após confirmação, calcula e exibe o saldo final do período

## Arquitetura
- **Backend:** .NET Core Web
- **Banco de dados:** SQL Server
- **Arquitetura:** monólito modular (evoluível para microserviços)
- **Persistência:** dados financeiros estruturados com integridade transacional

## Objetivo técnico do projeto
- Praticar organização de domínio
- Aplicar boas práticas de arquitetura
- Evoluir gradualmente para recursos mais avançados
- Aplicar testes de Unidade
  
## Status
Em desenvolvimento (MVP)
