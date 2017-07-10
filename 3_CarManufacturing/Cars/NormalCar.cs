using CarManufacturing.Components;

namespace CarManufacturing.Cars
{
    public class NormalCar : ICar
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