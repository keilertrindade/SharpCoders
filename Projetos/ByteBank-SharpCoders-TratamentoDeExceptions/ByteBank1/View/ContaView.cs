using ByteBank1.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.View
{
    public class ContaView
    {
        public static LoginFormDTO MenuLogin()
        {
            Console.WriteLine("Cpf: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Password: ");
            string passowrd = Console.ReadLine();

            return new LoginFormDTO
            {
                Cpf = cpf,
                Password = passowrd,
                Moment = DateTime.Now
            };
        }
    }
}
