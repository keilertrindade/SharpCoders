using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
            int duasNotas = 0;
            //double notas = 0;
            double soma = 0;
            while(duasNotas < 2){
                double nota = double.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10){
                    Console.WriteLine("nota invalida");
                }else{
                    soma += nota;
                    duasNotas++;
                }
            }
            double resultado = soma/2;
            Console.WriteLine($"media = {resultado:F2}");
    }
}