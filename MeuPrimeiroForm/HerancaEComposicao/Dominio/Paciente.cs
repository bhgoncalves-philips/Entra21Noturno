using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEComposicao.Dominio
{
    class Paciente : Pessoa
    {
        public int NumeroAtendimento { get; set; }
        public Paciente( string nome)
        {
            Nome = nome;
            if(EhMeuAniversario(DateTime.Today))
            {

            }
        }
    }
}
