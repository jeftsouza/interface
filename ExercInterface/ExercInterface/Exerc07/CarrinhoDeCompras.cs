using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc07
{
    public class CarrinhoDeCompras
    {
        public List<IFretavel> Itens { get; set; } = new List<IFretavel>();

        public decimal CalcularFreteTotal(decimal distanciaKm)
        {
            decimal freteTotal = 0m;

            foreach (var item in Itens)
            {
                freteTotal += item.CalcularFrete(distanciaKm);
            }

            return freteTotal;
        }
    }
}
