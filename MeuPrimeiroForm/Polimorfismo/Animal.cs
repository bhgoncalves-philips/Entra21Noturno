using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    abstract class Animal
    {
        public int NumeroPatas { get; set; }
        abstract public string fazBarulho();

        public void Caminhar()
        {

        }
        
    }
}