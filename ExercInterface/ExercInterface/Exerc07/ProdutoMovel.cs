using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc07
{
    class ProdutoMovel : IFretavel
    {

        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public decimal CalcularFrete(decimal distanciaKm)
        {
            decimal taxa = 20.00m;
            taxa += 2.50m * distanciaKm;

            Console.WriteLine($"Calculando Frete");
            Console.WriteLine($"Produto: {this.Nome}");
            Console.WriteLine($"Preço: {this.Preco}");
            Console.WriteLine($"--------------------");            
            Console.WriteLine($"Frete Movel: {taxa}");
            Console.WriteLine($"--------------------\n");

            return taxa;

        }
    }
}
