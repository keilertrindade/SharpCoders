using System;

namespace ImpostoDeRenda_1051
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine());
            double[] imposto = { 0.08, 0.18, 0.28 };
            //valor = valor / 100.00;
            double faixa;
            if (valor >= 0.00 && valor <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (valor >= 2000.01 && valor <= 3000.00){
                double faixafinal = (valor - 2000) * imposto[0];
                Console.WriteLine($"R$ {faixafinal:F2}");
            }
            else if (valor >= 3000.01 && valor <= 4500.00)
            {
                double faixa1 = ((valor-2000) - (valor-3000)) * imposto[0];
                double faixa2 = (valor - 3000) * imposto[1];

                double faixafinal = faixa1 + faixa2;
                Console.WriteLine($"R$ {faixafinal:F2}");
            }
            else
            {
                
                double faixa3 = (valor - 4500) * imposto[2];
                double faixa2 = 1500 * imposto[1];
                double faixa1 = 1000 * imposto[0];
                double faixafinal = faixa1 + faixa2 + faixa3;
                Console.WriteLine($"R$ {faixafinal:F2}");
            }

        }
    }
}