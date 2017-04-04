using System;

namespace ConsoleApplication_Strategy_2
{
    class Arrojado : IInvestimento
    {
        public double investir(ContaCorrente conta)
        {
            var chance = new Random().Next(101);
            if (chance <= 20)
            {
                return conta.saldo*0.05;
            }
            else if(chance <= 50)
            {
                return conta.saldo*0.03;
            }
            else
            {
                return conta.saldo*0.006;
            }
        }
    }
}
