namespace ConsoleApplication_ChainOfResposibility_
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public DescontoPorMaisDeQuinhentosReais(){}

        public DescontoPorMaisDeQuinhentosReais(IDesconto proximo)
        {
            this.Proximo = proximo;
        }

        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor*0.07;
            }

            return Proximo.Calcula(orcamento);
        }
    }
}
