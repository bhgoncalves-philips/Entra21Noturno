using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaOO.Dominio
{
    class ContaInvestimento : Conta, IRendimento
    {
        public DateTime DataInvestimento { get; set; }

        public ContaInvestimento()
        {
            TaxaRendimento = 1;
        }

        public double renderMensalmente()
        {
            if (DateTime.Today.Month - DataInvestimento.Month > 0)
            {
                Saldo += Saldo * TaxaRendimento / 100;
            }
            return Saldo;
        }
    }
}
