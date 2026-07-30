using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc08
{
    public class Dragao : IAtacavel, IVoador
    {
        public void Atacar() => Console.WriteLine("Dragão cuspiu uma bola de fogo massiva!");
        public void Voar() => Console.WriteLine("Dragão levantou voo batendo suas asas enormes! ");
    }

    public class Mago : IAtacavel, ICurador
    {
        public void Atacar() => Console.WriteLine("Mago lançou um raio arcano!");
        public void Curar() => Console.WriteLine("Mago restaurou a vida do grupo com magia divina!");
    }

    public class Paladino : IAtacavel, ICurador, IVoador
    {
        public void Atacar() => Console.WriteLine("Paladino golpeou com sua espada sagrada! ");
        public void Curar() => Console.WriteLine("Paladino aplicou imposição das mãos! ");
        public void Voar() => Console.WriteLine("Paladino voou pelos céus com seu Pégaso! ");
    }
}
