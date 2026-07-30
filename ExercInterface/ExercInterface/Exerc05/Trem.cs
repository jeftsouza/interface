using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc05
{
    class Trem : ITransporte
    {
        public void IniciarViagem(string destino)
        {
            Console.WriteLine($"Comecou a viagem de trem para {destino}! Prepare a sungaaaa ");
        }

        public void FinalizarViagem()
        {
            Console.WriteLine($"Chegooou de trem! Não furou nenhum pneu ");
        }
    }
}
