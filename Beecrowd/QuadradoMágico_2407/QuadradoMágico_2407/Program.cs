using System.Collections.Generic;
using System.Drawing;

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
            int soma = 0;
            int diagonal = 0;

            List<int> valores = new List<int>(); //organiza ele por valores
            int[] somaLinhas = new int[numLinhas];
            int[] somaColunas = new int[numLinhas];


            //Console.WriteLine(numLinhas);
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
                //Adiciono lista com soma dos valores aqui das linhas, e uma pras colunas, as colunas usando o j para somar o valor de j na lista[j]
                //lista para valores iguais; lista para soma das linhas; lista para soma das colunas
            }

            Array.Sort(somaLinhas);
            Array.Sort(somaColunas);

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



            if (colunasIguais && linhasIguais) {
                Console.WriteLine("Linhas e colunas tem o mesmo valor!");
            }
            else
            {
                Console.WriteLine("Linhas e colunas não tem o mesmo valor!");
            }








            /*Console.WriteLine(valores[2]);

            foreach(int elemento in valores)
            {
                Console.Write($"{elemento} - ");
            }
            Console.WriteLine("-------------");
            valores.Sort();

            Console.WriteLine("-------------");
            Console.WriteLine($"Soma colunas 1: {somaColunas[0]}");
            Console.WriteLine($"Soma colunas 2: {somaColunas[1]}");
            Console.WriteLine($"Soma colunas 3: {somaColunas[2]}");
            Console.WriteLine($"Soma colunas 4: {somaColunas[3]}");
            Console.WriteLine("-------------");
            Console.WriteLine($"Soma linhas 1: {somaLinhas[0]}");
            Console.WriteLine($"Soma linhas 2: {somaLinhas[1]}");
            Console.WriteLine($"Soma linhas 3: {somaLinhas[2]}");
            Console.WriteLine($"Soma linhas 4: {somaLinhas[3]}"); */


        }
    }

}