using CarManufacturing.Components;

namespace CarManufacturing.Cars
{
    public class SportsCar : ICar
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

        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public int Accelerate()
        {
            throw new System.NotImplementedException();
        }

        public int Decelerate()
        {
            throw new System.NotImplementedException();
        }
    }
}