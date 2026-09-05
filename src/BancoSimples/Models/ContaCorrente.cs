namespace BancoSimples.Models;

public sealed class ContaCorrente : ContaBancaria
{
    private const decimal TaxaSaque = 2m;

    public ContaCorrente(string numero, decimal saldoInicial)
        : base(numero, saldoInicial)
    {
    }

    protected override decimal CalcularTaxaSaque()
    {
        return TaxaSaque;
    }
}
