using System.Globalization;
using BancoSimples.Models;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine("=== Banco Simples ===");
ContaBancaria conta = EscolherConta();

bool continuar = true;

while (continuar)
{
    Console.WriteLine();
    Console.WriteLine($"Conta: {conta.Numero} | Saldo: {conta.Saldo:C}");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Encerrar");
    Console.Write("Escolha: ");

    switch (Console.ReadLine())
    {
        case "1":
            decimal deposito = LerValor("Valor do depósito: ");
            conta.Depositar(deposito);
            Console.WriteLine("Depósito realizado com sucesso.");
            break;

        case "2":
            decimal saque = LerValor("Valor do saque: ");
            Console.WriteLine(
                conta.Sacar(saque)
                    ? "Saque realizado com sucesso."
                    : "Não foi possível realizar o saque.");
            break;

        case "3":
            continuar = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

Console.WriteLine($"Saldo final: {conta.Saldo:C}");

static ContaBancaria EscolherConta()
{
    while (true)
    {
        Console.Write("Escolha C para conta corrente ou P para poupança: ");

        switch (Console.ReadLine()?.Trim().ToUpperInvariant())
        {
            case "C":
                return new ContaCorrente("1055-2", 1_000m);
            case "P":
                return new ContaPoupanca("2080-5", 1_000m);
            default:
                Console.WriteLine("Tipo de conta inválido.");
                break;
        }
    }
}

static decimal LerValor(string mensagem)
{
    while (true)
    {
        Console.Write(mensagem);

        if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor > 0)
        {
            return valor;
        }

        Console.WriteLine("Digite um valor maior que zero.");
    }
}
