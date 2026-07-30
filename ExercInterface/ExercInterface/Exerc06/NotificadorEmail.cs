using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercInterface.Exerc06
{
    class NotificadorEmail : INotificador
    {
        public void EnviarMensagem(string destinatario, string msg)
        {
            if (destinatario.Contains("@"))
            {
                
                Console.WriteLine($"Enviando msg para o email {destinatario} ");
                Console.WriteLine($"\n{msg}");
            }
            else
            {
                 Console.WriteLine($"\nEmail {destinatario} é invalido! ");
            }
        }
    }
}
