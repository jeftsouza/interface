using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.ExercFinal
{
    public class NaveExploradora : NaveEspacial, ITeletransportavel
    {
        public NaveExploradora(string nome) : base(nome) { }

        public override void Decolar()
        {
            Console.WriteLine($"{Nome} (Exploradora): Desacoplamento silencioso... saindo para mapear o espaço desconhecido.");
        }

        public void Teletransportar(string destino)
        {
            Console.WriteLine($"{Nome}: Salto de mapeamento instantâneo para as coordenadas de {destino}.");
        }
    }
}
