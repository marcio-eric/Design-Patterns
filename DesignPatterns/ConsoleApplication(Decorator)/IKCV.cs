namespace ConsoleApplication_Decorator_
{
    class IKCV : TemplateMaximaMinimaTaxacao
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return TemItemComValorMaiorEm(orcamento, 100) && orcamento.Valor > 500;
        }

        private static bool TemItemComValorMaiorEm(Orcamento orcamento, int v)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor*0.1;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor*0.06;
        }
    }
}
