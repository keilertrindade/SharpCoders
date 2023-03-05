namespace Lanche_1038
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double[] preco = new double[5] { 4.0, 4.5, 5.0, 2.0, 1.5 };

            int codigo = int.Parse(input[0]);
            int quantidade = int.Parse(input[1]);

            double total = preco[codigo - 1] * quantidade;
            Console.WriteLine($"Total: R$ {total:F2}");
        }
    }
}