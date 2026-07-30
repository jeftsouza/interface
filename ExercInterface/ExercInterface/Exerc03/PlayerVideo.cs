using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc03
{
    class PlayerVideo : IReprodutorMultimidia
    {
        public void Play()
        {
            Console.WriteLine($"Iniciou-se o video cassete!!! Bora assistir ");
        }

        public void Pause()
        {
            Console.WriteLine($"video cassete pausado!! Aquele mix basico");
        }

        public void Stop()
        {
            Console.WriteLine($"video cassete parado!! Canseiiii");
        }
        public void Avancar(int seg)
        {
            Console.WriteLine($"video cassete avancada em {seg}!! Vai enrolar a fita");
        }
    }
}
