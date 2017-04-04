using System;
using System.Collections.Generic;

namespace ConsoleApplication_Decorator_
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

        internal object GroupBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}