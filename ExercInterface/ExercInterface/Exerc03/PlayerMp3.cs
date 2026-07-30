using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc03
{
    class PlayerMp3 : IReprodutorMultimidia
    {
        public void Play()
        {
            Console.WriteLine($"Iniciou-se a musica!!! Cala a boca e ouveeeee ");
        }

        public void Pause()
        {
            Console.WriteLine($"Musica pausada!! Q falha graveeee");
        }

        public void Stop()
        {
            Console.WriteLine($"Musica parada!! Pecado inadmissivel");
        }
        public void Avancar(int seg)
        {
            Console.WriteLine($"Musica avancada em {seg}!! Naaaaoooo");
        }

    }
}
