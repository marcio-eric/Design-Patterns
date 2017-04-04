namespace ConsoleApplication_ChainOfResposibility_
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        double Calcula(Orcamento orcamento);
    }
}