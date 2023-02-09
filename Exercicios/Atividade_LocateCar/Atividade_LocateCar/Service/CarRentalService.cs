using Atividade_LocateCar.Model;

namespace Atividade_LocateCar.Service
{
    public class CarRentalService
    {

        public double PricePerDay { get; set; }

        public double PricePerHour { get; set; }

        private BrasilTaxService _taxService;

        public CarRentalService(double pricePerDay, double pricePerHour)
        {
            PricePerDay = pricePerDay;
            PricePerHour = pricePerHour;
            _taxService = new BrasilTaxService();
        }

        public void ProcessInvoice(CarRental carRental)
        {

            if (carRental.Finish == null)
                return;

            TimeSpan time = (TimeSpan)(carRental.Finish - carRental.Start);
            double basicPayment = 0, tax = 0;

            if (time.Hours > 12.0)
            {
                basicPayment = time.Hours * PricePerHour;
            }

                        tax = _taxService.Tax(basicPayment);
            carRental.Invoice =  new Invoice(basicPayment, tax);

        }













    }
}
