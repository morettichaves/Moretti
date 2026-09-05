using BancoSimples.Models;
using Xunit;

namespace BancoSimples.Tests;

public class ContaBancariaTests
{
    [Fact]
    public void Depositar_ComValorValido_AumentaSaldo()
    {
        var conta = new ContaPoupanca("2080-5", 100m);

        conta.Depositar(50m);

        Assert.Equal(150m, conta.Saldo);
    }

    [Fact]
    public void Depositar_ComValorInvalido_LancaExcecao()
    {
        var conta = new ContaPoupanca("2080-5", 100m);

        Assert.Throws<ArgumentOutOfRangeException>(() => conta.Depositar(0m));
    }

    [Fact]
    public void Sacar_DaContaCorrente_DescontaValorETaxa()
    {
        var conta = new ContaCorrente("1055-2", 100m);

        bool resultado = conta.Sacar(40m);

        Assert.True(resultado);
        Assert.Equal(58m, conta.Saldo);
    }

    [Fact]
    public void Sacar_DaPoupanca_DescontaSomenteValor()
    {
        var conta = new ContaPoupanca("2080-5", 100m);

        bool resultado = conta.Sacar(40m);

        Assert.True(resultado);
        Assert.Equal(60m, conta.Saldo);
    }

    [Fact]
    public void Sacar_AcimaDoSaldo_MantemSaldo()
    {
        var conta = new ContaCorrente("1055-2", 100m);

        bool resultado = conta.Sacar(200m);

        Assert.False(resultado);
        Assert.Equal(100m, conta.Saldo);
    }
}
