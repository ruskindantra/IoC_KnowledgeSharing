using Autofac;
using CarManufacturing_Common.Components;

namespace CarManufacturingPerformance
{
    public class PerformanceModule : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.Register(context => new JetEngine()).Named<IEngine>("Jet");
        }
    }
}