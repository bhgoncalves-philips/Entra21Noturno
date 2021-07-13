using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Dominio
{
    public class Professor : Pessoa
    {
        public string Turno { get; set; }
        public double SalarioHora { get; set; }

        public override string ToString()
        {
            return $"{Nome} - {Turno}";
        }
    }
}
