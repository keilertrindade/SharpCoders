using System;
					
public class Program
{
	public static void Main()
	{
		int pares = 0;
		int impares = 0;
		int positivos = 0;
		int negativos = 0;
		
		for (int i=0; i<5;i++){
			int val = int.Parse(Console.ReadLine());
			if(val % 2 == 0) {
			    pares++;
			}else{
			    impares++;
			}
			if(val > 0){
			    positivos++;
			}if(val < 0){
			    negativos++;
			}
		}
		Console.WriteLine($"{pares} valor(es) par(es)");
		Console.WriteLine($"{impares} valor(es) impar(es)");
		Console.WriteLine($"{positivos} valor(es) positivo(s)");
		Console.WriteLine($"{negativos} valor(es) negativo(s)");
	}
}