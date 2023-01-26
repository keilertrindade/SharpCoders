using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoDaVelha.Entities;

namespace JogoDaVelha.Entities
{
    public class JogoDaVelhaClasse
    {
        public char[] tabuleiro = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public int jogadas;
        public int jogadorDaVez;
        public int posicaoJogada;
        public int partidas;
        int vencedor;

        public char marcacao;


        public JogoDaVelhaClasse()
        {
            jogadas = 0;
            partidas= 0;
            jogadorDaVez = 1;
        }

        public void RealizarJogada()
        {
            do
            {
                Console.Write("Selecione a posição da jogada: ");
                posicaoJogada = int.Parse(Console.ReadLine());
                if (posicaoJogada < 1 || posicaoJogada > 9)
                {
                    Console.WriteLine("Digite um valor entre 1 e 9!");
                }


            } while (posicaoJogada < 1 || posicaoJogada > 9);

            if (tabuleiro[posicaoJogada] != '0' && tabuleiro[posicaoJogada] != 'X')
            {
                tabuleiro[posicaoJogada] = marcacao;
                jogadorDaVez++;
                jogadas++;
            }
            else
            {
                Console.WriteLine("Posição já marcada!");
                Console.ReadLine();
            }
        }

        public void VerificarMarcacao(Jogador j1, Jogador j2)
        {
            if (jogadorDaVez % 2 == 1)
            {
                Console.WriteLine($"Vez do(a): {j1.Nome}");
                marcacao = 'X';
            }
            else
            {
                Console.WriteLine($"Vez do(a): {j2.Nome}");
                marcacao = 'O';
            }
        }

        public void MostrarCampo()
        {
            Console.WriteLine("{0} {1} {2}", tabuleiro[1], tabuleiro[2], tabuleiro[3]);
            Console.WriteLine("{0} {1} {2}", tabuleiro[4], tabuleiro[5], tabuleiro[6]);
            Console.WriteLine("{0} {1} {2}", tabuleiro[7], tabuleiro[8], tabuleiro[9]);
        }

        public bool VerificarJogo()
        {
            //Horizontal
            if (tabuleiro[1] == tabuleiro[2] && tabuleiro[2] == tabuleiro[3])
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
            else if (jogadas == 9)
            {
                vencedor = -1;
                return false;
            }
            else
            {
                return true;
            }
        }

        public void VerificarVencedor(Jogador j1, Jogador j2)
        {
            partidas++;
            if (vencedor == -1)
            {
                Console.WriteLine("O jogo empatou!");
            }
            else
            {
                if (jogadas % 2 == 1)
                {
                    Console.WriteLine($"Parabéns {j1.Nome} você venceu o jogo com {jogadas} jogadas!");
                    j1.Vitoria();
                }
                else
                {
                    Console.WriteLine($"Parabéns {j2.Nome} você venceu o jogo com {jogadas} jogadas!");
                    j2.Vitoria();
                }
            }

        }

        public void RedefinirTabuleiro()
        {
            for(int i = 0; i < 10; i++)
            {
                tabuleiro[i] = (char)(i + 48);
            }
            jogadas = 0;
            jogadorDaVez = 1;
        }




    }
}

