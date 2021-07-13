using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Poligonos
{
    class Retangulo :Poligono,IPerimetro
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public Retangulo()
        {
            Arestas = 4;
            IPerimetro perimetro = this;
        }
        public override int Area()
        {
            return Base * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
