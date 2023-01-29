namespace BatalhaNaval.Entities
{
    internal class Campo
    {
        public char[,] tabuleiro = new char[10, 10];
        public int quantidadeNavios = 0;
        public int naviosAfundados = 0;

        string[] vetorCoordenadas = { "X", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public List<string> coordenadasUsadas = new List<string>();
        public List<string> coordenadasNavios = new List<string>();
        //public List<Navio> naviosJogo = new List<Navio>();

        //public Jogador jogador1, jogador2;

        public Campo()
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
            string coordenadaInicial, coordenada, posicao;
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
        }

        public bool VerificarEspaco(string posicao, string coordenadaInicial, int tamanhoNavio)
        {
            int linha = ((int)coordenadaInicial[0]);// - 65;  //A -> J
            int coluna = ((int)coordenadaInicial[1]);// - 48; //0 -> 9

            bool retorno = true;

            if (posicao == "vertical")
            {
                //for (int i = 0; i < tamanhoNavio; i++)
                //{
                if (linha + tamanhoNavio > 75)
                {
                    return false;
                }
                else
                {
                    return VerificarOcupadasVertical(tamanhoNavio, coordenadaInicial);
                }

                //}
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
                Console.WriteLine();
                Console.ResetColor();
            }
            
            Console.WriteLine($"\nNavios no mapa: {quantidadeNavios} - Navios Afundados: {naviosAfundados}");

        }

        public void ValidarBomba(Jogador jogador)
        {
            string tiro;

            do
            {
                Console.Write("\nDigite a coordenada: ");
                tiro = Console.ReadLine();
                tiro = tiro.ToUpper();

            } while (!ChecarCoordenadaValida(tiro));

            LancarBomba(tiro, jogador);
        }

        public bool ChecarCoordenadaValida(string coordenada)
        {
            int linha = (int)coordenada[0];
            int coluna = ((int)coordenada[1]) - 48;

            //Console.WriteLine($"linha: {linha} - coluna: {coluna}");

            if ((linha < 65 || linha > 74) || (coluna < 0 || coluna > 9) || (coordenada.Length > 2))
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

        public void LancarBomba(string coordenada, Jogador jogador)
        {
            coordenadasUsadas.Add(coordenada);
            int linha = ((int)coordenada[0]) - 65;
            int coluna = ((int)coordenada[1]) - 48;

            if (coordenadasNavios.Contains(coordenada))
            {
                tabuleiro[linha, coluna] = 'o';
                VerificarNavio(coordenada, Program.navios, jogador);
            }
            else
            {
                tabuleiro[linha, coluna] = 'x';
                Program.jogadorVez++;
            }

        }


        public void VerificarNavio(string coordenada, List<Navio> naviosJogo, Jogador jogador)
        {
            for (int i = 0; i < naviosJogo.Count; i++)
            {
                if (!naviosJogo[i].derrubado)
                {
                    if (naviosJogo[i].coordenadasPosicoes.Contains(coordenada))
                    {
                        naviosJogo[i].partesAfundadas++;
                        naviosJogo[i].coordenadasPosicoes.Remove(coordenada);
                        if (naviosJogo[i].tamanho == naviosJogo[i].partesAfundadas)
                        {
                            naviosJogo[i].derrubado = true;
                            naviosAfundados++;
                                jogador.pontuacao += naviosJogo[i].pontuacao;
                                Console.WriteLine($"{jogador.Nome} derrubou uma embarcacao do tipo {naviosJogo[i].tipo}. Recebeu " +
                                    $"{naviosJogo[i].pontuacao} pontos por isso!");
                                Console.ReadLine();
                        }
                        break;
                    }
                }
            }
        }

        public void EncerrarJogo()
        {
            Console.WriteLine();
        }


    }


}
