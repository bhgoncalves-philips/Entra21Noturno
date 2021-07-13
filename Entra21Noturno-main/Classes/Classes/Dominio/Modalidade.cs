using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Dominio
{
    public class Modalidade : IMensalidade
    {
        public Professor Professor { get; set; }
        public int VezesSemana { get; set; }
        public double PrecoHora { get; set; }
        public string  Nome { get; set; }

        public double CalculaValor()
        {
            return PrecoHora * VezesSemana * 4;
        }
    }
}
