using System;
					
public class Program
{
	public static void Main()
	{
		int valores = 0;
		for (int i=0; i<5;i++){
			int val = int.Parse(Console.ReadLine());
			if(val % 2 == 0) {
			    valores++;
			}
		}
		
		Console.WriteLine($"{valores} valores pares");
		
		
		
	}
}