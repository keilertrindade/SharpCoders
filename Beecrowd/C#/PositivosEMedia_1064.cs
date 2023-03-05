using System;
					
public class Program
{
	public static void Main()
	{
		int valores = 0;
		double soma = 0;
		for (int i=0; i<6;i++){
			double val = double.Parse(Console.ReadLine());
			if(val > 0) {
			    valores++;
			    soma+=val;
			}
		}
		
		Console.WriteLine($"{valores} valores positivos");
		Console.WriteLine($"{(soma/valores):F1}");
		
		
	}
}