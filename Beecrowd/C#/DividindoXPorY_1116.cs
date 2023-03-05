using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int testes = int.Parse(Console.ReadLine());
        for(int i = 0; i<testes;i++){
            string[] par = Console.ReadLine().Split();
            
            int x = int.Parse(par[0]);
            int y = int.Parse(par[1]);
            
            if (y == 0){
                Console.WriteLine("divisao impossivel");
            }else{
                double dx = Convert.ToDouble(x);
                double dy = Convert.ToDouble(y);
                double result = dx/dy;
                Console.WriteLine($"{result:F1}");   
            }
        }
    }
}