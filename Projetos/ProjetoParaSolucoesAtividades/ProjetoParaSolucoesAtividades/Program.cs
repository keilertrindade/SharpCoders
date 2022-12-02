using System;

namespace Resolucao
{
    public class Program
    {
        public static void Main(string[] args)
        {

            static bool isPrime(int value)
            {

                if (value == 1) return false;

                for (int i = 2; i < value; i++)
                {
                    if (value % i == 0) return false;
                }
                return true;
            }

            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (isPrime(numero))
                {
                    Console.WriteLine($"{numero} eh primo");
                }
                else
                {
                    Console.WriteLine($"{numero} nao eh primo");
                }
            }

        }
    }
}