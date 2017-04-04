namespace ConsoleApplication_Decorator_
{
    public abstract class TemplateMaximaMinimaTaxacao : Imposto
    {
        public TemplateMaximaMinimaTaxacao(Imposto outroImposto) : base(outroImposto) { }
        public TemplateMaximaMinimaTaxacao() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            return (DeveUsarMaximaTaxacao(orcamento) ? MaximaTaxacao(orcamento) : MinimaTaxacao(orcamento)) + CalculoDoOutroImposto(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
