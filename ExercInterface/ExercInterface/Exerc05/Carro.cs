using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc05
{
    class Carro : ITransporte
    {
        public void IniciarViagem(string destino)
        {
            Console.WriteLine($"Comecou a viagem de carro para {destino}! Prepare a bunda pq vai ser longeee ");
        }

        public void FinalizarViagem()
        {
            Console.WriteLine($"Chegooou de carro! Descole a bunda do banco e vai beber ");
        }
    }
}
