# Sistema Bancário em C#/.NET

[![.NET Quality](https://github.com/morettichaves/Moretti/actions/workflows/dotnet.yml/badge.svg)](https://github.com/morettichaves/Moretti/actions/workflows/dotnet.yml)

Aplicação de console simples para demonstrar fundamentos de desenvolvimento back-end com **C# e .NET 8**.

O sistema permite escolher entre conta corrente e conta poupança, consultar saldo, depositar e sacar. As regras de negócio ficam protegidas dentro das classes e são verificadas por testes automatizados.

## Conceitos demonstrados

- Orientação a objetos
- Encapsulamento do saldo
- Herança e classes abstratas
- Polimorfismo nas taxas de saque
- Validação de entradas
- Testes unitários com xUnit
- Integração contínua com GitHub Actions

## Regras de negócio

- O saldo inicial não pode ser negativo.
- Depósitos precisam ser maiores que zero.
- Saques não podem ultrapassar o saldo disponível.
- A conta corrente cobra uma taxa de R$ 2,00 por saque.
- A conta poupança não cobra taxa de saque.

## Estrutura

```text
src/BancoSimples/
├── Models/
│   ├── ContaBancaria.cs
│   ├── ContaCorrente.cs
│   └── ContaPoupanca.cs
├── BancoSimples.csproj
└── Program.cs

tests/BancoSimples.Tests/
├── BancoSimples.Tests.csproj
└── ContaBancariaTests.cs
```

## Como executar

Requisito: [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).

```bash
git clone https://github.com/morettichaves/Moretti.git
cd Moretti
dotnet run --project src/BancoSimples/BancoSimples.csproj
```

## Como testar

```bash
dotnet test tests/BancoSimples.Tests/BancoSimples.Tests.csproj
```

## Fluxo de contribuição

Toda correção, melhoria ou funcionalidade deve começar por uma Issue e ser entregue por Pull Request, mencionando a Issue correspondente. As regras completas estão em [AGENTS.md](AGENTS.md).

## Autor

**Otávio Moretti** — Desenvolvedor Back-End Júnior

- [GitHub](https://github.com/morettichaves)
- [LinkedIn](https://www.linkedin.com/in/otavio-moretti)

## Licença

Distribuído sob a licença MIT.
