namespace ConsoleApplication_Strategy_2
{
    public class Conservador : IInvestimento
    {
        public double investir(ContaCorrente conta)
        {
            var valor = conta.saldo*0.008;
            return valor;
        }
    }
}