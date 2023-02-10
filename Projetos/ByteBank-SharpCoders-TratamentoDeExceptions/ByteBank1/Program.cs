using ByteBank1.Exceptions;
using ByteBank1.Model;
using ByteBank1.Service;
using ByteBank1.View;

namespace ByteBank1 {

    public class Program {

        public static void Main(string[] args) {

            ContaService service = new ContaService();

            try
            {
                var loginForm = ContaView.MenuLogin();
                service.login(loginForm);
                service.transferir(20, "1234");

            }catch(PasswordNotMatchException passwordException) {
                Console.WriteLine(passwordException.Message);
            }

        }

    }

}