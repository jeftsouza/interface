using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc06
{
    public interface INotificador
    {
        void EnviarMensagem(string destinatario, string msg);
    }
}
