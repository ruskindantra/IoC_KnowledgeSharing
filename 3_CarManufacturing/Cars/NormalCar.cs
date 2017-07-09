using CarManufacturing.Components;

namespace CarManufacturing.Cars
{
    public class NormalCar
    {
        private Engine _engine;
        private GearBox _gearBox;

        public NormalCar()
        {
            _engine = new Engine(4, FuelType.Petrol);
            _gearBox = new GearBox(4, false);
        }

        public override string ToString()
        {
            return "NormalCar";
        }
    }
}