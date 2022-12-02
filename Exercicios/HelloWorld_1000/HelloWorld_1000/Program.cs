using System; using System.Globalization;

namespace NotasMoedas_1021
{
    public class Program
    {
        public static void Main()
        {

            double[] valor = {100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.05, 0.01};
            double dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int quantidade;

            Console.WriteLine("NOTAS:");
            for (int i = 0; i < 6; i++)
            {
                quantidade = (int)(dinheiro/valor[i]);
                Console.WriteLine($"{quantidade} notas(s) de R$ {valor[i].ToString("F2", CultureInfo.InvariantCulture)}");
                dinheiro -= quantidade * valor[i];
            }

            Console.WriteLine("MOEDAS:");
            for (int i = 6; i < valor.Length; i++)
            {
                quantidade = (int)(dinheiro/valor[i]);
                Console.WriteLine($"{quantidade} moedas(s) de R$ {valor[i].ToString("F2",CultureInfo.InvariantCulture)}");
                dinheiro -= (quantidade * valor[i]);
            }


        }

    }

}