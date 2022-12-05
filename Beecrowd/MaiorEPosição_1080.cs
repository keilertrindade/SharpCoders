using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int testes = int.Parse(Console.ReadLine());;
        int coelhos = 0;
        int ratos = 0;
        int sapos = 0;
        
        for(int i=0; i<testes;i++){
            string[] casos = Console.ReadLine().Split();
            char tipo = char.Parse(casos[1]);
            if (tipo == 'C'){
                coelhos += int.Parse(casos[0]);
            }
            else if (tipo == 'R'){
                ratos += int.Parse(casos[0]);
            }
            else if (tipo == 'S'){
                sapos += int.Parse(casos[0]);
            }
        }
        int total = coelhos+sapos+ratos;
        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        
        double percentCoelhos = (double)(coelhos*100)/total;
        double percentSapos = (double)(sapos*100)/total;
        double percentRatos = (double)(ratos*100)/total;
        
        Console.WriteLine($"Percentual de coelhos: {percentCoelhos:F2} %");
        Console.WriteLine($"Percentual de ratos: {percentRatos:F2} %");
        Console.WriteLine($"Percentual de sapos: {percentSapos:F2} %");
    }
}