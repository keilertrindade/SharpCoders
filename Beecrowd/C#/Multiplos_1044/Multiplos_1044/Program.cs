namespace Multiplos_1044
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split();
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            bool multiplos;

            if (A > B)
            {
                if (A % B == 0) { multiplos = true; }
                else
                {
                    multiplos = false;
                }
            }
            else
            {
                if (B % A == 0) { multiplos = true; }
                else { multiplos = false; }
            }

            if (multiplos)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else { Console.WriteLine("Nao sao Multiplos"); }

        }
    }
}