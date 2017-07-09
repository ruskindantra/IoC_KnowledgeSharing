using CarManufacturing.Components;

namespace CarManufacturing.Cars
{
    public class SportsCar
    {
        private Engine _engine;
        private GearBox _gearBox;

        public SportsCar()
        {
            _engine = new Engine(4, FuelType.Petrol);
            _gearBox = new GearBox(6, false);
        }

        public override string ToString()
        {
            return "SportsCar";
        }
    }
}