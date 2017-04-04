using System;

namespace ConsoleApplication_ChainOfResposibility_
{
    class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            return 0;
        }
    }
}
