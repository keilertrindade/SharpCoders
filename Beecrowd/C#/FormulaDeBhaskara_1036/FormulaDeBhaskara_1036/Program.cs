namespace FormulaDeBhaskara_1036
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double A = double.Parse(input[0]);
            double B = double.Parse(input[1]);
            double C = double.Parse(input[2]);

            double delta = Math.Pow(B, 2) - 4 * A * C;

            if(delta < 0 || A == 0) {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double bhaskara1 = (-B + Math.Sqrt(delta)) / (2*A);
                double bhaskara2 = (-B - Math.Sqrt(delta)) / (2*A);
                Console.WriteLine($"R1 = {bhaskara1:F5}");
                Console.WriteLine($"R2 = {bhaskara2:F5}");
            }
        }
    }
}
