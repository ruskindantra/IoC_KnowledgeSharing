using System;
using System.Collections;
using System.Collections.Generic;
using Autofac;
using Autofac.Features.Indexed;
using CarManufacturing.Cars;
using GearBox = CarManufacturing.Components.GearBox;
using IGearBox = CarManufacturing.Components.IGearBox;

// For Jet engine
//using Engine = CarManufacturing_Common.Components.Engine;
//using IEngine = CarManufacturing_Common.Components.IEngine;
//using FuelType = CarManufacturing_Common.Components.FuelType;

// For engine
using Engine = CarManufacturing.Components.Engine;
using IEngine = CarManufacturing.Components.IEngine;
using FuelType = CarManufacturing.Components.FuelType;

namespace CarManufacturing
{
    class Program
    {
        static void Main(string[] args)
        {
            TraditionalRegistration();
            //NamedRegistrations();

            //ModuleRegistrations();
        }

        private static void ModuleRegistrations()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.Register(context => new Engine(4, FuelType.Petrol)).Named<IEngine>("4CylinderPetrolEngine");
            containerBuilder.Register(context => new Engine(4, FuelType.Diesel)).Named<IEngine>("4CylinderDieselEngine");

            containerBuilder.RegisterType<GearBox>().As<IGearBox>();
            containerBuilder.RegisterType<Car>().As<ICar>();
            containerBuilder.RegisterModule<CarManufacturingPerformance.PerformanceModule>();
            containerBuilder.RegisterType<CarPlantWithModule>();

            var container = containerBuilder.Build();

            var carPlant = container.Resolve<CarPlantWithModule>();
        }

        private static void NamedRegistrations()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.Register(context => new Engine(4, FuelType.Petrol)).Named<IEngine>("4CylinderPetrolEngine");
            containerBuilder.Register(context => new Engine(4, FuelType.Diesel)).Named<IEngine>("4CylinderDieselEngine");

            containerBuilder.RegisterType<GearBox>().As<IGearBox>();
            containerBuilder.RegisterType<Car>().As<ICar>();
            containerBuilder.RegisterType<CarPlantWithNamedInstances>();

            var container = containerBuilder.Build();

            var carPlant = container.Resolve<CarPlantWithNamedInstances>();
        }
        

        private static void TraditionalRegistration()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<Engine>().As<IEngine>();
            containerBuilder.RegisterType<GearBox>().As<IGearBox>();
            containerBuilder.RegisterType<Car>().As<ICar>();
            containerBuilder.RegisterType<CarPlant>();

            var container = containerBuilder.Build();

            //var car = container.Resolve<ICar>(); // won't work...why?
            //var carFactory = container.Resolve<Func<IEngine, IGearBox, ICar>>(); // what is this?

            var carPlant = container.Resolve<CarPlant>();
        }
    }

    class CarPlantWithModule
    {
        public CarPlantWithModule(IIndex<string, IEngine> engines, Func<short, bool, IGearBox> gearboxFactory, Func<IEngine, IGearBox, ICar> carFactory)
        {
            var normalCar1 = carFactory(engines["4CylinderPetrolEngine"], gearboxFactory(4, false));
            var normalCar2 = carFactory(engines["4CylinderPetrolEngine"], gearboxFactory(4, false));

            var sportsCar = carFactory(engines["4CylinderPetrolEngine"], gearboxFactory(6, false));
            var familyCar = carFactory(engines["4CylinderDieselEngine"], gearboxFactory(4, true));
            
            // move to new interface definitions
            var jetCar = carFactory(engines["Jet"], gearboxFactory(4, false));

        }
    }

    class CarPlantWithNamedInstances
    {
        public CarPlantWithNamedInstances(IIndex<string, IEngine> engines, Func<short, bool, IGearBox> gearboxFactory, Func<IEngine, IGearBox, ICar> carFactory)
        {
            var normalCar1 = carFactory(engines["4CylinderPetrolEngine"], gearboxFactory(4, false));
            var normalCar2 = carFactory(engines["4CylinderPetrolEngine"], gearboxFactory(4, false));

            var sportsCar = carFactory(engines["4CylinderPetrolEngine"], gearboxFactory(6, false));
            var familyCar = carFactory(engines["4CylinderDieselEngine"], gearboxFactory(4, true));
        }
    }

    class CarPlant
    {
        public CarPlant(Func<short, FuelType, IEngine> engineFactory, Func<short, bool, IGearBox> gearboxFactory, Func<IEngine, IGearBox, ICar> carFactory)
        {
            var normalCar1 = carFactory(engineFactory(4, FuelType.Petrol), gearboxFactory(4, false));
            var normalCar2 = carFactory(engineFactory(4, FuelType.Petrol), gearboxFactory(4, false));

            var sportsCar = carFactory(engineFactory(4, FuelType.Petrol), gearboxFactory(6, false));
            var familyCar = carFactory(engineFactory(4, FuelType.Diesel), gearboxFactory(4, true));
        }
    }
}
