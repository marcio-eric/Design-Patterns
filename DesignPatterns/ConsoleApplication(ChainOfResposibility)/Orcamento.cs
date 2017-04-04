using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApplication_ChainOfResposibility_
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            this.Itens.Add(item);
        }

    }
}