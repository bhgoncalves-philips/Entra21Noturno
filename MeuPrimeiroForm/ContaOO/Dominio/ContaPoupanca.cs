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

        public double RenderMensalmente()
        {
            Saldo += Saldo * TaxaRendimento / 100;
            return Saldo;
        }

        public override bool Transferir(double quantidade, Conta contaDestino)
        {
            throw new NotImplementedException();
        }
    }
}
