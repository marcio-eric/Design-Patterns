using System;

namespace ConsoleApplication_Strategy_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var conta = new ContaCorrente(600);

            var conservador = new Conservador();
            var moderado = new Moderado();
            var arrojado = new Arrojado();

            var banco = new RealizadorDeInvestimento();

            banco.Investir(conta, conservador);
            banco.Investir(conta, moderado);
            banco.Investir(conta, arrojado);

            Console.WriteLine("Saldo final: " + conta.saldo);

            Console.ReadKey();
        }
    }
}
