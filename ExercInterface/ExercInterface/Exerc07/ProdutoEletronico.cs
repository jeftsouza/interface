using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc07
{
    class ProdutoEletronico : IFretavel
    {

        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public decimal CalcularFrete(decimal distanciaKm)
        {
            decimal taxa = 0.00m;
            taxa += 1.00m * distanciaKm;

            Console.WriteLine($"Calculando Frete");
            Console.WriteLine($"Produto: {this.Nome}");
            Console.WriteLine($"Preço: {this.Preco}");
            Console.WriteLine($"--------------------");
            Console.WriteLine($"Frete Eletronico: {taxa}");
            Console.WriteLine($"--------------------\n");


            return taxa;

        }
    }
}
