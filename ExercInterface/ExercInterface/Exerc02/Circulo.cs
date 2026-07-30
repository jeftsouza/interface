using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc02
{
    class Circulo : IFormaGeo
    {
        public double Raio { get; set; }

        public void CalcularArea()
        {
            double area = Math.PI * this.Raio * this.Raio ;
            Console.WriteLine($"Area do circulo : {area}");
        }

        public void CalcularPerimetro()
        {
            double perimetro = 2 * Math.PI * this.Raio;
            Console.WriteLine($"Perímetro do circulo: {perimetro}");
        }

    }
}
