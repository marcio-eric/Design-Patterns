namespace ConsoleApplication_Strategy_2
{
    public class ContaCorrente
    {
        public double saldo { get; private set; }

        public ContaCorrente(double saldo)
        {
            this.saldo = saldo;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
    }
}