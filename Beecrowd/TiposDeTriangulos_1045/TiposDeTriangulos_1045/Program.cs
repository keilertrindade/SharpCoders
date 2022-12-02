namespace TidosDeTriangulos_1045
{
    public class Program
    {
        public static void Main(String[] args)
        {
            double[] valores = new double[3];
            string[] input = Console.ReadLine().Split();
            bool triagulo;
            
            valores[0] = double.Parse(input[0]);
            valores[1] = double.Parse(input[1]);
            valores[2] = double.Parse(input[2]);
            Array.Sort(valores);
            Array.Reverse(valores);

            double A = valores[0];
            double B = valores[1];
            double C = valores[2];

            if(A >= (B + C)){
                Console.WriteLine("NAO FORMA TRIANGULO");
                triagulo = false;
            }
            else
            {
                triagulo = true;
            }
            if (triagulo)
            {
                if(Math.Pow(A,2) == (Math.Pow(B, 2) + Math.Pow(C, 2)))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(A, 2) > (Math.Pow(B, 2) + Math.Pow(C, 2)))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if (Math.Pow(A, 2) < (Math.Pow(B, 2) + Math.Pow(C, 2)))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if(A == B && A == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if(A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
