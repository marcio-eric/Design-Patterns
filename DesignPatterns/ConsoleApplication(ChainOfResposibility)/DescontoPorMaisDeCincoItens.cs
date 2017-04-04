namespace ConsoleApplication_ChainOfResposibility_
{
    public class DescontoPorMaisDeCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public DescontoPorMaisDeCincoItens(){}

        public DescontoPorMaisDeCincoItens(IDesconto proximo)
        {
            Proximo = proximo;
        }

        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Itens.Count >= 5)
            {
                return orcamento.Valor*0.1;
            }

            return Proximo.Calcula(orcamento);
        }
    }
}
