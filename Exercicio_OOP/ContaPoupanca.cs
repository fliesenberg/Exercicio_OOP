public class ContaPoupanca : Conta
{
    private static decimal PERCENTUAL_RENDIMENTO = 1.0M;

    public ContaPoupanca(string titular) : base(titular)
    {
        
    }

    public ContaPoupanca(string titular, decimal saldoInicial) : base(titular, saldoInicial)
    {
        
    }

    public override void FazViradaDeMes()
    {
        decimal rendimento = this.Saldo * ContaPoupanca.PERCENTUAL_RENDIMENTO / 100;
        this.Saldo += rendimento;
        Console.WriteLine("Virada de mês! Rendimento de " + ContaPoupanca.PERCENTUAL_RENDIMENTO + " %");
    }    
}