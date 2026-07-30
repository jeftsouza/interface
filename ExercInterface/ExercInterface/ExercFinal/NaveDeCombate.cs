using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.ExercFinal
{
    public class NaveDeCombate : NaveEspacial
    {
        public NaveDeCombate(string nome) : base(nome) { }

        public override void Decolar()
        {
            Console.WriteLine($"{Nome} (Combate): Ágil, acionando pós-combustores... decolagem brusca e veloz!");
        }
    }
}
