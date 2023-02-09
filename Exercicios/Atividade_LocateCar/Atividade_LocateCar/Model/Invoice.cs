namespace Atividade_LocateCar.Model
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment
        {
            get
            {
                return BasicPayment + Tax;
            }
        
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
    }
}
