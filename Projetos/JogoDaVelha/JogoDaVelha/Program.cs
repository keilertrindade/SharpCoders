using System;
using System.Runtime.CompilerServices;
using JogoDaVelha.Entities;


namespace JogoDaVelha
{
    class Program
    {
        static char[] tabuleiro = {'0','1', '2', '3', '4', '5', '6', '7', '8', '9'};
        static char marcacao;
        static int jogadorDaVez = 1;
        static int posicaoJogada;
        static int jogadas = 0;

        static bool controlador = true;
        static int ultimoJogador;
        static int vencedor; // -1 -> Empate, 1-> Jogador 1, 2-> Jogador 2

        static Jogador jogador1;
        static Jogador jogador2;

        private static void Main(string[] args)
        {
            Console.Write("Insira o nome do Jogador 1: ");
            string temp = Console.ReadLine();
            jogador1 = new Jogador(temp);

            Console.Write("Insira o nome do Jogador 2: ");
            temp = Console.ReadLine();
            jogador2 = new Jogador(temp);

            do
            {
                
                Console.WriteLine($"{jogador1.Nome}:X e {jogador2.Nome}:O");
                Console.WriteLine();

                if (jogadorDaVez % 2 == 1)
                {
                    Console.WriteLine($"Vez do(a): {jogador1.Nome}");
                    marcacao = 'X';
                }
                else
                {
                    Console.WriteLine($"Vez do(a): {jogador2.Nome}");
                    marcacao = 'O';
                }

                Console.WriteLine("###---###---###---###---###---###---###");
                mostrarCampo();
                do
                {
                    Console.Write("Selecione a posição da jogada: ");
                    posicaoJogada = int.Parse(Console.ReadLine());
                    if(posicaoJogada < 1 || posicaoJogada > 9)
                    {
                        Console.WriteLine("Digite um valor entre 1 e 9!");
                    }


                }while(posicaoJogada < 1 || posicaoJogada > 9);

                if (tabuleiro[posicaoJogada] != '0' && tabuleiro[posicaoJogada] != 'X')
                {
                    tabuleiro[posicaoJogada] = marcacao;
                    ultimoJogador = jogadorDaVez;
                    jogadorDaVez++;
                    jogadas++;
                }
                else
                {
                    Console.WriteLine("Posição já marcada!");
                    Console.ReadLine();
                }
                Console.Clear();
                controlador = verificarJogo();
            } while(controlador);
            Console.Clear();
            mostrarCampo();


            if (vencedor == -1)
            {
                Console.WriteLine("O jogo empatou!");
            }
            else if(jogadas % 2 == 1)
            {
                Console.WriteLine($"Parabéns {jogador1.Nome} você venceu o jogo com {jogadas} jogadas!");
            }else if (jogadas % 2 == 0)
            {
                Console.WriteLine($"Parabéns {jogador2.Nome} você venceu o jogo com {jogadas} jogadas!");
            }
            Console.WriteLine($"Em {jogadas} jogadas!");
        }

        private static void mostrarCampo()
        {
            Console.WriteLine("{0} {1} {2}", tabuleiro[1], tabuleiro[2], tabuleiro[3]);
            Console.WriteLine("{0} {1} {2}", tabuleiro[4], tabuleiro[5], tabuleiro[6]);
            Console.WriteLine("{0} {1} {2}", tabuleiro[7], tabuleiro[8], tabuleiro[9]);
        }

        private static bool verificarJogo()
        {
            //Horizontal
            if(tabuleiro[1] == tabuleiro[2] && tabuleiro[2] == tabuleiro[3])
            {
                return false;
            }
            else if (tabuleiro[4] == tabuleiro[5] && tabuleiro[5] == tabuleiro[6])
            {
                return false;
            }
            else if (tabuleiro[7] == tabuleiro[8] && tabuleiro[8] == tabuleiro[9])
            {
                return false;
            }
            //Vertical
            else if (tabuleiro[1] == tabuleiro[4] && tabuleiro[4] == tabuleiro[7])
            {
                return false;
            }
            else if (tabuleiro[2] == tabuleiro[5] && tabuleiro[5] == tabuleiro[8])
            {
                return false;
            }
            else if (tabuleiro[3] == tabuleiro[6] && tabuleiro[6] == tabuleiro[9])
            {
                return false;
            }
            //Diagonais
            else if (tabuleiro[1] == tabuleiro[5] && tabuleiro[5] == tabuleiro[9])
            {
                return false;
            }
            else if (tabuleiro[3] == tabuleiro[5] && tabuleiro[5] == tabuleiro[7])
            {
                return false;
            }
            else if(jogadas == 9)
            {
                vencedor = -1;
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}