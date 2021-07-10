using Polimorfismo.Poligonos;
using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerimetro> poligonos = new List<IPerimetro>();
            Quadrado quadrado = new Quadrado()
            {
                Tamanho = 4
            };
            poligonos.Add(quadrado);

            Retangulo retangulo = new Retangulo()
            {
                Base = 4,
                Altura = 5
            };
            poligonos.Add(retangulo);

            Circulo circulo = new Circulo()
            {
                Raio = 4
            };
            poligonos.Add(circulo);

            foreach (var poligono in poligonos)
            {
                Console.WriteLine(poligono.Perimetro());

            }



        }
    }
}
