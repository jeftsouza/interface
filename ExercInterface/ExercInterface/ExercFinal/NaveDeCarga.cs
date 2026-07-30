using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.ExercFinal
{
    public class NaveDeCarga : NaveEspacial
    {
        public NaveDeCarga(string nome) : base(nome) { }

        public override void Decolar()
        {
            Console.WriteLine($"{Nome} (Carga): Pesada, ligando propulsores principais... decolando devagar.");
        }
    }
}
