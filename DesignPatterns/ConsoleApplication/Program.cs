using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(860.64);
            var icms = new ICMS();
            var iss = new ISS();
            var iccc = new ICCC();

            var calculadora = new CalculadorDeImposto();
            calculadora.Calcula(orcamento, icms);
            calculadora.Calcula(orcamento, iss);
            calculadora.Calcula(orcamento, iccc);

            Console.ReadKey();
        }
    }
}
