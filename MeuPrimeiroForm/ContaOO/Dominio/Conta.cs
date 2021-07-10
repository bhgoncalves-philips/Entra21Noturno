using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaOO.Dominio
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }
        public double TaxaRendimento { get; protected set; }

        public bool Saca(double quantidade)
        {
            if(Saldo >= quantidade)
            {
                Saldo -= quantidade;
                return true;
            }
            return false;
        }

        public void Deposita(double quantidade)
        {
            Saldo += quantidade;
        }
    }
}
