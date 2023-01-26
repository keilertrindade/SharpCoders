using System;
using System.Runtime.CompilerServices;
using JogoDaVelha.Entities;


namespace JogoDaVelha
{
    class Program
    {
        /*
        static char[] tabuleiro = {'0','1', '2', '3', '4', '5', '6', '7', '8', '9'};
        static char marcacao;
        static int jogadorDaVez = 1;
        static int posicaoJogada;
        static int jogadas = 0;

        static bool controlador = true;
        */


        static Jogador jogador1;
        static Jogador jogador2;
        static JogoDaVelhaClasse jogoVelha;

        private static void Main(string[] args)
        {
            Console.Write("Insira o nome do Jogador 1: ");
            string? temp = Console.ReadLine();
            jogador1 = new Jogador(temp);

            Console.Write("Insira o nome do Jogador 2: ");
            temp = Console.ReadLine();
            jogador2 = new Jogador(temp);

            jogoVelha = new JogoDaVelhaClasse();
            string novoJogo = "S";

            do
            {
                PartidaJogoVelha();
                Console.Write("\nDesejam jogar uma nova partida? ");
                novoJogo = Console.ReadLine();

                if(novoJogo == "S" || novoJogo == "s")
                {
                    jogoVelha.RedefinirTabuleiro();
                }

            } while(novoJogo == "S" || novoJogo == "s");

            Console.WriteLine($"\nSequência de partidas finalizou com as seguintes estátisticas: \n" +
                $"{jogoVelha.partidas} partidas \n{jogador1.Nome}: {jogador1.vitorias} vitórias.\n" +
                $"{jogador2.Nome}: {jogador2.vitorias} vitórias.");
        }

        public static void PartidaJogoVelha()
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"{jogador1.Nome}:X e {jogador2.Nome}:O \n \n");

                jogoVelha.VerificarMarcacao(jogador1, jogador2);
                Console.WriteLine("###---###---###---###---###---###---###\n");

                jogoVelha.MostrarCampo();
                jogoVelha.VerificarMarcacao(jogador1, jogador2);
                jogoVelha.RealizarJogada();

            } while (jogoVelha.VerificarJogo());

            Console.Clear();
            jogoVelha.MostrarCampo();
            jogoVelha.VerificarVencedor(jogador1, jogador2);
        }

       }
    }
