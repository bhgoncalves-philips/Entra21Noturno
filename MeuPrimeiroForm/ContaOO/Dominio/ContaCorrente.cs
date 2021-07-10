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
        public int ChequeEspecial { get; set; }
    }
}
