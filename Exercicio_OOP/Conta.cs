using System.Diagnostics.Contracts;

public abstract class Conta
{
    private static int contador = 0;

    public string Titular { get; private set; }

    protected decimal Saldo { get; set; }

    public Conta(string titular) : this(titular, 0)
    {
    }

    public Conta(string titular, decimal saldoInicial)
    {
        this.Titular = titular;
        this.Saldo = saldoInicial;
        contador++;
    }

    public void Depositar(decimal valor)
    {
        if (valor < 0)
            throw new ArgumentException("Valor para depósito deve ser positivo!");

        this.Saldo += valor;
        Console.WriteLine("Foi depositado R$ " + valor);
    }

    public virtual void Sacar(decimal valor)
    {
        if (valor > this.Saldo)
            throw new SaldoInsuficienteException("Saldo insuficiente!");

        this.Saldo -= valor;
        Console.WriteLine("Foi sacado R$ " + valor);
    }

    public void ExibirExtrato()
    {
        Console.WriteLine("Titular: " + this.Titular + " Saldo: R$ " + this.Saldo);
    }

    public abstract void FazViradaDeMes();

    public static void ExibirQtdContas()
    {
        Console.WriteLine("Foram criadas " + Conta.contador + " contas bancárias!");
    }
}