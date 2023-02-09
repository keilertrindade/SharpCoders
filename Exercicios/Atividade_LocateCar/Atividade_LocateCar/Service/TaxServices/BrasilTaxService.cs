using Atividade_LocateCar.Service.Interfaces;

namespace Atividade_LocateCar.Service.TaxServices
{
    public class BrasilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
                return 0.15 * amount;

            if (amount <= 500.0)
                return 0.12 * amount;

            return 0.8 * amount;
        }
    }
}
