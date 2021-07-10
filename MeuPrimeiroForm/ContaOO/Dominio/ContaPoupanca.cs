using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaOO.Dominio
{
    class ContaPoupanca : Conta, IRendimento
    {
        public ContaPoupanca()
        {
            TaxaRendimento = 0.5;
        }

        public double renderMensalmente()
        {
            Saldo += Saldo * TaxaRendimento / 100;
            return Saldo;
        }
    }
}
