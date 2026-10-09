internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Simulador de banco!");

        var contaCorrente1 = new ContaCorrente("Fernando");
        var contaCorrente2 = new ContaCorrente("Ricardo", 1000.0M);
        var contaCorrente3 = new ContaCorrente("Neusa", 5000.0M);

        var contaPoupanca1 = new ContaPoupanca("Fabrício");
        var contaPoupanca2 = new ContaPoupanca("Walter", 2000.0M);

        contaCorrente1.ExibirExtrato();
        contaCorrente1.Depositar(300.0M);
        contaCorrente1.Sacar(400.0M);
        contaCorrente1.FazViradaDeMes();
        contaCorrente1.ExibirExtrato();

        contaCorrente2.ExibirExtrato();
        contaCorrente2.Depositar(300.0M);
        contaCorrente2.Sacar(400.0M);
        contaCorrente2.FazViradaDeMes();
        contaCorrente2.ExibirExtrato();

        contaCorrente3.ExibirExtrato();
        contaCorrente3.Depositar(500.0M);
        contaCorrente3.Sacar(4000.0M);
        contaCorrente3.FazViradaDeMes();
        contaCorrente3.ExibirExtrato();

        contaPoupanca1.ExibirExtrato();
        contaPoupanca1.Depositar(500.0M);
        contaPoupanca1.Sacar(400.0M);
        contaPoupanca1.FazViradaDeMes();
        contaPoupanca1.ExibirExtrato();

        contaPoupanca2.ExibirExtrato();
        contaPoupanca2.Depositar(100.0M);
        contaPoupanca2.Sacar(4100.0M);
        contaPoupanca2.FazViradaDeMes();
        contaPoupanca2.ExibirExtrato();

        Console.WriteLine("");
        Conta.ExibirQtdContas();
    }
}