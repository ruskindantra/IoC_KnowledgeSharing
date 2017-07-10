using System;

namespace CarManufacturing.Components
{
    public class Engine : IEngine
    {
        private readonly short _numberOfCylinders;
        private readonly FuelType _fuelType;
        private bool _started;

        public Engine(short numberOfCylinders, FuelType fuelType)
        {
            _numberOfCylinders = numberOfCylinders;
            _fuelType = fuelType;
        }

        public void Start()
        {
            if (_started)
                throw new EngineAlreadyStartedException();
            _started = true;
        }

        public void Stop()
        {
            if (!_started)
                throw new EngineNotStartedException();
            _started = false;
        }

        public void Raise()
        {
        }

        public void Relax()
        {

        }
    }
}