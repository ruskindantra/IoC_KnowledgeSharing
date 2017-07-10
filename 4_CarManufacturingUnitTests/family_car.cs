using System;
using CarManufacturing.Cars;
using CarManufacturing.Components;
using FluentAssertions;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Xunit;

namespace CarManufacturingUnitTests
{
    public class family_car
    {
        private readonly Fixture _fixture;

        public family_car()
        {
            _fixture = new Fixture();

            _fixture.Customize(new AutoMoqCustomization());
        }
        
        [Fact]
        public void to_string_should_print_correct_value()
        {
            var car = _fixture.Create<Car>();
            car.ToString().Should().Be("Car");
        }

        /// <summary>
        /// Is this a valid unit test?
        /// </summary>
        [Fact(Skip = "Is this a valid test")]
        public void starting_car_twice_should_throw_exception()
        {
            var familyCar = _fixture.Create<Car>();
            Action startAction = () => familyCar.Start();

            startAction.ShouldNotThrow<EngineAlreadyStartedException>();
            startAction.ShouldThrow<EngineAlreadyStartedException>();
        }

        [Fact]
        public void accerlating_car_should_return_correct_speed()
        {
            var familyCar = _fixture.Create<Car>();
            familyCar.Accelerate().Should().Be(1);
            familyCar.Accelerate().Should().Be(2);
        }

        [Fact]
        public void decerlating_car_should_return_correct_speed()
        {
            var familyCar = _fixture.Create<Car>();
            familyCar.Accelerate();
            familyCar.Accelerate();

            familyCar.Decelerate().Should().Be(1);
        }
    }
}
