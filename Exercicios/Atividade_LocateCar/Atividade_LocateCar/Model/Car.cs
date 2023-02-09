namespace Atividade_LocateCar.Model
{
    public class Car
    {

        public string Placa { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public bool isAvailable { get; set; } = true;

        public Car(string placa, string marca)
        {
            Placa = placa;
            Marca = marca;
        }
    }
}