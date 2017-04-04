using System;

namespace ConsoleApplication_TemplateMethod_
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(800);
            orcamento.AdicionarItem(new Item("Eu", 400));
            orcamento.AdicionarItem(new Item("Caneta", 400));

            var icpp = new ICPP();
            var ikcv = new IKCV();
            var ihit = new IHIT();

            var calculadora = new CalculadorDeImposto();

            calculadora.Calcula(orcamento, icpp);
            calculadora.Calcula(orcamento, ikcv);
            calculadora.Calcula(orcamento, ihit);

            Console.ReadKey();
        }
    }
}
