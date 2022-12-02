namespace Media3_1040
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] notas = new double[input.Length];
            double media = 0;
            int[] pesos = new int[4] {2,3,4,1};

            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = double.Parse(input[i]);
                media += notas[i] * pesos[i];
            }
            media = media / 100;
            Console.WriteLine($"Media: {media:F1}");
            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }else if(media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                double notaExame = double.Parse(Console.ReadLine()) / 10;
                Console.WriteLine($"Nota do exame: {notaExame:F1}");
                media += notaExame; media = media / 2.0;
                if (media >= 5.0) { Console.WriteLine("Aluno aprovado."); }
                else { Console.WriteLine("Aluno reprovado."); }
                Console.WriteLine($"Media final: {media:F1}");

            }

        }
    }
}