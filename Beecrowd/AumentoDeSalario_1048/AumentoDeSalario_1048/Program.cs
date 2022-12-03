namespace AumentoDeSalario_1048
{
    public class Program
    {
        public static void Main(String[] args)
        {
            double salario = double.Parse(Console.ReadLine());
            //double[] percentual = { 0.15, 0.12, 0.10, 0.07, 0.04 };
            double novoSalario, reajusteGanho, percentual;


            if(salario <= 400.00)
            {
                percentual = 0.15;
                reajusteGanho = salario * percentual;
                novoSalario = salario + reajusteGanho;
            }else if (salario > 400.00 && salario <= 800.00)
            {
                percentual = 0.12;
                reajusteGanho = salario * percentual;
                novoSalario = salario + reajusteGanho;
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                percentual = 0.10;
                reajusteGanho = salario * percentual;
                novoSalario = salario + reajusteGanho;
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                percentual = 0.07;
                reajusteGanho = salario * percentual;
                novoSalario = salario + reajusteGanho;
            }
            else
            {
                percentual = 0.04;
                reajusteGanho = salario * percentual;
                novoSalario = salario + reajusteGanho;
            }

            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
            Console.WriteLine($"Em percentual: {(percentual*100):F0} %");


        }
    }
}