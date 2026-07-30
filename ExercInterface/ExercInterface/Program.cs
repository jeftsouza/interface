using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercInterface.Exerc01;
using ExercInterface.Exerc02;
using ExercInterface.Exerc03;
using ExercInterface.Exerc04;
using ExercInterface.Exerc05;
using ExercInterface.Exerc06;
using ExercInterface.Exerc07;
using ExercInterface.Exerc08;
using ExercInterface.Exerc09;
using ExercInterface.ExercFinal;


namespace ExercInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ExercFinal();
            /*
            Exerc01();
            Exerc02();
            Exerc03();
            Exerc04();
            Exerc05();
            Exerc06();
            Exerc07();
            Exerc08();
            Exerc09();
            */
            Console.ReadLine();

        }

        private static void ExercFinal()
        {
            List<NaveEspacial> frota = new List<NaveEspacial>
            {
                new NaveDeCarga("Zepelim Estelar"),
                new NaveDeCombate("Falcão RubrO"),
                new NaveDeLuxo("Stellar Groove"),
                new NaveExploradora("Horizonte de Eventos") 
            };

            frota[0].Abastecer(50);
            frota[1].Abastecer(80);
            frota[2].Abastecer(30);
            frota[3].Abastecer(100);

            Console.WriteLine("=== DECOLAGEM ===");
            foreach (var nave in frota)
            {
                nave.Decolar(); 
            }

            PainelDeControle painel = new PainelDeControle();
            painel.ExibirStatus(frota);

            Console.WriteLine("=== TELETRANSPORTE ===");
            foreach (var nave in frota)
            {
                if (nave is ITeletransportavel naveTeletransportavel)
                {
                    naveTeletransportavel.Teletransportar("Sistema Alpha Centauri");
                }
            }

            Console.WriteLine("\n=== CENTRAL DE DOCAS ===");
            CentralDeDocas docas = new CentralDeDocas();

            docas.AutorizarDecolagem(frota[0]); 
            docas.AutorizarDecolagem(frota[3]); 
        }

        private static void Exerc09()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("--------EXERC 09-------------");
            Console.WriteLine("-----------------------------");

            IFonteDados banco = new BancoDadosVendas();
            IExportador pdf = new ExportadorPDF();

            GeradorRelatorio relatorio1 = new GeradorRelatorio(banco, pdf);
            relatorio1.Processar();

            Console.WriteLine("\n-----------------------------");

            IFonteDados api = new ApiExternaVendas();
            IExportador json = new ExportadorJSON();

            GeradorRelatorio relatorio2 = new GeradorRelatorio(api, json);
            relatorio2.Processar();

            Console.WriteLine("********************");
        }

        private static void Exerc08()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("--------EXERC 08-------------");
            Console.WriteLine("-----------------------------");

            Dragao dragao = new Dragao();
            Mago mago = new Mago();
            Paladino paladino = new Paladino();

            List<IAtacavel> atacantes = new List<IAtacavel> { dragao, mago, paladino };

            Console.WriteLine("--- ATAQUE EM LOTE DAS TROPAS ---");
            foreach (var atacante in atacantes)
            {
                atacante.Atacar();
            }

            Console.WriteLine("\n---------------------------------");

            Console.WriteLine("--- HABILIDADES ESPECÍFICAS ---");
            mago.Curar();
            dragao.Voar();
            paladino.Voar();

            Console.WriteLine("********************");
        }

        private static void Exerc07()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("--------EXERC 07-------------");
            Console.WriteLine("-----------------------------");

            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            ProdutoMovel sofa = new ProdutoMovel { Nome = "Sofá 3 Lugares", Preco = 1500.00m };
            ProdutoLivro livro = new ProdutoLivro { Nome = "C# Como Programar", Preco = 120.00m };
            ProdutoEletronico tv = new ProdutoEletronico { Nome = "Smart TV 55'", Preco = 2800.00m };

            carrinho.Itens.Add(sofa);
            carrinho.Itens.Add(livro);
            carrinho.Itens.Add(tv);

            decimal distancia = 50m;

            Console.WriteLine($"\n--- Calculando Frete para {distancia} Km ---");

            decimal valorTotalFrete = carrinho.CalcularFreteTotal(distancia);

            Console.WriteLine("=====================================");
            Console.WriteLine($"VALOR TOTAL DO FRETE DO CARRINHO: R$ {valorTotalFrete}");
            Console.WriteLine("=====================================");
        }

        private static void Exerc06()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("--------EXERC 06-------------");
            Console.WriteLine("-----------------------------");


            NotificadorWhatsApp Zap = new NotificadorWhatsApp();
            NotificadorSMS Sms = new NotificadorSMS();
            NotificadorEmail Email = new NotificadorEmail();


            List<INotificador> msgs = new List<INotificador>
            {
                Zap,
                Sms,
                Email

            };

            // O foreach chama os métodos de todas as formas automaticamente!
            foreach (var msg in msgs)
            {
                msg.EnviarMensagem("1955584","sua viagem para Buzios foi confirmadaaaaa");
                

                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("********************");

        }

        private static void Exerc05()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("--------EXERC 05-------------");
            Console.WriteLine("-----------------------------");


            Trem Trem = new Trem();
            Aviao Aviao = new Aviao();
            Carro Carro = new Carro();


            List<ITransporte> transportes = new List<ITransporte>
            {
                Trem,
                Aviao,
                Carro

            };

            // O foreach chama os métodos de todas as formas automaticamente!
            foreach (var meio in transportes)
            {
                meio.IniciarViagem("Buzios");
                meio.FinalizarViagem();

                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("********************");

        }

        private static void Exerc04()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("--------EXERC 04-------------");
            Console.WriteLine("-----------------------------");


            ProcessadorBoleto Bol = new ProcessadorBoleto();
            ProcessadorPayPal PayPal = new ProcessadorPayPal();
            ProcessadorCartaoCredito Cartao = new ProcessadorCartaoCredito();


            List<IProcessadorPagamento> pagamentos = new List<IProcessadorPagamento>
            {
                Bol,
                PayPal,
                Cartao

            };

            // O foreach chama os métodos de todas as formas automaticamente!
            foreach (var tipo in pagamentos)
            {
                tipo.ProcessarPagamento(127.85m);
                tipo.CancelarPagamento();

                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("********************");

        }

        private static void Exerc03()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("--------EXERC 03-------------");
            Console.WriteLine("-----------------------------");


            PlayerMp3 Mp3 = new PlayerMp3 ();
            PlayerStreaming Stream = new PlayerStreaming();
            PlayerVideo Video = new PlayerVideo();


            List<IReprodutorMultimidia> players = new List<IReprodutorMultimidia>
            {
                Mp3,
                Stream,
                Video

            };

            // O foreach chama os métodos de todas as formas automaticamente!
            foreach (var xPlay in players)
            {
                xPlay.Play();
                xPlay.Pause();
                xPlay.Stop();
                xPlay.Avancar(8);
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("********************");

        }

        private static void Exerc02()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("--------EXERC 02-------------");
            Console.WriteLine("-----------------------------");


            Triangulo tri = new Triangulo { Base = 10, Altura = 5, LadoA = 10, LadoB = 8, LadoC = 6 };
            Circulo cir = new Circulo { Raio = 6 };
            Retangulo ret = new Retangulo { Base = 20, Altura = 16 };

            List<IFormaGeo> formas = new List<IFormaGeo>
            {
                tri,
                cir,
                ret
            };

            // O foreach chama os métodos de todas as formas automaticamente!
            foreach (var forma in formas)
            {
                forma.CalcularArea();
                forma.CalcularPerimetro();
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("********************");
            
        }

        public static void Exerc01()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("--------EXERC 01-------------");
            Console.WriteLine("-----------------------------");

            List<IAnimal> meusAnimais = new List<IAnimal>
            {
                new Cachorro(),
                new Gato(),
                new Passaro()
            };

            foreach (var animal in meusAnimais)
            {
                animal.Falar();
                animal.Mover();
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("********************");


        }

    }
}
