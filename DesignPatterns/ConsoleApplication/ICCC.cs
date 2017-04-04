namespace ConsoleApplication
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            var valor = orcamento.Valor;
            if (valor < 1000)
            {
                return valor*0.05;
            }
            else if (valor <= 3000)
            {
                return valor*0.07;
            }
            else if (valor > 3000)
            {
                return (valor*0.08) + 30;
            }
            return 0;
        }
    }
}