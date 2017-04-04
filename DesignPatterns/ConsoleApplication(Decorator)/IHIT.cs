using System.Linq;

namespace ConsoleApplication_Decorator_
{
    public sealed class IHIT : TemplateMaximaMinimaTaxacao
    {
        public IHIT(Imposto outroImposto) : base(outroImposto) { }
        public IHIT() : base() { }
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return ExisteItemComMesmoNomeEm(orcamento);
        }

        private static bool ExisteItemComMesmoNomeEm(Orcamento orcamento)
        {
            return orcamento.Itens.GroupBy(a => a.Nome).Any(a => a.Count() > 1);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor*0.13) + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return ((orcamento.Valor*0.01)*orcamento.Itens.Count);
        }
    }
}
