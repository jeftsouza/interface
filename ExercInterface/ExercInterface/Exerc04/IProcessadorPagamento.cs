using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc04
{
    public interface IProcessadorPagamento

    {
        void ProcessarPagamento(decimal valor);
        void CancelarPagamento();
    }
}
