using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc01
{
    public class Cachorro : IAnimal
    {
        public void Falar()
        {
            Console.WriteLine("Cachorro late: Au Auuuu!!");
        }

        public void Mover()
        {
            Console.WriteLine("Cachorro corre com 4 patas!!");
        }
    }
}
