namespace Intervalo_1037
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float numero = float.Parse(Console.ReadLine());

            float[] intervalo = { 0, 25, 50, 75, 100 };

            if (numero >= intervalo[0] && numero <= intervalo[1])
            {
                Console.WriteLine($"Intervalo [{intervalo[0]},{intervalo[1]}]");
            }
            else if (numero > intervalo[1] && numero <= intervalo[2])
            {
                Console.WriteLine($"Intervalo ({intervalo[1]},{intervalo[2]}]");
            }
            else if (numero > intervalo[2] && numero <= intervalo[3])
            {
                Console.WriteLine($"Intervalo ({intervalo[2]},{intervalo[3]}]");
            }
            else if (numero > intervalo[3] && numero <= intervalo[4])
            {
                Console.WriteLine($"Intervalo ({intervalo[3]},{intervalo[4]}]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}