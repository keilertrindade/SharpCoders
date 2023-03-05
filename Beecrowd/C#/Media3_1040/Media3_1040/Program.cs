namespace Media3_1040
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double nota1 = double.Parse(input[0]);
            double nota2 = double.Parse(input[1]);
            double nota3 = double.Parse(input[2]);
            double nota4 = double.Parse(input[3]);

            double media = Math.Round(((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + nota4) / 10, 1);
            

           // media = media / 10;
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
                double notaExame = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {notaExame:F1}");
                media += notaExame; media = media / 2.0;
                if (media >= 5.0) { Console.WriteLine("Aluno aprovado."); }
                else { Console.WriteLine("Aluno reprovado."); }
                Console.WriteLine($"Media final: {media:F1}");

            }

        }
    }
}