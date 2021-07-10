using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Poligonos
{
    abstract class Poligono
    {
        public int Arestas { get; set; }

        public abstract int Area();
    }
}
