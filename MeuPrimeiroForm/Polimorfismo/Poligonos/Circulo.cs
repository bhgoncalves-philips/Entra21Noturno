using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Poligonos
{
    class Circulo : Poligono, IPerimetro
    {
        public int Raio { get; set; }
        public override int Area()
        {
            return Convert.ToInt32(Math.PI * Raio * Raio);
        }

        public double Perimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}
