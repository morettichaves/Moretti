namespace BancoSimples.Models;

public abstract class ContaBancaria
{
    protected ContaBancaria(string numero, decimal saldoInicial)
    {
        if (string.IsNullOrWhiteSpace(numero))
        {
            throw new ArgumentException("O número da conta é obrigatório.", nameof(numero));
        }

        if (saldoInicial < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(saldoInicial),
                "O saldo inicial não pode ser negativo.");
        }

        Numero = numero.Trim();
        Saldo = saldoInicial;
    }

    public string Numero { get; }

    public decimal Saldo { get; private set; }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(valor),
                "O depósito deve ser maior que zero.");
        }

        Saldo += valor;
    }

    public bool Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            return false;
        }

        decimal total = valor + CalcularTaxaSaque();

        if (total > Saldo)
        {
            return false;
        }

        Saldo -= total;
        return true;
    }

    protected abstract decimal CalcularTaxaSaque();
}
