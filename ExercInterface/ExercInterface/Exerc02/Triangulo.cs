using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc02
{
    class Triangulo : IFormaGeo
    {

        public double Base { get; set; }
        public double Altura { get; set; }
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }


        public void CalcularArea()
        {
            double area = (Base * Altura) / 2;
            Console.WriteLine($"Area do triangulo : {area}");
        }

        public void CalcularPerimetro()
        {
            double perimetro = LadoA + LadoB + LadoC;
            Console.WriteLine($"Perímetro do Triângulo: {perimetro}");
        }
    }
}
