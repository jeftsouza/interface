using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc01
{
    public class Passaro : IAnimal
    {
        public void Falar()
        {
            Console.WriteLine("Pássaro: Piu Piu!");
        }

        public void Mover()
        {
            Console.WriteLine("Pássaro: Voando...");
        }

    }
}
