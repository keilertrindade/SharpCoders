using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
            int senhaCorreta = 2002;
            bool senhaValida = false;
            do{
            int senha = int.Parse(Console.ReadLine());
            if (senha == senhaCorreta){
                Console.WriteLine("Acesso Permitido");
                senhaValida = true;
            }
            else{
                Console.WriteLine("Senha Invalida");
            }
        }while(senhaValida == false);
    }
}