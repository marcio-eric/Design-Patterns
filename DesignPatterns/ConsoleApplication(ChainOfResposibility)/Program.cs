using System;

namespace ConsoleApplication_ChainOfResposibility_
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(750);
            orcamento.AdicionarItem(new Item("Eu", 750));

            var aplicador = new AplicadorDeDesconto();

            aplicador.Calcula(orcamento);

            Console.ReadKey();
        }
    }
}
