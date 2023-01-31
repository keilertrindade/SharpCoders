using System;
using GameHub.Entities;
using Microsoft.VisualBasic.FileIO;

namespace GameHub{

    public class Program {

        public static Jogador jogador1;
        public static Jogador jogador2;

        //public static int jogadorVez = 1;
        public static List<Navio> navios = new List<Navio>();

        public static void Main(string[] args) {

            int option = 9;
            List<Jogador> jogadoresLogados = new List<Jogador>();
            GameHubFuncoes controladorGameHub = new GameHubFuncoes();
            GerenciadorJSON gerenciadorJSON = new GerenciadorJSON();

            do
            {
                controladorGameHub.ShowMenu();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Digite apenas números!");
                    Console.ReadKey();
                }

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Finalizando programa...");
                        break;
                    case 1:
                        controladorGameHub.CadastrarUsuario(gerenciadorJSON);
                        break;
                    case 2:
                        controladorGameHub.LoginUsuario(jogadoresLogados, gerenciadorJSON);
                        break;
                    case 3:
                        controladorGameHub.AcessarMenuJogos(jogadoresLogados, jogador1, jogador2);
                        break;
                    case 4:
                        controladorGameHub.ExibirRankingJogoDaVelha(gerenciadorJSON);
                        break;
                    case 5:
                        controladorGameHub.ExibirRankingBatalhaNaval(gerenciadorJSON);
                        break;
                    case 6:
                        controladorGameHub.Logoff(jogadoresLogados);
                        break;
                }

            }while(option != 0);
           
            }

        }
   }