using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc05
{
    public interface ITransporte
    {
        void IniciarViagem(string destino);
        void FinalizarViagem();
    }
}
