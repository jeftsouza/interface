using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc03
{
    public interface IReprodutorMultimidia
    {
        void Play();
        void Pause();
        void Stop();
        void Avancar(int Seg);
    }
}
