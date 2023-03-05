namespace DDD_1050
{
    public class Program
    {
        public static void Main(string[] args) {
            int[] DDD = { 61, 71, 11, 21, 32, 19, 27, 31 };
            string[] destination = { "Brasilia", "Salvador", "Sao Paulo","Rio de Janeiro","Juiz de Fora","Campinas","Vitoria","Belo Horizonte"};

            int leitura = int.Parse(Console.ReadLine());
            int posicao = Array.IndexOf(DDD, leitura);

            if (posicao == -1)
            {
                Console.WriteLine("DDD nao cadastrado");
                
            }
            else
            {
                Console.WriteLine(destination[posicao]);
            }
        
        
        }
    }
}