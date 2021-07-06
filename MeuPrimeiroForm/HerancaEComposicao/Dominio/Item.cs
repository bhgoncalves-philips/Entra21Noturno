using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEComposicao.Dominio
{
    class Item
    {
        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }

        public Item(string nome, double quantidade, double valor )
        {
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
