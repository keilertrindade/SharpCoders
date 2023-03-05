using System;

namespace TempoDeJogo_1046
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            int horaInicio = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            DateTime inicio = new DateTime(2022, 12, 03, horaInicio, 0, 0);
            DateTime final = new DateTime(2022, 12, 03, horaFinal, 0, 0);

            if(inicio == final)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else if(final < inicio)
            {
                final = new DateTime(2022, 12, 04, horaFinal, 0, 0);
                Console.WriteLine($"O JOGO DUROU {(final - inicio).Hours} HORA(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {(final - inicio).Hours} HORA(S)");
            }


        }
    }
}