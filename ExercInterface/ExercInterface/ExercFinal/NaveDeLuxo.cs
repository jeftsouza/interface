using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.ExercFinal
{
    public class NaveDeLuxo : NaveEspacial, ITeletransportavel
    {
        public NaveDeLuxo(string nome) : base(nome) { }

        public override void Decolar()
        {
            Console.WriteLine($"{Nome} (Luxo): Cruzeiro Groovy decolando em estilo, com luzes neon e som espacial nas caixas!");
        }

        public void Teletransportar(string destino)
        {
            Console.WriteLine($"{Nome}: Iniciando salto quântico de luxo com destino a {destino}...");
        }
    }
}
