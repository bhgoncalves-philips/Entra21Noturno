using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEComposicao.Dominio
{
    class Compra
    {

        public string Cliente { get; set; }
        public List<Item> Items { get; private set; }

        public Compra()
        {
            Items = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Items.Add(item);
        }

        public void AdicionaItem(string nome, double quantidade, double valor)
        {
            Items.Add(new Item(nome, quantidade, valor));
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public void SalvaItem(Item item)
        {
            foreach (var item1 in Items)
            {
                if (item.Nome.Equals(item1.Nome))
                {
                    item1.Valor = item.Valor;
                    item1.Quantidade = item.Quantidade;
                }
            }
        }
    }
}
