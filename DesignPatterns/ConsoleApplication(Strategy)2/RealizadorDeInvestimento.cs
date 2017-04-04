using System;

namespace ConsoleApplication_Strategy_2
{
    public class RealizadorDeInvestimento
    {
        public void Investir(ContaCorrente conta, IInvestimento investimento)
        {
            var valor = investimento.investir(conta);
            Console.WriteLine(valor);
            conta.Deposita(valor);
        } 
    }
}