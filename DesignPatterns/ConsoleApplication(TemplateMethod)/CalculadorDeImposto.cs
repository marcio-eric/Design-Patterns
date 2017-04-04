using System;

namespace ConsoleApplication_TemplateMethod_
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