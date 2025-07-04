# SmartPayHub

SmartPayHub é uma solução para gerenciamento de estabelecimentos, usuários, contas bancárias e terminais de pagamento, desenvolvida em .NET 8 com arquitetura em camadas e uso de padrões modernos como Repository e AutoMapper.

## Funcionalidades

- Cadastro e gerenciamento de estabelecimentos (Merchants)
- Gerenciamento de usuários vinculados ao estabelecimento
- Controle de contas bancárias e terminais de pagamento
- Mapeamento entre entidades de domínio e DTOs usando AutoMapper
- Persistência de dados com Entity Framework Core

## Estrutura do Projeto

- **SmartPayHub.Domain**: Entidades de domínio e interfaces de repositório
- **SmartPayHub.Application**: Casos de uso, DTOs, mapeamentos e lógica de aplicação
- **SmartPayHub.Data**: Implementação dos repositórios e contexto do banco de dados

## Tecnologias Utilizadas

- .NET 8
- C# 12
- Entity Framework Core
- AutoMapper

## Como Executar

1. Clone o repositório:
