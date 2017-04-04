using System;

namespace ConsoleApplication_Strategy_2
{
    public class Moderado : IInvestimento
    {
        public double investir(ContaCorrente conta)
        {
            var chance = new Random().Next(101) > 50;
            if (chance)
                return conta.saldo*0.025;
            else
                return conta.saldo*0.007;
        }
    }
}