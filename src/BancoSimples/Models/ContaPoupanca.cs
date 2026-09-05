namespace BancoSimples.Models;

public sealed class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(string numero, decimal saldoInicial)
        : base(numero, saldoInicial)
    {
    }

    protected override decimal CalcularTaxaSaque()
    {
        return 0m;
    }
}
