using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int testes = int.Parse(Console.ReadLine());
        int soma=0;
        for(int i = 0; i<testes;i++){
            
            string [] valores = Console.ReadLine().Split();
            int[] intval = {int.Parse(valores[0]),int.Parse(valores[1])};
            Array.Sort(intval);
            
            for (int j = intval[0]+1; j<intval[1]; j++){
                if (j%2!=0){
                    soma = soma+j;
                }
            }
            Console.WriteLine(soma);
            soma = 0;
        }
    }
}