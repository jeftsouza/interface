using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc01
{
    public class Gato : IAnimal
    {
        public void Falar()
        {
            Console.WriteLine("Gato Mia: Miau!");
        }

        public void Mover()
        {
            Console.WriteLine("Gato: Nao anda... só come e dorme...");
        }
    }
}
