using System;
using GameHub.Entities;
using Microsoft.VisualBasic.FileIO;

namespace GameHub{

    public class Program {

        public static Jogador jogador1;
        public static Jogador jogador2;

        public static int jogadorVez = 1;
        public static List<Navio> navios = new List<Navio>();

        public static void Main(string[] args) {

            //Jogador jogador1, jogador2;
            int option;
            List<Jogador> jogadoresLogados = new List<Jogador>();
            GameHubFuncoes controladorGameHub = new GameHubFuncoes();
            GerenciadorJSON gerenciadorJSON = new GerenciadorJSON();

            jogador1 = new Jogador("Keiler");
            jogador2 = new Jogador("Trindade");

            jogadoresLogados.Add(jogador1);
            jogadoresLogados.Add(jogador2);


            do
            {
                controladorGameHub.ShowMenu();
                option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 0:
                        Console.WriteLine("Estou encerrando o programa...");
                        break;
                    case 1:
                        controladorGameHub.CadastrarUsuario();
                        break;
                    case 2:
                        controladorGameHub.LoginUsuario(jogadoresLogados);
                        break;
                    case 3:
                        controladorGameHub.AcessarMenuJogos(jogadoresLogados, jogador1, jogador2);
                        break;
                    case 4:

                        //controladorGameHub.ExibirRankingJogoDaVelha();
                        gerenciadorJSON.SalvarRankingJogoDaVelha();
                        break;
                    case 5:
                        controladorGameHub.ExibirRankingBatalhaNaval();
                        break;
                    case 6:
                        controladorGameHub.Logoff(jogadoresLogados);
                        break;
                }

            }while(option != 0);
            //while(option != 0 && jogadoresLogados.Count < 2);

            //controladorGameHub.AcessarMenuJogos(jogadoresLogados, jogador1, jogador2);
            
            }

        }
   }