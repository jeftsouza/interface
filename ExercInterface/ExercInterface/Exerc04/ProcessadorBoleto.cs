using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc04
{
    class ProcessadorBoleto : IProcessadorPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Iniciou o pagamento de {valor} com Boleto ");
        }
        public void CancelarPagamento()
        {
            Console.WriteLine($"Pagamento com boleto cancelado! ");
        }
    }
}
