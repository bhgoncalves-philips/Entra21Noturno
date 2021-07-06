using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEComposicao.Dominio
{
    class Pessoa
    {

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }

        public DateTime DataNascimento { get; set; }


        public bool EhMeuAniversario(DateTime date)
        {
            return DataNascimento.Month == date.Month &&
                DataNascimento.Day == date.Day;
        }


    }
}
