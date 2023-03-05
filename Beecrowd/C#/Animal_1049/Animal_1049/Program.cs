namespace Animal_1049
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();

            if (palavra1 == "vertebrado")
            {
                if(palavra2 == "ave")
                {
                    if(palavra3 =="carnivoro"){ 
                        Console.WriteLine("aguia");
                    }else if(palavra3 == "onivoro")
                    { Console.WriteLine("pomba"); }
                }else if(palavra2 == "mamifero")
                {
                    if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (palavra3 == "herbivoro")
                    { Console.WriteLine("vaca"); }
                }
            }else if(palavra1 == "invertebrado"){
                if (palavra2 == "inseto")
                {
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (palavra3 == "herbivoro")
                    { Console.WriteLine("lagarta"); }
                }
                else if (palavra2 == "anelideo")
                {
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (palavra3 == "onivoro")
                    { Console.WriteLine("minhoca"); }
                }
            }

        }
    }
}

