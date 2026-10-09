public class ContaCorrente : Conta
{
    private const decimal LIMITE_SAQUE = 500.0M;
    private const decimal TARIFA = 10.0M;

    public ContaCorrente(string titular) : base(titular)
    {
        
    }

    public ContaCorrente(string titular, decimal saldoInicial) : base(titular, saldoInicial)
    {
        
    }

    public override void Sacar(decimal valor)
    {
        decimal limite = this.Saldo + ContaCorrente.LIMITE_SAQUE;

        if (valor > limite)
        {
            Console.WriteLine("Não é possível sacar o valor solicitado! O limite de saque é o seu saldo atual mais R$ " + ContaCorrente.LIMITE_SAQUE);
            return;
        }

        this.Saldo -= valor;
        Console.WriteLine("Foi sacado R$ " + valor);
    }

    public override void FazViradaDeMes()
    {
        this.Saldo -= ContaCorrente.TARIFA;
        Console.WriteLine("Virada de mês! Cobrança de tarifa de R$ " + ContaCorrente.TARIFA);
    }
}