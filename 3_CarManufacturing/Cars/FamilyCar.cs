using CarManufacturing.Components;

namespace CarManufacturing.Cars
{
    public class FamilyCar
    {
        private Engine _engine;
        private GearBox _gearBox;

        public FamilyCar()
        {
            _engine = new Engine(4, FuelType.Diesel);
            _gearBox = new GearBox(4, false);
        }

        public void Start()
        {
            _engine.Start();
        }

        public override string ToString()
        {
            return "FamilyCar";
        }
    }
}