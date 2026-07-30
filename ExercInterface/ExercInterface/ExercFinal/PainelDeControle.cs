using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.ExercFinal
{
    public class PainelDeControle
    {
        public void ExibirStatus(List<NaveEspacial> frota)
        {
            Console.WriteLine("\n--- PAINEL DE CONTROLE DA FROTA ---");
            foreach (var nave in frota)
            {
                Console.WriteLine($"[Nave] {nave.Nome} | [Combustível] {nave.NivelCombustivel()}/100");
            }
            Console.WriteLine("-----------------------------------\n");
        }
    }
}
