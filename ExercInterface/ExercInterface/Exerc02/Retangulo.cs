using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc02
{
    class Retangulo : IFormaGeo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public void CalcularArea()
        {
            double area = this.Base * this.Altura;
            Console.WriteLine($"Area do retangulo : {area}");
        }

        public void CalcularPerimetro()
        {
            double perimetro = 2 * (this.Base + this.Altura);
            Console.WriteLine($"Perímetro do retangulo: {perimetro}");
        }
    }
}
