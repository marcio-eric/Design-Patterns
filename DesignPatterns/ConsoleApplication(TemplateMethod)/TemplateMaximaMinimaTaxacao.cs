using System;

namespace ConsoleApplication_TemplateMethod_
{
    public abstract class TemplateMaximaMinimaTaxacao : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return DeveUsarMaximaTaxacao(orcamento) ? MaximaTaxacao(orcamento) : MinimaTaxacao(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
