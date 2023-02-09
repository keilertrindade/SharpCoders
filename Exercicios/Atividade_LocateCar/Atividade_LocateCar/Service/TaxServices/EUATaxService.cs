using Atividade_LocateCar.Service.Interfaces;

namespace Atividade_LocateCar.Service.TaxServices
{
    public class EUATaxService : ITaxService
    {
        public double Tax(double amount)
        {
               return 0.12 * amount;
        }
    }
}
