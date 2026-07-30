using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc05
{
    class Aviao : ITransporte
    {
        public void IniciarViagem(string destino)
        {
            Console.WriteLine($"Comecou a viagem de aviao para {destino}! Prepare a sungaaaa ");
        }

        public void FinalizarViagem()
        {
            Console.WriteLine($"Chegooou! Coloque a sunga e vai beber ");
        }
    }
}
