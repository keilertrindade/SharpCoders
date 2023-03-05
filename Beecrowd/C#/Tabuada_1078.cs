using System;
					
public class Program
{
	public static void Main()
	{
		int valor = int.Parse(Console.ReadLine());
		for(int i = 1; i<=10; i++){
		    Console.WriteLine($"{i} x {valor} = {(valor*i)}");
		}
	}
}