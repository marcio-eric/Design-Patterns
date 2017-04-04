namespace ConsoleApplication_Decorator_
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        protected Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        protected Imposto()
        {
            this.OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            return OutroImposto?.Calcula(orcamento) ?? 0;
        }
    }
}