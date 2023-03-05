namespace Mes_1052
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] meses = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine(meses[mes-1]);


        }
    }
}