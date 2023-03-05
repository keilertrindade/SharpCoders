using System;
					
public class Program
{
	public static void Main()
	{
		int numero = int.Parse(Console.ReadLine());
		if(numero%2==0){
		    numero++;
		}
		for (int i=0; i<6; i++){
			 Console.WriteLine(numero);
			 numero+=2;
		}
		
		
	}
}