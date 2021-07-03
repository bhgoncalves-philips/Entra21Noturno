using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaOO.Dominio
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 100;
        }

        public Conta(int numero)
        {
            Numero = numero;
            Saldo = 100;
        }

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
