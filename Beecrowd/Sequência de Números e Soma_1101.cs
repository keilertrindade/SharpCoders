using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
            int soma = 0;
            bool continuar = true;
            do{
                string[] input = Console.ReadLine().Split();
                int[] valores = {int.Parse(input[0]), int.Parse(input[1])};
                Array.Sort(valores);
                if(valores[0] <= 0){
                    continuar = false;
                    break;
                }
                else{
                    for(int i = valores[0]; i <= valores[1];i++){
                        Console.Write($"{i} ");
                        soma+=i;
                    }
                    Console.Write($"Sum={soma}\n");
                    soma=0;
                }
            }while(continuar == true);
    }
}