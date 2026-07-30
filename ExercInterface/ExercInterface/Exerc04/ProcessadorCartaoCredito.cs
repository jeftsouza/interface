using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc04
{
    class ProcessadorCartaoCredito : IProcessadorPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Iniciou o pagamento de {valor} com cartao de credito ");
        }
        public void CancelarPagamento()
        {
            Console.WriteLine($"Pagamento com cartao de credito cancelado! ");
        }
    }
}
