using System;

namespace ConsoleApplication_Decorator_
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(800);
            orcamento.AdicionarItem(new Item("Eu", 400));
            orcamento.AdicionarItem(new Item("Caneta", 400));

            var iss = new ISS(new ICMS(new ICPP(new  IKCV())));

            Console.WriteLine(iss.Calcula(orcamento));

            Console.ReadKey();
        }
    }
}
