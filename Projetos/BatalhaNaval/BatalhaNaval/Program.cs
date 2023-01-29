using System;
using System.Collections.Generic;
using System.Data;
using BatalhaNaval.Entities;


namespace BatalhaNaval
{
    class Program
    {
        public static int jogadorVez = 1;
        public static int pontuacaoJ1 = 0;
        public static int pontuacaoJ2 = 0;

        static Jogador jogador1;
        static Jogador jogador2;

        public static Navio bote = new Navio(2, 1, "bote");
        public static Navio bote1 = new Navio(2, 1, "bote");
        public static Navio bote2 = new Navio(2, 1, "bote");
        public static Navio bote3 = new Navio(2, 1, "bote");
        public static Navio corveta = new Navio(20, 2,"Corveta");
        public static Navio submarino = new Navio(30, 3, "submarino");
        public static Navio submarino2 = new Navio(30, 3, "submarino");
        public static Navio fragata = new Navio(30, 3, "fragata");
        public static Navio fragata2 = new Navio(30, 3, "fragata");
        public static Navio destroyer = new Navio(40, 4, "destroyer");
        public static Navio cruzador = new Navio(50, 5, "cruzador");
        public static Navio portaAvioes = new Navio(60, 6, "portaAvioes");

        public static List<Navio> navios = new List<Navio>();
                

        public static void Main(string[] args) { 
            
            Campo tabuleiro = new Campo();
            int naviosDerrubados = 0;

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

            tabuleiro.PovoarCampo(navios);

            Console.Write("Insira o nome do Jogador 1: ");
            string? temp = Console.ReadLine();
            jogador1 = new Jogador(temp);

            Console.Write("Insira o nome do Jogador 2: ");
            temp = Console.ReadLine();
            jogador2 = new Jogador(temp);

            do
            {
                Console.Clear();
                tabuleiro.ExibirCampo();
                Console.WriteLine();
                for (int i = 0; i < tabuleiro.coordenadasNavios.Count; i++)
                {
                    Console.Write($"[{tabuleiro.coordenadasNavios[i]}] ");
                }
                Console.WriteLine();
                Console.WriteLine($"Pontuação {jogador1.Nome}: {jogador1.pontuacao} --- Pontuacao {jogador2.Nome}: {jogador2.pontuacao}");
                
                //tabuleiro.ExibirPontuacao(passando objetos de jogadores);
                if(jogadorVez % 2 == 1)
                    tabuleiro.ValidarBomba(jogador1);
                else
                    tabuleiro.ValidarBomba(jogador2);

            } while(tabuleiro.quantidadeNavios != tabuleiro.naviosAfundados);

            tabuleiro.EncerrarJogo();

        }
    }
}