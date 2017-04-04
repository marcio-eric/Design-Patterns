using System;

namespace ConsoleApplication_Decorator_
{
    class ICPP : TemplateMaximaMinimaTaxacao
    {
        public ICPP(Imposto outroImposto) : base(outroImposto) { }
        public ICPP() : base() { }
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor*0.07;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
