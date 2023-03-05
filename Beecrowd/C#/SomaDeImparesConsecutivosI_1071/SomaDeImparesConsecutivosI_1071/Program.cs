using System;
public class Program
{
    public static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        int contagem = 0;

        if (X > Y)
        {
            for (int i = Y+1; i < X; i++)
            {
                if (i % 2 != 0)
                {
                    contagem += i;
                }
            }
        }
        else
        {
            for (int i = X+1; i < Y; i++)
            {
                if (i % 2 != 0)
                {
                    contagem += i;
                }
            }
        }
        Console.WriteLine(contagem);
    }
}