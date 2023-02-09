using Atividade_LocateCar.Model;
using Atividade_LocateCar.Service.Interfaces;
using Atividade_LocateCar.Service.TaxServices;
using Atividade_LocateCar.Util;
using System.Runtime.CompilerServices;

namespace Atividade_LocateCar.Service
{
    public class CarRentalService
    {
        List<CarRental> rentals;
        public double PricePerDay { get; set; }

        public double PricePerHour { get; set; }

        private ITaxService _taxService;

        public CarRentalService(double pricePerDay, double pricePerHour, ITaxService taxService)
        {
            rentals = new List<CarRental>(); //new List<CarRental>();
            PricePerDay = pricePerDay;
            PricePerHour = pricePerHour;

            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {

            if (carRental.Finish == null)
                return;

            TimeSpan time = (TimeSpan)(carRental.Finish - carRental.Start);
            double basicPayment = 0, tax = 0;

            int days = time.Days, hours = time.Hours;
          
            if(time.Minutes > 0) {
                hours++;
            }
            
            if (hours > 12) {
                days++;
                hours = 0;
            }

            basicPayment = PricePerDay * time.Days + PricePerHour * time.Hours;
            tax = _taxService.Tax(basicPayment);
            carRental.Invoice =  new Invoice(basicPayment, tax);

        }













    }
}
