// Online C# Editor for free
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        int numLinhas = int.Parse(Console.ReadLine());
        bool quadrados = false;
        bool diferentes = true;
        int soma = 0;
        int diagonal = 0;
        
        //Console.WriteLine(numLinhas);
        int[,] matriz = new int [numLinhas,numLinhas];
        for(int i = 0; i<numLinhas;i++){
            string[] input = Console.ReadLine().Split();
            for(int j = 0; j<numLinhas;j++){
                int valor = int.Parse(input[j]);
                matriz[i,j] = valor;
            }
        }
        
        for(int i = 0; i<numLinhas;i++){
            int somaMatriz = 0;
            
            for(int j = 0; j<numLinhas;j++){
                if (i == j){
                diagonal += matriz[i,j];
                }
                
                //somaMatriz += matriz[i,j];
          }
            
        }

        /*Console.WriteLine(matriz[0,2]);
        Console.WriteLine(matriz[1,2]);
        Console.WriteLine(matriz[2,1]);*/
        Console.WriteLine(diagonal);

        
    }
}