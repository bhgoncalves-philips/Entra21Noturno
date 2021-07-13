using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaOO.Dominio
{
    class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
            TaxaRendimento = 0;
        }

        public new bool Saca(double quantidade)
        {
            if(Saldo + ChequeEspecial >= quantidade)
            {
                Saldo -= quantidade;
                return true;
            }
            return false;
        }

        public override bool Transferir(double quantidade, Conta contaDestino)
        {
            if (contaDestino is ContaCorrente)
            {
                if (Saca(quantidade))
                {
                    contaDestino.Deposita(quantidade);
                    return true;
                }
            }
            return false;
        }

        public int ChequeEspecial { get; set; }

    }
}
