using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entities
{
    internal class controladorBatalhaNaval
    {
        BatalhaNaval batalhaNaval;
        Jogador jogador1, jogador2;
        int controladorVezJogador = 0;

        public controladorBatalhaNaval(Jogador jogador1, Jogador jogador2)
        {
            batalhaNaval = new BatalhaNaval();
            this.jogador1 = jogador1;
            this.jogador2 = jogador2;
        }

        public void IniciarJogo(Jogador jogador1, Jogador jogador2)
        {
            Navio bote = new Navio(2, 1, "bote");
            Navio bote1 = new Navio(2, 1, "bote");
            Navio bote2 = new Navio(2, 1, "bote");
            Navio bote3 = new Navio(2, 1, "bote");
            Navio corveta = new Navio(20, 2, "Corveta");
            Navio submarino = new Navio(30, 3, "submarino");
            Navio submarino2 = new Navio(30, 3, "submarino");
            Navio fragata = new Navio(30, 3, "fragata");
            Navio fragata2 = new Navio(30, 3, "fragata");
            Navio destroyer = new Navio(40, 4, "destroyer");
            Navio cruzador = new Navio(50, 5, "cruzador");
            Navio portaAvioes = new Navio(60, 6, "portaAvioes");

            List<Navio> navios = new List<Navio>();

            navios.Add(bote);
            navios.Add(bote1);
            navios.Add(bote2);
            navios.Add(bote3);
            navios.Add(corveta);
            navios.Add(submarino);
            navios.Add(submarino2);
            navios.Add(fragata);
            navios.Add(fragata2);
            navios.Add(destroyer);
            navios.Add(cruzador);
            navios.Add(portaAvioes);

            batalhaNaval.PovoarCampo(navios);
            Partida(jogador1, jogador2, navios);

        }

        public void Partida(Jogador jogador1, Jogador jogador2, List<Navio> navios)
        {
            do
            {
                Console.Clear();
                batalhaNaval.ExibirCampo();
                Console.WriteLine();

                for (int i = 0; i < batalhaNaval.coordenadasNavios.Count; i++)
                {
                    Console.Write($"[{batalhaNaval.coordenadasNavios[i]}] ");
                }
                Console.WriteLine();
                batalhaNaval.ExibirPontuacaoJogadores(jogador1, jogador2);
                //Console.ReadLine();

                if (batalhaNaval.jogadordaVez % 2 == 1)
                {
                    batalhaNaval.ValidarBomba(jogador1, navios);
                }
                else
                {
                    batalhaNaval.ValidarBomba(jogador2, navios);
                }
            } while(batalhaNaval.emAndamento);

            batalhaNaval.EncerrarJogo(jogador1, jogador2);
        }
    }
}
