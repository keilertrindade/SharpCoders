using Atividade_LocateCar.Model;
using Atividade_LocateCar.Service;
using Atividade_LocateCar.Service.TaxServices;
using Atividade_LocateCar.View;

namespace Atividade_LocateCar;

public class Program
{
    public static void Main(string[] args) { 
    
        Pessoa pessoa = PessoaView.MenuNovaPessoa();
        Car carro = new Car("ABC1234", "Ferrari");

        DateTime start = new DateTime(2023, 01, 25,10,00,00);
        DateTime finish = new DateTime(2023, 01, 25, 15, 30, 00);

        CarRental aluguel = new CarRental(1L, start, finish, carro, pessoa);

        CarRentalService service = new CarRentalService(150, 15, new BrasilTaxService());
        CarRentalService serviceEUA = new CarRentalService(150, 15, new EUATaxService());
        service.ProcessInvoice(aluguel);
        Console.WriteLine(aluguel);
    }
    

}
