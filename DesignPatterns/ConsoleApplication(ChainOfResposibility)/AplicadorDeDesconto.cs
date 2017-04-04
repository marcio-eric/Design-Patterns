using System;

namespace ConsoleApplication_ChainOfResposibility_
{
    public class AplicadorDeDesconto
    {
        public void Calcula(Orcamento orcamento)
        {
            var fn = new SemDesconto();
            var d2 = new DescontoPorMaisDeQuinhentosReais(fn);
            var d1 = new DescontoPorMaisDeCincoItens(d2);

            Console.WriteLine(d1.Calcula(orcamento));
        }
    }
}
