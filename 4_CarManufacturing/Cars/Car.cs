using CarManufacturing.Components;

namespace CarManufacturing.Cars
{
    public class Car : ICar
    {
        private readonly IEngine _engine;
        private readonly IGearBox _gearBox;
        private int _speed;

        public Car(IEngine engine, IGearBox gearBox)
        {
            _engine = engine;
            _gearBox = gearBox;
        }

        public void Start()
        {
            _engine.Start();
        }

        public int Accelerate()
        {
            _engine.Raise();
            return ++_speed;
        }

        public int Decelerate()
        {
            _engine.Relax();
            return --_speed;
        }

        public override string ToString()
        {
            return "Car";
        }
    }
}