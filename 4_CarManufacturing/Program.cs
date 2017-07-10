using CarManufacturing.Cars;
using CarManufacturing.Components;

namespace CarManufacturing
{
    class Program
    {
        static void Main(string[] args)
        {
            var normalCar1 = new Car(new Engine(4, FuelType.Petrol), new GearBox(4, false));
            var normalCar2 = new Car(new Engine(4, FuelType.Petrol), new GearBox(4, false));

            var sportsCar = new Car(new Engine(4, FuelType.Petrol), new GearBox(6, false));
            var familyCar = new Car(new Engine(4, FuelType.Diesel), new GearBox(4, true));
        }
    }
}
