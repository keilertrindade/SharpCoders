using System.Collections.Generic;


namespace QuadradoMagico_2407
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int numLinhas = int.Parse(Console.ReadLine());
            bool linhasIguais = true;
            bool colunasIguais = true;
            bool diferentes = true;
            int diagonal = 0;

            List<int> valores = new List<int>(); //organiza ele por valores
            int[] somaLinhas = new int[numLinhas];
            int[] somaColunas = new int[numLinhas];

            int[,] matriz = new int[numLinhas, numLinhas];

            for (int i = 0; i < numLinhas; i++)
            {
                string[] input = Console.ReadLine().Split();
                somaLinhas[i] = 0;

                for (int j = 0; j < numLinhas; j++)
                {
                    int valor = int.Parse(input[j]);
                    matriz[i, j] = valor;
                    valores.Add(valor);
                    somaLinhas[i] += valor;
                    somaColunas[j] += valor;
                }
            }

            for (int i = 0; i < numLinhas; i++)
            {

                for (int j = 0; j < numLinhas; j++)
                {
                    if (i == j)
                    {
                        diagonal += matriz[i, j];
                    }
                }
            }

            Array.Sort(somaLinhas);
            Array.Sort(somaColunas);
            valores.Sort();

            for (int i = 0; i < numLinhas; i++)
            {
                if (somaLinhas[0] != somaLinhas[i])
                {
                    linhasIguais = false;
                    break;
                }
            }

            for (int i = 0; i < numLinhas; i++)
            {
                if (somaColunas[0] != somaColunas[i])
                {
                    colunasIguais = false;
                    break;
                }
            }

            for (int i = 0; i < valores.Count-2; i++) {
                if (valores[i] == valores[i + 1]) {
                    diferentes = false;
                    break;
                }          
            }

            if (colunasIguais && linhasIguais && diferentes) {
                if (somaLinhas[0] == diagonal)
                {
                    Console.WriteLine(diagonal);
                }
                else {
                    Console.WriteLine(0);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }

}