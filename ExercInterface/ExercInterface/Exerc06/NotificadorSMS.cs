using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc06
{
    class NotificadorSMS : INotificador
    {
        public void EnviarMensagem(string destinatario, string msg)
        {
            if (destinatario.Contains("@"))
            {
                Console.WriteLine($"\nNão foi encontrado o numero {destinatario} ou é invalido! ");
            }
            else
            {
                Console.WriteLine($"Enviando msg para {destinatario} via SMS ");
                Console.WriteLine($"\n{msg}");
            }
        }
    }
}
