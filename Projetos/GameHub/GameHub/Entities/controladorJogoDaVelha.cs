using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entities
{
    public class controladorJogoDaVelha
    {
        JogoDaVelha jogoVelha;
        Jogador jogador1, jogador2;
        string novoJogo = "S";
        public controladorJogoDaVelha(Jogador jogador1, Jogador jogador2) {

             jogoVelha = new JogoDaVelha();
             this.jogador1 = jogador1;
             this.jogador2 = jogador2;
        }

        public void Controle()
        {
            do
              {
                this.Partida();
                Console.Write("\nDesejam jogar uma nova partida? (Apenas 's' para sim!)");
                novoJogo = Console.ReadLine();

                if (novoJogo == "S" || novoJogo == "s")
                {
                    jogoVelha.RedefinirTabuleiro();
                }

                } while (novoJogo == "S" || novoJogo == "s");

            Encerrar();
        }

        public void Partida()
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"{jogador1.nomeJogador}:X e {jogador2.nomeJogador}:O \n \n");

                //jogoVelha.VerificarMarcacao(jogador1, jogador2);
                Console.WriteLine("###---###---###---###\n");
                jogoVelha.MostrarCampo();
                Console.WriteLine("\n###---###---###---###");
                jogoVelha.VerificarMarcacao(jogador1, jogador2);
                jogoVelha.RealizarJogada();

            } while (jogoVelha.VerificarJogo());

            Console.Clear();
            jogoVelha.MostrarCampo();
            jogoVelha.VerificarVencedor(jogador1, jogador2);
        }

        public void Encerrar()
        {
            /*Console.WriteLine($"\nSequência de partidas finalizou com as seguintes estátisticas: \n" +
                $"{jogoVelha.partidas} partidas \n{jogador1.nomeJogador}: {jogador1.vitoriasJogoDaVelha} vitórias totais.\n" +
                $"{jogador2.nomeJogador}: {jogador2.vitoriasJogoDaVelha} vitórias totais."); */
            Console.ReadKey();
        }
    }
}
