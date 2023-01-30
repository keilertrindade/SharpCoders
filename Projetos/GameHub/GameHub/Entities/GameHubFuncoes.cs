using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameHub.Entities
{
    internal class GameHubFuncoes
    {
        public GameHubFuncoes() { }
        public void ShowMenu()
        {

            Console.Clear();
            Console.WriteLine("\t### Bem Vindo ao GameHub! ###\n\n");
            Console.WriteLine("\t1 - Cadastrar novo usuário");
            Console.WriteLine("\t2 - Login de usuário");
            Console.WriteLine("\t3 - Acessar jogos");
            Console.WriteLine("\t4 - Exibir ranking Jogo da Velha");
            Console.WriteLine("\t5 - Exibir ranking Batalha Naval");
            Console.WriteLine("\t6 - Logoff dos usuários");
            Console.WriteLine("\t0 - Para sair do programa\n");
            Console.Write("Digite a opção desejada: ");
        }

        public void ShowMenuJogos(List<Jogador> jogadores)
        {
            Console.Clear();
            Console.WriteLine("\t### GameHub - Menu Jogos ###");
            Console.WriteLine($"\n\tUsuários logados: {jogadores[0].nomeJogador} e {jogadores[1].nomeJogador}\n");
            Console.WriteLine("\t1 - Jogo da Velha");
            Console.WriteLine("\t2 - Batalha Naval");
            Console.WriteLine("\t0 - Menu Inicial\n");
            Console.Write("Digite a opção desejada: ");
        }


        /*  static void LoginUsuario(List<string> cpfs, List<string> senhas, List<string> titulares, List<double> saldos)
          {
              Console.Write("Digite o Login <Nome de usuário>: ");
              string nomeUsuario = Console.ReadLine();
              //int cpfIndex = cpfs.FindIndex(cpf => cpf == cpfParaLogin);
              Console.Write("Digite a senha: ");
              string senhaParaLogin = Console.ReadLine();

              if (cpfIndex == -1)
              {
                  Console.WriteLine("USUÁRIO OU SENHA INVÁLIDOS!");
              }
              else
              {
                  if (senhas[cpfIndex] == senhaParaLogin)
                  {
                      Console.WriteLine($"Seja bem vindo {titulares[cpfIndex]}");
                      //MenuUsuario(cpfIndex, cpfs, senhas, titulares, saldos);
                  }
                  else
                  {
                      Console.WriteLine("Usuário ou senha inválidos!");
                  }
              }
          } */

        public void CadastrarUsuario(GerenciadorJSON gerenciadorJSON)
        {
            List<Jogador> jogadoresCadastrados;
            jogadoresCadastrados = gerenciadorJSON.CarregarJogadores();

            Console.Write("Digite o nome de usuário: ");
            string nome = Console.ReadLine();

             for(int contador = 0; contador < jogadoresCadastrados.Count; contador++)
            {
                if (jogadoresCadastrados[contador].nomeJogador == nome)
                {
                    Console.WriteLine("Usuário já cadastrado no sistema");
                    Console.ReadLine();
                    break;
                }
            }

            Console.Write("Digite a senha do usuário: ");
            string senha = Console.ReadLine();

            Jogador jogador = new Jogador(nome);
            jogador.senha = senha;

            jogadoresCadastrados.Add(jogador);
            gerenciadorJSON.SalvarJogadores(jogadoresCadastrados);

        }

        public void LoginUsuario(List<Jogador> jogadoresLogados, GerenciadorJSON gerenciadorJSON)
        {
            if (jogadoresLogados.Count == 2)
            {
                Console.WriteLine($"O sistema já possui dois jogadores logados: {jogadoresLogados[0].nomeJogador} e {jogadoresLogados[1].nomeJogador}");
                Console.ReadLine();

            }
            else
            {

                List<Jogador> jogadoresCadastrados;
                jogadoresCadastrados = gerenciadorJSON.CarregarJogadores();
                Console.Write("Digite o nome do usuário: ");
                string nome = Console.ReadLine();
                Console.Write("Digite a senha: ");
                string senha = Console.ReadLine();
                bool loginSucedido = false;

                for (int contador = 0; contador < jogadoresCadastrados.Count; contador++)
                {
                    if (jogadoresCadastrados[contador].nomeJogador == nome)
                    {
                        if (jogadoresCadastrados[contador].senha == senha)
                        {
                            if (jogadoresLogados.Count == 0)
                            {
                                Program.jogador1 = new Jogador(nome);
                                jogadoresLogados.Add(Program.jogador1);
                            }
                            else if (jogadoresLogados.Count == 1)
                            {
                                Program.jogador2 = new Jogador(nome);
                                jogadoresLogados.Add(Program.jogador2);
                            }
                            Console.WriteLine($"Bem vindo {nome}!");
                            loginSucedido = true;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Usuário ou senha incorretos!");
                            Console.ReadLine();
                        }

                        break;
                    }
                }

                if (!loginSucedido)
                {
                    Console.WriteLine("Usuário não cadastrado no sistema");
                    Console.ReadLine();
                }
                


            }

            
        }

        public void Logoff(List<Jogador> jogadoresLogados)
        {
            jogadoresLogados.Clear();
        }

        public void AcessarMenuJogos(List<Jogador> jogadoresLogados, Jogador jogador1, Jogador jogador2)
        {
            int option;
            if(jogadoresLogados.Count < 2)
            {
                Console.WriteLine("Você precisa ter dois jogadores logados para acessar o menu de jogos!");
                Console.ReadLine();
            }
            else
            {
                do
                {
                    ShowMenuJogos(jogadoresLogados);
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("Estou encerrando o programa...");
                            break;
                        case 1:
                            IniciarJogoDaVelha(jogador1, jogador2);
                            break;
                        case 2:
                            IniciarBatalhaNaval(jogador1, jogador2);
                            break;
                    }
                } while (option != 0);
            }

            

        }

        public void ExibirRankingJogoDaVelha()
        {

        }

        public void ExibirRankingBatalhaNaval()
        {

        }

        public void IniciarJogoDaVelha(Jogador jogador1, Jogador jogador2)
        {
            controladorJogoDaVelha novoJogoDaVelha = new (jogador1, jogador2);
            novoJogoDaVelha.Controle();

        }

        public void IniciarBatalhaNaval(Jogador jogador1, Jogador jogador2)
        {
            controladorBatalhaNaval novoBatalhaNaval = new controladorBatalhaNaval(jogador1, jogador2);
            novoBatalhaNaval.IniciarJogo(jogador1,jogador2);
        }


    }

}

