using System;

namespace ConsoleApplication
{
    public class CalculadorDeImposto
    {
        public void Calcula(Orcamento orcamento, IImposto imposto)
        {
            var valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}