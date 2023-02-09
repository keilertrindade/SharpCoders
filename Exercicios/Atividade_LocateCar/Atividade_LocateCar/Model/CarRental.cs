namespace Atividade_LocateCar.Model
{
    public class CarRental
    {

        public long Id { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }

        public Car Car { get; set; } = null!;

        public Invoice? Invoice { get; set; }

        public Pessoa Pessoa { get; >set; } = null!;

        public CarRental(long id, DateTime start, DateTime finish, Car car, Pessoa pessoa)
        {
            Id = id;
            Start = start;
            Finish = finish;
            Car = car;
            Pessoa = pessoa;
        }
    }
}
