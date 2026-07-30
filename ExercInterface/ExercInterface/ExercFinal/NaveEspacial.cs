using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.ExercFinal
{
    public abstract class NaveEspacial
    {
        public string Nome { get; }

        private int combustivel;

        public NaveEspacial(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome da nave não pode ser vazio.");
            }
            Nome = nome;
            combustivel = 0;
        }

        public void Abastecer(int litros)
        {
            if (litros <= 0) return;

            combustivel += litros;
            if (combustivel > 100)
            {
                combustivel = 100; 
            }
        }

        public int NivelCombustivel()
        {
            return combustivel;
        }

        public abstract void Decolar();
    }

}
