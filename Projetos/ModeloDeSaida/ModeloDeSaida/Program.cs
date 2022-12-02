using System.Formats.Asn1;

namespace modelodedados
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            string nomeDoUsuario = "João";
            string codigoDoUsuario = "123ABC";
            string textoParaSerEnviado = $"O nome do usuário do projeto é: {nomeDoUsuario}";

            Console.WriteLine(textoParaSerEnviado);
            Console.WriteLine("O nome do usuário do projeto é {0} e seu código é {1}", nomeDoUsuario, codigoDoUsuario);
            Console.WriteLine("{0} {1}", textoParaSerEnviado, codigoDoUsuario);

            Console.Write("Fazendo\n");
            Console.Write("Meu código\n");
            Console.Write("Pular\n");
            Console.Write("Linha\n");  
            

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------");

            double altura = 1.8;
            float nota = 8.9f;
            char sexo = 'M';
            long identificador = 4L;

            double pi = 3.14159265;

            Console.WriteLine($"ID = {identificador}");
            Console.WriteLine($"Nome {nome}");
            Console.WriteLine($"Altura: {altura} -- Nota: {nota} -- Sexo: {sexo}");

            Console.WriteLine($"O valor de Pi é: {pi:f3}"); //Tanto pra double quanto pra float colocamos essa notação

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            */

            
            double raio = Double.Parse(Console.ReadLine());
            double n = 3.14159;
            double area = n * (raio * raio);
            Console.WriteLine($"A={area:f4}");
            
        }
    }
}
