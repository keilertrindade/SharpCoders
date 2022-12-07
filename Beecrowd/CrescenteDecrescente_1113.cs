using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split();
        int x = int.Parse(valores[0]);
        int y = int.Parse(valores[1]);
        
        while(x!=y){
            if(x > y){
                Console.WriteLine("Derescente");
            }else{
                Console.WriteLine("Crescente");
            }
            valores = Console.ReadLine().Split();
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
            
        }
    }
}

-------------------

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        bool iguais = true;
        do{
        string[] valores = Console.ReadLine().Split();
        int x = int.Parse(valores[0]);
        int y = int.Parse(valores[1]);
            if(x==y){
                iguais = false;
                break;
            }
            else if(x > y){
                Console.WriteLine("Crescente");
            }else{
                Console.WriteLine("Decrescente");
            }
        }while(iguais);
    }
}