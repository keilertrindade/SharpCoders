using System;

namespace Triangulo_1043
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            double A = double.Parse(valores[0]);
            double B = double.Parse(valores[1]);
            double C = double.Parse(valores[2]);
            double perimetro = (A + B + C)/2;

            double area = Math.Sqrt((perimetro * (perimetro - A) * (perimetro - B) * (perimetro * C)));

            if (area > 0)
            {                
                Console.WriteLine($"Perimetro = {(A+B+C):F1}");
            }
            else
            {
                double trapezioArea = ((A + B) * C) / 2;
                Console.WriteLine($"Area = {trapezioArea:F1}");
            }

        }
    }
}
