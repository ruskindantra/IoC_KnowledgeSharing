﻿using CarManufacturing.Components;

namespace CarManufacturing.Cars
{
    public class FamilyCar : ICar
    {
        private readonly IEngine _engine;
        private readonly IGearBox _gearBox;
        private int _speed;

        public FamilyCar()
        {
            _engine = new Engine(4, FuelType.Diesel);
            _gearBox = new GearBox(4, true);
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
            return "FamilyCar";
        }
    }
}