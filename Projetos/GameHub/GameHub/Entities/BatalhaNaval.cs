using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Entities
{
    public class BatalhaNaval
    {
        public char[,] tabuleiro = new char[10, 10];
        public int quantidadeNavios = 0;
        public int naviosAfundados = 0;
        public int jogadordaVez = 1;
        public int quantidadeNaviosInicio = 0;

        public bool emAndamento = true;

        string[] vetorCoordenadas = { " ", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public List<string> coordenadasUsadas = new List<string>();
        public List<string> coordenadasNavios = new List<string>();
        //public List<Navio> naviosJogo = new List<Navio>();

        //public Jogador jogador1, jogador2;

        public BatalhaNaval()
        {
            CriarCampo();
        }

        public void CriarCampo()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabuleiro[i, j] = '~';
                }
            }
        }
        public void AdicionarNoCampo(List<Navio> naviosJogo, int indiceNavio, string coordenadaInicial, string posicao)
        {
            int linha = ((int)coordenadaInicial[0]) - 65;  //A -> J
            int coluna = ((int)coordenadaInicial[1]) - 48; //0 -> 9

            char linhaChar, colunaChar;

            linhaChar = coordenadaInicial[0];
            colunaChar = coordenadaInicial[1];

            for (int contador = 0; contador < naviosJogo[indiceNavio].tamanho; contador++)
            {
                if (posicao == "vertical")
                {
                    linhaChar = (char)(linha + (65 + contador));
                }
                if (posicao == "horizontal")
                {
                    colunaChar = (char)(coluna + (48 + contador));
                }

                char[] chars = { linhaChar, colunaChar };
                //string temp = new string(chars);
                string coordenada = new string(chars);
                naviosJogo[indiceNavio].coordenadasPosicoes.Add(coordenada);
                coordenadasNavios.Add(coordenada);

            }
        }

        public void PovoarCampo(List<Navio> naviosJogo)
        {
            string coordenadaInicial, posicao;
            bool espacosLiberados;


            for (int contagemNavios = 0; contagemNavios < naviosJogo.Count; contagemNavios++)
            {
                quantidadeNavios++;
                do
                {
                    coordenadaInicial = GerarCoordenada();
                    posicao = GerarPosicao();
                    espacosLiberados = VerificarEspaco(posicao, coordenadaInicial, naviosJogo[contagemNavios].tamanho);

                } while (!espacosLiberados);

                AdicionarNoCampo(naviosJogo, contagemNavios, coordenadaInicial, posicao);
                //Console.WriteLine(coordenadaInicial);
            }
            quantidadeNaviosInicio = quantidadeNavios;
        }

        public bool VerificarEspaco(string posicao, string coordenadaInicial, int tamanhoNavio)
        {
            int linha = ((int)coordenadaInicial[0]);// - 65;  //A -> J
            int coluna = ((int)coordenadaInicial[1]);// - 48; //0 -> 9

            if (posicao == "vertical")
            {          
                if (linha + tamanhoNavio > 75)
                {
                    return false;
                }
                else
                {
                    return VerificarOcupadasVertical(tamanhoNavio, coordenadaInicial);
                }
            }
            else
            {
                if (coluna + tamanhoNavio > 58)
                {
                    return false;
                }
                else
                {
                    return VerificarOcupadasHorizontal(tamanhoNavio, coordenadaInicial);
                }
            }
        }

        public bool VerificarOcupadasVertical(int tamanhoNavio, string coordenada)
        {
            int linha = ((int)coordenada[0]) - 65;  //A -> J
            //int coluna = ((int)coordenada[1]) - 48; //0 -> 9
            char linhaChar, colunaChar;

            colunaChar = coordenada[1];

            for (int i = 0; i < tamanhoNavio; i++)
            {
                linhaChar = (char)(linha + (65 + i));

                char[] chars = { linhaChar, colunaChar };
                string temp = new string(chars);

                if (coordenadasNavios.Contains(temp))
                {
                    return false;
                }

            }

            return true;
        }

        public bool VerificarOcupadasHorizontal(int tamanhoNavio, string coordenada)
        {
            //int linha = ((int)coordenada[0]) - 65;  //A -> J
            int coluna = ((int)coordenada[1]) - 48; //0 -> 9
            char linhaChar, colunaChar;

            linhaChar = coordenada[0];

            for (int i = 0; i < tamanhoNavio; i++)
            {
                colunaChar = (char)(coluna + (48 + i));

                char[] chars = { linhaChar, colunaChar };
                string temp = new string(chars);

                if (coordenadasNavios.Contains(temp))
                {
                    return false;
                }

            }

            return true;
        }

        public string GerarCoordenada()
        {

            Random random = new Random();
            string coordenada;
            do
            {
                int linha = random.Next(0, 10);
                int coluna = random.Next(0, 10);

                char linhaChar, colunaChar;

                linhaChar = (char)(linha + 65);
                colunaChar = (char)(coluna + 48);

                char[] chars = { linhaChar, colunaChar };
                coordenada = new string(chars);
            } while (coordenadasUsadas.Contains(coordenada) == true);

            return coordenada;

        }

        public string GerarPosicao()
        {

            String posicao;
            Random random = new Random();
            int temp = random.Next(0, 2);

            if (temp == 0)
            {
                posicao = "vertical";
            }
            else
            {
                posicao = "horizontal";
            }

            return posicao;
        }

        public void ExibirCampo()
        {
            
            for (int i = 0; i < vetorCoordenadas.Length; i++)
            {

                if (i < 10)
                    Console.Write($"{vetorCoordenadas[i]}  ");
                else Console.Write($"{vetorCoordenadas[i]} ");

            }
            Console.WriteLine();
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{(char)(i + 65)} ");
                for (int j = 0; j < 10; j++)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"[");
                    if (tabuleiro[i, j] == 'x')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{tabuleiro[i, j]}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (tabuleiro[i, j] == 'o')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{tabuleiro[i, j]}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.Write($"{tabuleiro[i, j]}");
                    }

                    Console.Write($"]");
                }
                Thread.Sleep(1);
                Console.WriteLine();
                Console.ResetColor();
            }

            Console.WriteLine($"\nNavios no mapa: {quantidadeNavios} - Navios Afundados: {naviosAfundados}");

        }

        public void ValidarBomba(Jogador jogador, List<Navio> navios)
        {
            string coordenada;

            do
            {
                Console.Write($"\n{jogador.nomeJogador} digite uma coordenada: ");
                coordenada = Console.ReadLine();
                coordenada = coordenada.ToUpper();

            } while (!ChecarCoordenadaValida(coordenada));

            LancarBomba(coordenada, jogador, navios);
        }

        public bool ChecarCoordenadaValida(string coordenada)
        {

            if ((coordenada.Length != 2))
            {
                Console.WriteLine("Coordenada inválida. Digite coordenanda entre A0 a J9!");
                return false;
            }

            int linha = (int)coordenada[0];
            int coluna = ((int)coordenada[1]) - 48;

            //Console.WriteLine($"linha: {linha} - coluna: {coluna}");

            if ((linha < 65 || linha > 74) || (coluna < 0 || coluna > 9))
            {
                Console.WriteLine("Coordenada inválida. Digite coordenanda entre A0 a J9!");
                return false;
            }
            if (coordenadasUsadas.Contains(coordenada))
            {
                Console.WriteLine("Coordenada já utilizada, selecione outra!");
                return false;
            }

            return true;
        }
        public void LancarBomba(string coordenada, Jogador jogador, List<Navio> navios)
        {
            coordenadasUsadas.Add(coordenada);
            int linha = ((int)coordenada[0]) - 65;
            int coluna = ((int)coordenada[1]) - 48;

            if (coordenadasNavios.Contains(coordenada))
            {
                tabuleiro[linha, coluna] = 'o';
                VerificarNavio(coordenada, jogador, navios);
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"{jogador.nomeJogador} acertou a água!");
                Console.ResetColor();
                Console.ReadKey();
                tabuleiro[linha, coluna] = 'x';
                jogadordaVez++;
            }

        }
        public void VerificarNavio(string coordenada, Jogador jogador, List<Navio> naviosJogo)
        {
            for (int i = 0; i < naviosJogo.Count; i++)
            {
                if (!naviosJogo[i].derrubado)
                {
                    if (naviosJogo[i].coordenadasPosicoes.Contains(coordenada))
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{jogador.nomeJogador} acertou uma embarcação!");
                        Console.ResetColor();

                        naviosJogo[i].partesAfundadas++;
                        naviosJogo[i].coordenadasPosicoes.Remove(coordenada);
                        if (naviosJogo[i].tamanho == naviosJogo[i].partesAfundadas)
                        {
                            naviosJogo[i].derrubado = true;
                            naviosAfundados++;
                            quantidadeNavios--;
                            jogador.pontuacao += naviosJogo[i].pontuacao;
                            Console.WriteLine($"{jogador.nomeJogador} derrubou uma embarcacao do tipo {naviosJogo[i].tipo}. Recebeu " +
                                $"{naviosJogo[i].pontuacao} pontos!");
                            
                            VerificarAndamentoJogo();
                        }
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }

        public void VerificarAndamentoJogo()
        {
            if (naviosAfundados == quantidadeNaviosInicio) emAndamento = false;
        }

        public void ExibirPontuacaoJogadores(Jogador jogador1, Jogador jogador2)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"\nPontuação: {jogador1.nomeJogador}: {jogador1.pontuacao} pontos\t {jogador2.nomeJogador}: {jogador2.pontuacao} pontos");
            Console.ResetColor();
        }

        public void EncerrarJogo(Jogador jogador1, Jogador jogador2)
        {
            ExibirCampo();
            ExibirPontuacaoJogadores(jogador1, jogador2);
            Console.WriteLine();
            if (jogador1.pontuacao > jogador2.pontuacao)
            {
                Console.WriteLine($"{jogador1.nomeJogador} ganhou o jogo!");
                AtualizarRanking(jogador1, jogador2);

            }
            if (jogador1.pontuacao < jogador2.pontuacao)
            {
                Console.WriteLine($"{jogador2.nomeJogador} ganhou o jogo!");
                AtualizarRanking(jogador2, jogador1);
            }

            Console.ReadKey();
        }

        public void AtualizarRanking(Jogador jogadorVencedor, Jogador jogadorOponente)
        {
            DateTime data = DateTime.Now;
            GerenciadorJSON gerenciadorJSON = new GerenciadorJSON();
            List<RankingBatalhaNaval> rankingBatalhaNaval = gerenciadorJSON.CarregarRankingBatalhaNaval();
            RankingBatalhaNaval partida = new RankingBatalhaNaval();
            partida.data = data;
            partida.vencedor = jogadorVencedor.nomeJogador;
            partida.pontosVencedor = jogadorVencedor.pontuacao;
            partida.oponente = jogadorOponente.nomeJogador;

            
             rankingBatalhaNaval.Add(partida);
             rankingBatalhaNaval.Sort(delegate (RankingBatalhaNaval x, RankingBatalhaNaval y)
             {
                 return x.pontosVencedor.CompareTo(y.pontosVencedor);
             });
            rankingBatalhaNaval.Reverse();
            gerenciadorJSON.SalvarRankingBatalhaNaval(rankingBatalhaNaval);

        }


    }
}
