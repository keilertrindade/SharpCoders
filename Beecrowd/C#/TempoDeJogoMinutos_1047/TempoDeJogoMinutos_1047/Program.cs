namespace TempoDeJogoMinutos_1047
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            int horaInicio = int.Parse(valores[0]);
            int minutoInicio = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);

            DateTime inicio = new DateTime(2022, 12, 03, horaInicio, minutoInicio, 0);
            DateTime final = new DateTime(2022, 12, 03, horaFinal, minutoFinal, 0);

            if (inicio == final)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else if (final < inicio)
            {
                final = new DateTime(2022, 12, 04, horaFinal, minutoFinal, 0);
                Console.WriteLine($"O JOGO DUROU {(final - inicio).Hours} HORA(S) E {(final - inicio).Minutes} MINUTO(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {(final - inicio).Hours} HORA(S) E {(final - inicio).Minutes} MINUTO(S)");
            }


        }
    }
}