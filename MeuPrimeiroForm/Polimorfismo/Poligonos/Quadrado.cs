using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Poligonos
{
    class Quadrado : Poligono, IPerimetro
    {
        public int Tamanho { get; set; }
        

        public Quadrado()
        {
            Arestas = 4;
        }
        public override int Area()
        {
            return Tamanho * Tamanho;
        }

        public double Perimetro()
        {
            return 4 * Tamanho;
        }
    }
}
