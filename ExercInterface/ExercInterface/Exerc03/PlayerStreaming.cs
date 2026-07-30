using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc03
{
    class PlayerStreaming : IReprodutorMultimidia
    {
        public void Play()
        {
            Console.WriteLine($"Iniciou-se a streaming!!! Vamos assistir ");
        }

        public void Pause()
        {
            Console.WriteLine($"Streaming pausado!! Vai buscar pipoca");
        }

        public void Stop()
        {
            Console.WriteLine($"Streaming parado!! Vai caga miseraver??");
        }
        public void Avancar(int seg)
        {
            Console.WriteLine($"Streaming chato... Avancou {seg}!! ");
        }
    }
}
